namespace Canteen_System
{
    partial class Update_employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Id_Number = new ns1.BunifuMaterialTextbox();
            this.tb_Name = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_View_History = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Id_Number
            // 
            this.tb_Id_Number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Id_Number.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_Id_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Id_Number.HintForeColor = System.Drawing.Color.Empty;
            this.tb_Id_Number.HintText = "ID NUMBER";
            this.tb_Id_Number.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Id_Number.isPassword = false;
            this.tb_Id_Number.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.tb_Id_Number.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_Id_Number.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.tb_Id_Number.LineThickness = 3;
            this.tb_Id_Number.Location = new System.Drawing.Point(13, 163);
            this.tb_Id_Number.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Id_Number.Name = "tb_Id_Number";
            this.tb_Id_Number.Size = new System.Drawing.Size(255, 44);
            this.tb_Id_Number.TabIndex = 0;
            this.tb_Id_Number.Text = "ENTER ID NUMBER";
            this.tb_Id_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_Name
            // 
            this.tb_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Name.HintForeColor = System.Drawing.Color.Empty;
            this.tb_Name.HintText = "";
            this.tb_Name.isPassword = false;
            this.tb_Name.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.tb_Name.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_Name.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.tb_Name.LineThickness = 3;
            this.tb_Name.Location = new System.Drawing.Point(13, 220);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(258, 44);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.Text = "ENTER NAME";
            this.tb_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 64);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(182, 27);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Update Employee";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(13, 138);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(255, 21);
            this.cbStatus.TabIndex = 8;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(161, 294);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(107, 62);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.ForeColor = System.Drawing.Color.White;
            this.btn_Ok.Location = new System.Drawing.Point(24, 294);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(107, 62);
            this.btn_Ok.TabIndex = 10;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click_1);
            // 
            // btn_View_History
            // 
            this.btn_View_History.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_View_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_History.ForeColor = System.Drawing.Color.White;
            this.btn_View_History.Location = new System.Drawing.Point(48, 362);
            this.btn_View_History.Name = "btn_View_History";
            this.btn_View_History.Size = new System.Drawing.Size(177, 62);
            this.btn_View_History.TabIndex = 11;
            this.btn_View_History.Text = "View History";
            this.btn_View_History.UseVisualStyleBackColor = false;
            this.btn_View_History.Click += new System.EventHandler(this.btn_View_History_Click);
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(172, 116);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 13;
            this.tb_id.Visible = false;
            // 
            // Update_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 431);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_View_History);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Id_Number);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update_employee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPDATE EMPLOYEE";
            this.Load += new System.EventHandler(this.Update_employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        public ns1.BunifuMaterialTextbox tb_Id_Number;
        public ns1.BunifuMaterialTextbox tb_Name;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_View_History;
        public System.Windows.Forms.TextBox tb_id;
    }
}