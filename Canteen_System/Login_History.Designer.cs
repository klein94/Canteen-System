namespace Canteen_System
{
    partial class Login_History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_Log_History = new ns1.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Log_History)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Log_History
            // 
            this.Dgv_Log_History.AllowUserToDeleteRows = false;
            this.Dgv_Log_History.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv_Log_History.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Log_History.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Log_History.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Dgv_Log_History.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Log_History.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgv_Log_History.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Log_History.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Log_History.ColumnHeadersHeight = 42;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Log_History.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Log_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Log_History.DoubleBuffered = true;
            this.Dgv_Log_History.EnableHeadersVisualStyles = false;
            this.Dgv_Log_History.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.Dgv_Log_History.HeaderForeColor = System.Drawing.Color.White;
            this.Dgv_Log_History.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Log_History.Name = "Dgv_Log_History";
            this.Dgv_Log_History.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Log_History.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Log_History.RowHeadersVisible = false;
            this.Dgv_Log_History.Size = new System.Drawing.Size(674, 598);
            this.Dgv_Log_History.TabIndex = 2;
            // 
            // Login_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 598);
            this.Controls.Add(this.Dgv_Log_History);
            this.Name = "Login_History";
            this.Text = "Login_History";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Log_History)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public ns1.BunifuCustomDataGrid Dgv_Log_History;
    }
}