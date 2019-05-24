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
    public partial class Add_New_Account : Form
    {
        MySqlConnection conn;

        string strConn = "datasource=localhost;port=3306;username=root;password=;database=db_canteen_system";
        public Add_New_Account()
        {
            InitializeComponent();
        }

        public void showcbType(ComboBox cbStype)
        {

            conn = new MySqlConnection(strConn);

            string Query = "select * from tbl_account";

            MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
            MySqlDataReader myReader;

            try
            {

                conn.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {

                    string strName = myReader.GetString(0) + " - " + myReader.GetString(1);
                    cbStype.Items.Add(strName);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void Add_New_Account_Load(object sender, EventArgs e)
        {
            showcbType(cbStype);
        }

        private void tb_Name_Enter(object sender, EventArgs e)
        {
            if (tb_Name.Text.Trim() != "" || tb_Name.Text != null)

            {

                tb_Name.Text = "";

            }
        }

        private void tb_LastName_Enter(object sender, EventArgs e)
        {
            if (tb_LastName.Text.Trim() != "" || tb_LastName.Text != null)

            {

                tb_LastName.Text = "";

            }
        }

        private void tb_Address_Enter(object sender, EventArgs e)
        {
            if (tb_Address.Text.Trim() != "" || tb_Address.Text != null)

            {

                tb_Address.Text = "";

            }
        }

        private void tb_ContactNumber_Enter(object sender, EventArgs e)
        {
            if (tb_ContactNumber.Text.Trim() != "" || tb_ContactNumber.Text != null)

            {

                tb_ContactNumber.Text = "";

            }
        }

        private void tb_Username_Enter(object sender, EventArgs e)
        {
            if (tb_Username.Text.Trim() != "" || tb_Username.Text != null)

            {

                tb_Username.Text = "";

            }
        }

        private void tb_Password_Enter(object sender, EventArgs e)
        {
            if (tb_Password.Text.Trim() != "" || tb_Password.Text != null)

            {

                tb_Password.Text = "";

            }
        }

        private void tb_ContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (cbStype.Text == "")
            {
                MessageBox.Show("Please Select user type");
            }
            else if (tb_Name.Text == "")
            {
                MessageBox.Show("Please Enter Name");
            }
            else if (tb_LastName.Text == "")
            {
                MessageBox.Show("Please Enter Last Name");
            }
            else if (tb_ContactNumber.Text == "")
            {
                MessageBox.Show("Please Enter Contact Number");
            }
            else if (tb_Username.Text == "")
            {
                MessageBox.Show("Please Enter Username");
            }
            else if (tb_Password.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }
            else if (tb_Address.Text == "")
            {
                MessageBox.Show("Please Enter Address");
            }
            else if (cbStype.Text != "" || tb_Name.Text != "" || tb_LastName.Text != "" || tb_ContactNumber.Text != "" || tb_Address.Text != "" || tb_Username.Text != "" || tb_Password.Text != "")
            {
                addAccount();
            }
        }

        public void addAccount()
        {
            try
            {
                conn = new MySqlConnection(strConn);
                
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string nall = "null";
                //MessageBox.Show(id);
                //string getIDCateg = cbStatus.Text.Split(' ')[0];
                cmd.CommandText = "insert into tbl_user values("+nall+",'" + this.tb_Name.Text + "','" + this.tb_LastName.Text + "','"+this.tb_Address.Text+"','"+this.tb_ContactNumber.Text+"','"+this.tb_Username.Text+"','"+this.tb_Password.Text+"'," + cbStype.Text.Split(' ')[0] + ")";
                //cmd.CommandText = "Insert into tbl_employee_status values("+ nall +","+ nall +","+ cbStatus.Text.Split(' ')[0] + ")";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("user  Successfully Added");
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
