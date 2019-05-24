using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canteen_System
{
    public partial class New_Employee_Form : Form
    {
        MySqlConnection conn;
        
        string strConn = "datasource=localhost;port=3306;username=root;password=;database=db_canteen_system";

        public New_Employee_Form()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txt_ID_NUMBER.Text = "";
            txt_NAME.Text = "";
        }

        public void addEmployee()
        {
            Canteen c = new Canteen();
            try
            {
                conn = new MySqlConnection(strConn);
                
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string nall = null;
                //MessageBox.Show(id);
                //string getIDCateg = cbStatus.Text.Split(' ')[0];
                cmd.CommandText = "insert into tbl_employee_stat values("+ this.txt_ID_NUMBER.Text + ",'"+ this.txt_NAME.Text + "'," + cbStatus.Text.Split(' ')[0] + ")";
                //cmd.CommandText = "Insert into tbl_employee_status values("+ nall +","+ nall +","+ cbStatus.Text.Split(' ')[0] + ")";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee  Successfully Added");
                clear();
                c.Refreshwindow();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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

        private void New_Employee_Form_Load(object sender, EventArgs e)
        {
            showcbStatus(cbStatus);
        }
        

        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Canteen c = new Canteen();
            addEmployee();
            c.Refreshwindow();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_ID_NUMBER_Enter(object sender, EventArgs e)
        {
            if (txt_ID_NUMBER.Text.Trim() != "" || txt_ID_NUMBER.Text != null)

            {

                txt_ID_NUMBER.Text = "";

            }
        }

        private void txt_NAME_Enter(object sender, EventArgs e)
        {
            if (txt_NAME.Text.Trim() != "" || txt_NAME.Text != null)

            {

                txt_NAME.Text = "";

            }
        }
    }
}
