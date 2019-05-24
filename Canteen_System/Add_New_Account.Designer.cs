namespace Canteen_System
{
    partial class Add_New_Account
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
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cbStype = new System.Windows.Forms.ComboBox();
            this.tb_LastName = new ns1.BunifuMaterialTextbox();
            this.tb_Name = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.tb_Address = new ns1.BunifuMaterialTextbox();
            this.tb_ContactNumber = new ns1.BunifuMaterialTextbox();
            this.tb_Username = new ns1.BunifuMaterialTextbox();
            this.tb_Password = new ns1.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.ForeColor = System.Drawing.Color.White;
            this.btn_Ok.Location = new System.Drawing.Point(6, 481);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(107, 62);
            this.btn_Ok.TabIndex = 17;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(143, 481);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(107, 62);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // cbStype
            // 
            this.cbStype.FormattingEnabled = true;
            this.cbStype.Location = new System.Drawing.Point(4, 129);
            this.cbStype.Name = "cbStype";
            this.cbStype.Size = new System.Drawing.Size(255, 21);
            this.cbStype.TabIndex = 15;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_LastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_LastName.HintForeColor = System.Drawing.Color.Empty;
            this.tb_LastName.HintText = "";
            this.tb_LastName.isPassword = false;
            this.tb_LastName.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.tb_LastName.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_LastName.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.tb_LastName.LineThickness = 3;
            this.tb_LastName.Location = new System.Drawing.Point(4, 206);
            this.tb_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(255, 44);
            this.tb_LastName.TabIndex = 14;
            this.tb_LastName.Text = "LAST NAME";
            this.tb_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_LastName.Enter += new System.EventHandler(this.tb_LastName_Enter);
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
            this.tb_Name.Location = new System.Drawing.Point(4, 154);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(255, 44);
            this.tb_Name.TabIndex = 13;
            this.tb_Name.Text = "NAME";
            this.tb_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Name.Enter += new System.EventHandler(this.tb_Name_Enter);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(38, 50);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(181, 27);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "Add New Account";
            // 
            // tb_Address
            // 
            this.tb_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Address.HintForeColor = System.Drawing.Color.Empty;
            this.tb_Address.HintText = "";
            this.tb_Address.isPassword = false;
            this.tb_Address.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.tb_Address.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_Address.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.tb_Address.LineThickness = 3;
            this.tb_Address.Location = new System.Drawing.Point(4, 258);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(255, 44);
            this.tb_Address.TabIndex = 19;
            this.tb_Address.Text = "ADDRESS";
            this.tb_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Address.Enter += new System.EventHandler(this.tb_Address_Enter);
            // 
            // tb_ContactNumber
            // 
            this.tb_ContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ContactNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_ContactNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ContactNumber.HintForeColor = System.Drawing.Color.Empty;
            this.tb_ContactNumber.HintText = "";
            this.tb_ContactNumber.isPassword = false;
            this.tb_ContactNumber.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.tb_ContactNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_ContactNumber.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.tb_ContactNumber.LineThickness = 3;
            this.tb_ContactNumber.Location = new System.Drawing.Point(4, 310);
            this.tb_ContactNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ContactNumber.Name = "tb_ContactNumber";
            this.tb_ContactNumber.Size = new System.Drawing.Size(255, 44);
            this.tb_ContactNumber.TabIndex = 20;
            this.tb_ContactNumber.Text = "CONTACT NUMBER";
            this.tb_ContactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ContactNumber.Enter += new System.EventHandler(this.tb_ContactNumber_Enter);
            this.tb_ContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ContactNumber_KeyPress);
            // 
            // tb_Username
            // 
            this.tb_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Username.HintForeColor = System.Drawing.Color.Empty;
            this.tb_Username.HintText = "";
            this.tb_Username.isPassword = false;
            this.tb_Username.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.tb_Username.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_Username.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.tb_Username.LineThickness = 3;
            this.tb_Username.Location = new System.Drawing.Point(4, 362);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(255, 44);
            this.tb_Username.TabIndex = 21;
            this.tb_Username.Text = "USERNAME";
            this.tb_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Username.Enter += new System.EventHandler(this.tb_Username_Enter);
            // 
            // tb_Password
            // 
            this.tb_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Password.HintForeColor = System.Drawing.Color.Empty;
            this.tb_Password.HintText = "";
            this.tb_Password.isPassword = false;
            this.tb_Password.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.tb_Password.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_Password.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.tb_Password.LineThickness = 3;
            this.tb_Password.Location = new System.Drawing.Point(6, 414);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(255, 44);
            this.tb_Password.TabIndex = 22;
            this.tb_Password.Text = "PASSWORD";
            this.tb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Password.Enter += new System.EventHandler(this.tb_Password_Enter);
            // 
            // Add_New_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(262, 566);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.tb_ContactNumber);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.cbStype);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.tb_Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_New_Account";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Account";
            this.Load += new System.EventHandler(this.Add_New_Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private ns1.BunifuMaterialTextbox tb_LastName;
        private ns1.BunifuMaterialTextbox tb_Name;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        public System.Windows.Forms.ComboBox cbStype;
        private ns1.BunifuMaterialTextbox tb_Address;
        private ns1.BunifuMaterialTextbox tb_ContactNumber;
        private ns1.BunifuMaterialTextbox tb_Username;
        private ns1.BunifuMaterialTextbox tb_Password;
    }
}