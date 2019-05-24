
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
using MySql.Data.MySqlClient;


namespace Canteen_System
{
    public partial class Canteen : Form
    {
       
        DataTable table = new DataTable();
        MySqlConnection conn;

        string strConn = "datasource=localhost;port=3306;username=root;password=;database=db_canteen_system";

        public MySqlDataAdapter da;
        public DataTable dt;
        
        public Canteen()
        {
            InitializeComponent();
            Refreshwindow();
            
           // buttonOnDgvHistory();
            //buttonOnDgvEdit();
        }
      
        public void Refreshwindow()
        {
            viewEmployee();
            //displayEmployee();
            displayTransaction();
            displayallpayment();
            DisplayActiveEmployee();
            DisplayInActiveEmployee();
            DisplayTotalOweOfTheWeek();
            showOwe();

           // get();

            //Employee_name();
            //nameLoader();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Main.SelectedTab = Tab_Employee_List;
            LB_Employee_list.Visible = false;
            if (LB_Employee_list.Visible == false)
            {
                Trans_Label.ShowSync(LB_Employee_list);
            }
            Refreshwindow();
        }

        private void Btn_Transaction_Click(object sender, EventArgs e)
        {
            Main.SelectedTab = Tab_Transaction;
            LB_Transaction.Visible = false;
            if (LB_Transaction.Visible == false)
            {
                Trans_Label.ShowSync(LB_Transaction);
            }
            Refreshwindow();
            //Trans_Label
        }

        private void Btn_OverView_Click(object sender, EventArgs e)
        {
            Main.SelectedTab = Tab_OverView;
            LB_OverView.Visible = false;
            if (LB_OverView.Visible == false)
            {
                Trans_Label.ShowSync(LB_OverView);
            }
            Refreshwindow();
        }

        private void Btn_Report_Click(object sender, EventArgs e)
        {
            Main.SelectedTab = Tab_Reports;
            LB_Reports.Visible = false;
            if (LB_OverView.Visible == false)
            {
                Trans_Label.ShowSync(LB_Reports);
            }
            Refreshwindow();
        }

        private void bunifuMaterialTextbox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_Peyment_Click(object sender, EventArgs e)
        {
            Main.SelectedTab = Tab_Peyment;
            LB_Payment.Visible = false;
            if (LB_Payment.Visible == false)
            {
                Trans_Label.ShowSync(LB_Payment);
            }
        }


        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void TB_Id_Number_Leave(object sender, EventArgs e)
        {

        }

        private void TB_Id_Number_Enter_1(object sender, EventArgs e)
        {

        }

        private void TB_Id_Number_KeyPress(object sender, KeyPressEventArgs e)
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


        private void Tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void Tb_Amount_KeyPress(object sender, KeyPressEventArgs e)
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


        public void viewEmployee()
        {

            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter(" select tbl_employee_stat.id_number as 'ID NUMBER', tbl_employee_stat.employee_name as 'EMPLOYEE NAME', tbl_status.status as STATUS from tbl_employee_stat join tbl_status on tbl_employee_stat.status = tbl_status.id;", conn);
                dt = new DataTable();
                da.Fill(dt);
                DGV_Employee.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void TB_Id_Number_OnValueChanged(object sender, EventArgs e)
        {
           MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("SELECT tbl_transaction_history.id_number AS 'ID NUMBER', tbl_employee_stat.employee_name AS NAME, tbl_transaction_history.amount AS AMOUNT, tbl_transaction_history.date AS DATE from tbl_transaction_history inner JOIN tbl_employee_stat on tbl_transaction_history.id_connect = tbl_employee_stat.id_number WHERE date between date_sub(now(),INTERVAL 1 WEEK) and now() and CONCAT(tbl_transaction_history.id_number,' ', tbl_employee_stat.employee_name, ' ', tbl_transaction_history.amount,' ', tbl_transaction_history.date ) LIKE('%" + TB_Id_Number.Text + "%')", conn);
                dt = new DataTable();
                da.Fill(dt);
                DGV_Transaction_History.DataSource = dt;
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        public void showname()
        {

        }

        private void LB_Transaction_Click(object sender, EventArgs e)
        {

        }

        private void Tb_Amount_Enter(object sender, EventArgs e)
        {
            if (Tb_Amount.Text.Trim() != "" || Tb_Amount.Text != null)

            {

                Tb_Amount.Text = "";

            }
        }

        private void Tb_Amount_Leave(object sender, EventArgs e)
        {
            if (Tb_Amount.Text.Trim() != "" || Tb_Amount.Text != null)

            {

                Tb_Amount.Text = "Amount";

            }
        }

        public void displayEmployee()
        {
            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("select id_number as 'ID NUMBER', employee_name as 'EMPLOYEE NAME'from tbl_employee_stat", conn);
                dt = new DataTable();
                da.Fill(dt);
                DGV_Employees_List.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void displayTransaction()
        {
            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("SELECT tbl_transaction_history.id_number AS 'ID NUMBER', tbl_employee_stat.employee_name AS NAME, tbl_transaction_history.amount AS AMOUNT, tbl_transaction_history.date AS DATE from tbl_transaction_history inner JOIN tbl_employee_stat on tbl_transaction_history.id_connect = tbl_employee_stat.id_number where date between date_sub(now(),INTERVAL 1 WEEK) and now()", conn);
                dt = new DataTable();
                da.Fill(dt);
                DGV_Transaction_History.DataSource = dt;
                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        //{
        //    New_Employee_Form nef = new New_Employee_Form();
        //    nef.Show();
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("select tbl_employee_stat.id_number as 'ID NUMBER', tbl_employee_stat.employee_name as 'EMPLOYEE NAME', tbl_status.status as STATUS from tbl_employee_stat join tbl_status on tbl_employee_stat.status = tbl_status.id WHERE CONCAT(id_number,' ' ,employee_name, ' ' ,id ) LIKE('%" + textBox1.Text + "%')", conn);
                dt = new DataTable();
                da.Fill(dt);
                DGV_Employee.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" || textBox1.Text != null)

            {
                textBox1.Text = "";
            }
        }

        private void tb_Search_OnValueChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("select id_number as ID, employee_name as EMPLOYEE from tbl_employee_stat WHERE CONCAT(id_number,' ' ,employee_name ) LIKE('%" + tb_Search.Text + "%')", conn);
                dt = new DataTable();
                da.Fill(dt);
                DGV_Employees_List.DataSource = dt;
                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_Search_Enter(object sender, EventArgs e)
        {
                if (tb_Search.Text.Trim() != "" || tb_Search.Text != null)

                {

                    tb_Search.Text = "";

                }
        }

        private void tb_Search_Leave(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            TB_Id_Number.Text = "";
            Tb_Amount.Text = "Amount";
        }

        public void buttonOnDgvHistory()
        {
            

            //foreach (DataGridViewRow dgv in DGV_Employees_List.Rows )
            //{
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "VIEW HISTORY";
                btn.Name = "View_History";
                btn.Text = "View History";
                btn.UseColumnTextForButtonValue = true;
            //DGV_Employee.Columns.Add(btn);
            int columnindex = 3;
            if (DGV_Employee.Columns["View_History"] == null)
            {
                DGV_Employee.Columns.Insert(columnindex, btn);
            }
            //}
        }

        public void buttonOnDgvEdit()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "EDIT EMPLOYEE";
            btn.Name = "Edit_Employee";
            btn.Text = "Edit";
            btn.UseColumnTextForButtonValue = true;
            //DGV_Employee.Columns.Add(btn);
            //int columnindex = 3;
            int columnindex = 3;
            if (DGV_Employee.Columns["Edit_Employee"] == null)
            {
                DGV_Employee.Columns.Insert(columnindex, btn);
            }


        }

        private void Canteen_Load(object sender, EventArgs e)
        {
           // RowColor();
            //Refreshwindow();
            label2.Text = DateTime.Now.ToShortDateString();
            showcbStatus(cbStatus);
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            addOwe();
            Refreshwindow();
            //test();
        }

        public void addOwe()
        {
            try
            {
                conn = new MySqlConnection(strConn);

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd");
                //Date date = new Date();4
                //label2.Text = Convert.ToDateTime(ToString("yyyy-MM-dd"));
                //MessageBox.Show(id);
                String nall = "null";
                cmd.CommandText = "insert into tbl_transaction_history values(" + nall + "," + this.TB_Id_Number.Text + "," + this.Tb_Amount.Text + ", now(),"+TB_Id_Number.Text.Split(' ')[0] + ");";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully Added!");
                clear();
                Refreshwindow();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void Employee_name()
        {
            string name = null;
            string sql = "Select employee_name from tbl_employee_stat where id_number LIKE %"+TB_Id_Number.Text+"%;";
            
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                using (MySqlCommand command = new MySqlCommand(sql,conn ))
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        name = reader[0] as string;
                        //department = reader[1] as string;
                        //lb_name.Text = name;
                        //break for single row or you can continue if you have multiple rows...
                        break;
                    }
                }
                conn.Close();
            }
        }

        //public void nameLoader()
        //{
        //    MySqlDataAdapter da;
        //    DataTable dt;
        //    try
        //    {
        //        conn = new MySqlConnection(strConn);
        //        conn.Open();
        //        da = new MySqlDataAdapter("select employee_name from tbl_employee_stat WHERE id_number = LIKE('%" + TB_Id_Number.Text + "%')", conn);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        DGV_For_Name_Only.DataSource = dt;
        //        //DGV_Employees_List.DataSource = dt;
        //        conn.Close();
                

                
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}



        public void datagrid()
        {
            //DataGridViewRow row = DGV_For_Id_Only.Rows[0];
            //lb_id.Text = row.Cells[0].Value.ToString();
        }
        
        

        public void test()
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MessageBox.Show(date);
        }

        private void DGV_Employees_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Update_employee ue = new Update_employee();
            int rowid = e.RowIndex;
            DataGridViewRow row = DGV_Employee.Rows[rowid];
            ue.tb_id.Text = row.Cells[0].Value.ToString();
            ue.tb_Id_Number.Text = row.Cells[0].Value.ToString();
            ue.tb_Name.Text = row.Cells[1].Value.ToString();
            ue.Show();
            //if (e.ColumnIndex == DGV_Employee.Columns["Edit_Employee"].Index)
            //{
            //    Update_employee ue = new Update_employee();
            //    int rowid = e.RowIndex;
            //    DataGridViewRow row = DGV_Employee.Rows[rowid];
            //    ue.tb_Id_Number.Text = row.Cells[2].Value.ToString();
            //    ue.tb_Name.Text = row.Cells[3].Value.ToString();
            //    ue.Show();
            //} else if (e.ColumnIndex == DGV_Employee.Columns["View_History"].Index)
            //{
            //    History h = new History();
            //    int rowid = e.RowIndex;
            //    DataGridViewRow row = DGV_Employee.Rows[rowid];
            //    string idnumber = row.Cells[2].Value.ToString();
            //    //----------------------------------------------

            //    MySqlDataAdapter da;
            //    DataTable dt;
            //    try
            //    {
            //        conn = new MySqlConnection(strConn);
            //        conn.Open();
            //        da = new MySqlDataAdapter("Select id_number as 'ID NUMBER', amount as AMOUNT, date as DATE from tbl_transaction_history where id_number = " + idnumber + ";", conn);
            //        dt = new DataTable();
            //        da.Fill(dt);
            //        h.DGV_View_History.DataSource = dt;
            //        conn.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    //----------------------------------------------



            //    h.Show();
            //}

        }

        private void btn_add_employee_Click_1(object sender, EventArgs e)
        {
            New_Employee_Form nef = new New_Employee_Form();
            nef.Show();
            
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Workbook|*.xlsx";
            //MessageBox.Show(Date_From.Text);
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 20;
                for (int i = 1; i < DGV_Employee.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = DGV_Employee.Columns[i - 1].HeaderText;
                }

                //Store here
                for (int j = 0; j < DGV_Employee.Rows.Count; j++)
                {
                    for (int i = 0; i < DGV_Employee.Columns.Count; i++)
                    {
                        ExcelApp.Cells[j + 2, i + 1] = DGV_Employee.Rows[j].Cells[i].Value.ToString();
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }

        private void DGV_Transaction_History_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void showcbStatus(ComboBox cbStatus)
        {

            conn = new MySqlConnection(strConn);

            string Query = "select * from tbl_payment_status";

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

        public void pay()
        {
            date_from_owe.Value = DateTime.Today;
            date_to_owe.Value = DateTime.Today;
            try
            {
                conn = new MySqlConnection(strConn);

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string nall = "null";
                //MessageBox.Show(id);
                cmd.CommandText = "insert into tbl_payment values("+ nall +"," + this.tB_IdNumber.Text + ","+ this.tb_amount_pay .Text + ",'" + this.date_from_owe.Text + "','"+ this.date_to_owe.Text + "',now(),"+ cbStatus.Text.Split(' ')[0] + ","+ this.tB_IdNumber.Text + ");";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Added Successfully!");
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (cbStatus.Text == "" || tB_IdNumber.Text == "" || tb_amount_pay.Text == "")
            {
                MessageBox.Show("Please Fill All information");
            }else if(cbStatus.Text != "" || tB_IdNumber.Text != "" || tb_amount_pay.Text != "")
            {
                pay();
            }
             
            //MessageBox.Show(date_from_owe.Text);
        }

        private void tB_IdNumber_OnValueChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                //Original -> ("SELECT id_number AS 'ID NUMBER' ,employee_name AS NAME, (SELECT sum(amount) FROM tbl_transaction_history WHERE id_number = "+ tB_IdNumber.Text + " ) - (SELECT sum(amount) from tbl_payment WHERE id_number = "+ tB_IdNumber.Text + " ) as BALANCE from tbl_employee_stat WHERE CONCAT(id_number,' ',employee_name,' ',(SELECT sum(amount) FROM tbl_transaction_history WHERE id_number = " + tB_IdNumber.Text + " ) - (SELECT sum(amount) from tbl_payment WHERE id_number = " + tB_IdNumber.Text + " )) LIKE('%" + tB_IdNumber.Text + "%')", conn);
                //SELECT id_number AS 'ID NUMBER' ,employee_name AS NAME, (SELECT sum(amount) FROM tbl_transaction_history WHERE id_number = 450866 AND date between date_sub(now(),INTERVAL 1 WEEK) and now() ) - (SELECT sum(amount) from tbl_payment WHERE id_number = 450866 ) as SUM from tbl_employee_stat WHERE id_number = 450866
                da = new MySqlDataAdapter("SELECT id_number AS 'ID NUMBER' ,employee_name AS NAME, (SELECT sum(amount) FROM tbl_transaction_history WHERE id_number = "+ tB_IdNumber.Text + " AND date >= '"+ this.date_from_owe.Text + "' AND date <= '"+ this.date_to_owe.Text + "') - (SELECT sum(amount) from tbl_payment WHERE id_number = " + tB_IdNumber.Text + " ) as BALANCE from tbl_employee_stat WHERE CONCAT(id_number,' ',employee_name,' ',(SELECT sum(amount) FROM tbl_transaction_history WHERE id_number = " + tB_IdNumber.Text + " ) - (SELECT sum(amount) from tbl_payment WHERE id_number = " + tB_IdNumber.Text + " )) LIKE('%" + tB_IdNumber.Text + "%')", conn);
                dt = new DataTable();
                da.Fill(dt);
                Dgv_Payment.DataSource = dt;
                
                
                RowColor();
                conn.Close();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        public void get()
        {
            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("SELECT sum(amount) from tbl_payment where id_number = 450866", conn);
                dt = new DataTable();
                da.Fill(dt);
                //DGV_get.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // REMOVE FROM PAYMENT!!
        public void displayallpayment()
        {
            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("SELECT tbl_payment.id_number AS 'ID NUMBER', tbl_employee_stat.employee_name AS 'NAME', tbl_payment.amount AS 'AMOUNT PAID', tbl_payment.date_pay as 'DATE PAID', tbl_payment_status.status AS 'STATUS' FROM ((tbl_payment inner JOIN tbl_payment_status ON tbl_payment.status = tbl_payment_status.id) inner JOIN tbl_employee_stat ON tbl_payment.id_connect = tbl_employee_stat.id_number);", conn);
                dt = new DataTable();
                da.Fill(dt);
                DGV_Employees_List.DataSource = dt;
                //DGV_Payment_History.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void splitContainer5_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        public void RowColor()
        {
            
            
            try
            {
                for (int i = 0; i < Dgv_Payment.Rows.Count; i++)
                {
                    
                    int val = Int32.Parse(Dgv_Payment.Rows[i].Cells[2].Value.ToString());
                    if (val == 1000)
                    {
                        Dgv_Payment.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        //Panel_Alert.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message.ToString());
            }
        }

        private void Canteen_Activated(object sender, EventArgs e)
        {
            
        }

        public void DisplayActiveEmployee()
        {
            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("SELECT COUNT(status) as TOTAL from tbl_employee_stat where status = 1;", conn);
                dt = new DataTable();
                da.Fill(dt);
                Dgv_Active.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayInActiveEmployee()
        {
            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("SELECT COUNT(status) As TOTAL from tbl_employee_stat where status = 2; ", conn);
                dt = new DataTable();
                da.Fill(dt);
                Dgv_InActive.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayTotalOweOfTheWeek()
        {
            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("SELECT SUM(amount) AS 'TOTAL OWE FOR THE WEEK' from tbl_transaction_history WHERE date between date_sub(now(),INTERVAL 1 WEEK) and now(); ", conn);
                dt = new DataTable();
                da.Fill(dt);
                Dgv_totalOwe.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TB_Id_Number_Enter(object sender, EventArgs e)
        {
            if (TB_Id_Number.Text.Trim() != "" || TB_Id_Number.Text != null)

            {

                TB_Id_Number.Text = "";

            }
        }

        private void tB_IdNumber_Enter(object sender, EventArgs e)
        {
            if (tB_IdNumber.Text.Trim() != "" || tB_IdNumber.Text != null)

            {

                tB_IdNumber.Text = "";

            }
        }

        private void tB_IdNumber_Leave(object sender, EventArgs e)
        {
            if (tB_IdNumber.Text.Trim() != "" || tB_IdNumber.Text != null)

            {

                tB_IdNumber.Text = "ID Number";

            }
        }

        private void tb_amount_pay_Enter(object sender, EventArgs e)
        {
            if (tb_amount_pay.Text.Trim() != "" || tb_amount_pay.Text != null)

            {

                tb_amount_pay.Text = "";

            }
        }

        private void tb_amount_pay_Leave(object sender, EventArgs e)
        {
            if (tb_amount_pay.Text.Trim() != "" || tb_amount_pay.Text != null)

            {

                tb_amount_pay.Text = "Amount";

            }
        }

        private void tB_IdNumber_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void tB_IdNumber_Enter_1(object sender, EventArgs e)
        {
            if (tB_IdNumber.Text.Trim() != "" || tB_IdNumber.Text != null)

            {

                tB_IdNumber.Text = "";

            }
        }

        public void DisplayPayment()
        {
            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                //Original -> ("SELECT id_number AS 'ID NUMBER' ,employee_name AS NAME, (SELECT sum(amount) FROM tbl_transaction_history WHERE id_number = "+ tB_IdNumber.Text + " ) - (SELECT sum(amount) from tbl_payment WHERE id_number = "+ tB_IdNumber.Text + " ) as BALANCE from tbl_employee_stat WHERE CONCAT(id_number,' ',employee_name,' ',(SELECT sum(amount) FROM tbl_transaction_history WHERE id_number = " + tB_IdNumber.Text + " ) - (SELECT sum(amount) from tbl_payment WHERE id_number = " + tB_IdNumber.Text + " )) LIKE('%" + tB_IdNumber.Text + "%')", conn);
                //SELECT id_number AS 'ID NUMBER' ,employee_name AS NAME, (SELECT sum(amount) FROM tbl_transaction_history WHERE id_number = 450866 AND date between date_sub(now(),INTERVAL 1 WEEK) and now() ) - (SELECT sum(amount) from tbl_payment WHERE id_number = 450866 ) as SUM from tbl_employee_stat WHERE id_number = 450866
                da = new MySqlDataAdapter("SELECT id_number AS 'ID NUMBER' ,employee_name AS NAME, (SELECT sum(amount) FROM tbl_transaction_history WHERE id_number = " + tB_IdNumber.Text + " AND date between date_sub(now(),INTERVAL 1 WEEK) and now()) - (SELECT sum(amount) from tbl_payment WHERE id_number = " + tB_IdNumber.Text + " ) as BALANCE from tbl_employee_stat WHERE CONCAT(id_number,' ',employee_name,' ',(SELECT sum(amount) FROM tbl_transaction_history WHERE id_number = " + tB_IdNumber.Text + " ) - (SELECT sum(amount) from tbl_payment WHERE id_number = " + tB_IdNumber.Text + " )) LIKE('%" + tB_IdNumber.Text + "%')", conn);
                dt = new DataTable();
                da.Fill(dt);
                Dgv_Payment.DataSource = dt;

                clear();
                RowColor();
                conn.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            Add_New_Account anc = new Add_New_Account();
            anc.Show();
        }

        private void DGV_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_log_Click_1(object sender, EventArgs e)
        {
            log();
        }

        public void log()
        {
            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                Login_History lh = new Login_History();
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("SELECT tbl_user.user_id, tbl_user.name, tbl_logs.log_date, tbl_account.account_title from((tbl_user inner join tbl_logs on tbl_user.user_id = tbl_logs.user_id) inner JOIN tbl_account ON tbl_account.account_id = tbl_user.account_id)", conn);
                dt = new DataTable();
                da.Fill(dt);
                lh.Dgv_Log_History.DataSource = dt;
                lh.Show();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void showOwe()
        {
            MySqlDataAdapter da;
            DataTable dt;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                da = new MySqlDataAdapter("SELECT tbl_transaction_history.id_number, tbl_employee_stat.employee_name AS 'EMPLOYEE NAME', sum(tbl_transaction_history.amount) AS 'AMOUNT', tbl_transaction_history.date as DATE, (select date from tbl_transaction_history where date = '"+ Date_To.Text + "') as 'DATE TO' FROM tbl_transaction_history inner join tbl_employee_stat on tbl_transaction_history.id_connect = tbl_employee_stat.id_number WHERE date >='"+ Date_From.Text+ "' and date <= '"+Date_To.Text+"' GROUP BY id_number ", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgv_Report.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Date_From_ValueChanged(object sender, EventArgs e)
        {
            showOwe();
        }

        private void Date_To_ValueChanged(object sender, EventArgs e)
        {
            showOwe();
        }
    }
}
