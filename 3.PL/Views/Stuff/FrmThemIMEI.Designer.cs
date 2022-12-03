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
            this.dgrid_imei.Size = new System.Drawing.Size(610, 237);
            this.dgrid_imei.TabIndex = 0;
            // 
            // FrmThemIMEI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.dgrid_imei);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Name = "FrmThemIMEI";
            this.Text = "FrmThemIMEI";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_imei)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgrid_imei;
    }
}