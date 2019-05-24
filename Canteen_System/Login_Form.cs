using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canteen_System
{
    public partial class Login_Form : Form
    {
        MySqlConnection conn;
        String NameIdentifier;
        String LastNameIdentifier;
        String accountIdentifier;
        String userididentifier;
        string strConn = "datasource=localhost;port=3306;username=root;password=;database=db_canteen_system";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

           
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );
        public Login_Form()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            tb_Password.PasswordChar = '*';
        }

        private void tb_Username_Enter(object sender, EventArgs e)
        {
            if (tb_Username.Text.Trim() != "" || tb_Username.Text != null)

            {

                tb_Username.Text = "";

            }
        }

        private void tb_Username_Leave(object sender, EventArgs e)
        {

        }

        private void tb_Password_Enter(object sender, EventArgs e)
        {
            if (tb_Password.Text.Trim() != "" || tb_Password.Text != null)

            {

                tb_Password.Text = "";

            }
        }

        private void tb_Password_Leave(object sender, EventArgs e)
        {

        }

        public void login()
        {
            try
            {

                conn = new MySqlConnection(strConn);
                conn.Open();
                int i = 0;
                MySqlCommand cmd = conn.CreateCommand();
                MySqlCommand getID = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " select * from tbl_user where Username = '" + this.tb_Username.Text + "' and Password = '" + this.tb_Password.Text + "'";
                cmd.ExecuteNonQuery();

                String strQuery = "select * from tbl_user";


                MySqlCommand dmc = new MySqlCommand(strQuery, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    accountIdentifier = (dr["account_id"].ToString());
                    NameIdentifier = (dr["Name"].ToString());
                    LastNameIdentifier = (dr["LastName"].ToString());
                    userididentifier = (dr["user_id"].ToString());


                }

                conn.Close();
                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {

                    MessageBox.Show("Invalid User!");
                    tb_Username.Text = "";
                    tb_Password.Text = "";


                }
                else if (Convert.ToInt32(accountIdentifier) == 2)
                {
                    String NameandLastname = LastNameIdentifier + ", " + NameIdentifier;
                    Canteen can = new Canteen();
                    can.NameOfTheUser.Text = NameandLastname;
                    //IdoftheUser = userididentifier;
                    //txtLogOn.Text = "Cashier";
                    this.Hide();
                    can.Show();
                    savedLogs(tb_Username, tb_Password);


                }
                else if (Convert.ToInt32(accountIdentifier) == 1)
                {
                    String NameandLastname = LastNameIdentifier + ", " + NameIdentifier;
                    Canteen can = new Canteen();
                    can.NameOfTheUser.Text = NameandLastname;
                    can.identify_ID.Text = userididentifier;
                    //IdoftheUser = userididentifier;
                    //txtLogOn.Text = "Cashier";
                    this.Hide();
                    can.Show();
                    can.Btn_Employee_List.Enabled = false;
                    can.Btn_OverView.Enabled = false;
                    can.Btn_Report.Enabled = false;
                    can.Btn_Payment.Enabled = false;
                    
                    savedLogs(tb_Username, tb_Password);


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public void savedLogs(TextBox txtUsername, TextBox txtPassword)
        {
            

            try
            {

                String nall = "null";


                conn = new MySqlConnection(strConn);


                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;




                cmd.CommandText = "insert into tbl_logs values(" + nall + ", " + userididentifier + ", now())";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";


            }

            catch
            {

            }

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
