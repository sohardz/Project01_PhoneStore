namespace _3.PL.Views.Stuff
{
    partial class FrmThemIMEI
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
            this.dgrid_imei = new System.Windows.Forms.DataGridView();
            this.btn_sendIMEI = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_imei)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_imei
            // 
            this.dgrid_imei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_imei.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgrid_imei.Location = new System.Drawing.Point(12, 12);
            this.dgrid_imei.Name = "dgrid_imei";
            this.dgrid_imei.RowTemplate.Height = 25;
            this.dgrid_imei.Size = new System.Drawing.Size(538, 237);
            this.dgrid_imei.TabIndex = 0;
            this.dgrid_imei.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_imei_CellClick);
            // 
            // btn_sendIMEI
            // 
            this.btn_sendIMEI.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sendIMEI.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sendIMEI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sendIMEI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sendIMEI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sendIMEI.ForeColor = System.Drawing.Color.White;
            this.btn_sendIMEI.Location = new System.Drawing.Point(556, 12);
            this.btn_sendIMEI.Name = "btn_sendIMEI";
            this.btn_sendIMEI.Size = new System.Drawing.Size(66, 45);
            this.btn_sendIMEI.TabIndex = 1;
            this.btn_sendIMEI.Text = "Gửi IMEI";
            this.btn_sendIMEI.Click += new System.EventHandler(this.btn_sendIMEI_Click);
            // 
            // FrmThemIMEI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.btn_sendIMEI);
            this.Controls.Add(this.dgrid_imei);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Name = "FrmThemIMEI";
            this.Text = "FrmThemIMEI";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_imei)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgrid_imei;
        private Guna.UI2.WinForms.Guna2Button btn_sendIMEI;
    }
}