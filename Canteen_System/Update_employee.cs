using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canteen_System
{
   
    public partial class Update_employee : Form
    {
        MySqlConnection conn;

        string strConn = "datasource=localhost;port=3306;username=root;password=;database=db_canteen_system";
        public Update_employee()
        {
            InitializeComponent();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showcbStatus(ComboBox cbStatus)
        {

            conn = new MySqlConnection(strConn);

            string Query = "select * from tbl_status";

            MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
            MySqlDataReader myReader;

            try
            {

                conn.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {

                    string strName = myReader.GetString(0) + " - " + myReader.GetString(1);
                    cbStatus.Items.Add(strName);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void Update_employee_Load(object sender, EventArgs e)
        {
            showcbStatus(cbStatus);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_View_History_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tb_id.Text);
            History h = new History();
            //string rowid = tb_Id_Number.Text;
            //DataGridViewRow row = DGV_Employee.Rows[rowid];
            //string idnumber = tb_id.ToString();
            //----------------------------------------------

            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("Select id_number as 'ID NUMBER', amount as AMOUNT, date as DATE from tbl_transaction_history where id_number = " + tb_id.Text + " AND date between date_sub(now(),INTERVAL 1 WEEK) and now();", conn);
                dt = new DataTable();
                da.Fill(dt);
                h.Dgv_Transactionoftheweek.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                
            }
            //----------------------------------------------

            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("SELECT tbl_payment.id_number AS 'ID NUMBER', tbl_employee_stat.employee_name AS 'NAME', tbl_payment.amount AS 'AMOUNT PAID', tbl_payment.date_pay as 'DATE PAID', tbl_payment_status.status AS 'STATUS' FROM ((tbl_payment inner JOIN tbl_payment_status ON tbl_payment.status = tbl_payment_status.id) inner JOIN tbl_employee_stat ON tbl_payment.id_connect = tbl_employee_stat.id_number) where tbl_payment.id_number = "+tb_id.Text+ " AND tbl_payment.date_pay between date_sub(now(),INTERVAL 1 WEEK) and now();", conn);
                dt = new DataTable();
                da.Fill(dt);
                h.DGV_View_History.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ;

            h.Show();
            //
        }

        private void btn_Ok_Click_1(object sender, EventArgs e)
        {
            if (cbStatus.Text == "" || tb_Id_Number.Text == "" || tb_Name.Text == "")
            {
                MessageBox.Show("Please Fill all the Information");
            }
            else if (cbStatus.Text != "" || tb_Id_Number.Text != "" || tb_Name.Text != "")
            {
                UpdateEmployee();
            }
                
        }

        public void UpdateEmployee()
        {
            string getid ="";
            getid = cbStatus.Text.Split(' ')[0];

       
            try
            {

                conn = new MySqlConnection(strConn);


                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Update tbl_employee_stat set id_number = '" + tb_Id_Number.Text + "', employee_name = '" + tb_Name.Text + "', status = '" + cbStatus.Text + "' where id_number = " + tb_Id_Number.Text + "";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Update Successfully!");
            }

            catch 
            {
                MessageBox.Show("Please Fill Up the Remaining Fields");
            }



        }
    }
}
