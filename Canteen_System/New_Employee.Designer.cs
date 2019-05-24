namespace Canteen_System
{
    partial class New_Employee_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Employee_Form));
            this.txt_ID_NUMBER = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_NAME = new ns1.BunifuMaterialTextbox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ID_NUMBER
            // 
            this.txt_ID_NUMBER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ID_NUMBER.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ID_NUMBER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ID_NUMBER.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ID_NUMBER.HintText = "";
            this.txt_ID_NUMBER.isPassword = false;
            this.txt_ID_NUMBER.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txt_ID_NUMBER.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_ID_NUMBER.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txt_ID_NUMBER.LineThickness = 3;
            this.txt_ID_NUMBER.Location = new System.Drawing.Point(13, 163);
            this.txt_ID_NUMBER.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID_NUMBER.Name = "txt_ID_NUMBER";
            this.txt_ID_NUMBER.Size = new System.Drawing.Size(255, 44);
            this.txt_ID_NUMBER.TabIndex = 0;
            this.txt_ID_NUMBER.Text = "ID NUMBER";
            this.txt_ID_NUMBER.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ID_NUMBER.Enter += new System.EventHandler(this.txt_ID_NUMBER_Enter);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(110, 53);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(150, 27);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Add Employee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txt_NAME
            // 
            this.txt_NAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NAME.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NAME.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NAME.HintText = "";
            this.txt_NAME.isPassword = false;
            this.txt_NAME.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txt_NAME.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NAME.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txt_NAME.LineThickness = 3;
            this.txt_NAME.Location = new System.Drawing.Point(13, 234);
            this.txt_NAME.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NAME.Name = "txt_NAME";
            this.txt_NAME.Size = new System.Drawing.Size(255, 44);
            this.txt_NAME.TabIndex = 3;
            this.txt_NAME.Text = "NAME";
            this.txt_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_NAME.Enter += new System.EventHandler(this.txt_NAME_Enter);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(13, 138);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(255, 21);
            this.cbStatus.TabIndex = 6;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
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
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click_1);
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
            this.btn_Ok.TabIndex = 12;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // New_Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 378);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txt_NAME);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_ID_NUMBER);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Employee_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.New_Employee_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuMaterialTextbox txt_ID_NUMBER;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuMaterialTextbox txt_NAME;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
    }
}