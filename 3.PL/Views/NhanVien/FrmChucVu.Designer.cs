﻿namespace _3.PL.Views.NhanVien
{
    partial class FrmChucVu
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
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgrid_chucvu = new System.Windows.Forms.DataGridView();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtn_hoatdong = new System.Windows.Forms.RadioButton();
            this.rbtn_khonghoatdong = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_chucvu)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(350, 55);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(220, 23);
            this.txt_timkiem.TabIndex = 51;
            this.txt_timkiem.Text = "Tìm Kiếm ...";
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            this.txt_timkiem.Leave += new System.EventHandler(this.txt_timkiem_Leave);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(650, 15);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 50;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(550, 15);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 49;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(450, 15);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 48;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(350, 15);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 47;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgrid_chucvu
            // 
            this.dgrid_chucvu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgrid_chucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_chucvu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_chucvu.Location = new System.Drawing.Point(0, 136);
            this.dgrid_chucvu.Name = "dgrid_chucvu";
            this.dgrid_chucvu.RowTemplate.Height = 25;
            this.dgrid_chucvu.Size = new System.Drawing.Size(744, 325);
            this.dgrid_chucvu.TabIndex = 46;
            this.dgrid_chucvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_chucvu_CellClick);
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(100, 55);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(220, 23);
            this.txt_ten.TabIndex = 45;
            this.txt_ten.Leave += new System.EventHandler(this.txt_ten_Leave);
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(100, 15);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(220, 23);
            this.txt_ma.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Trạng Thái";
            // 
            // rbtn_hoatdong
            // 
            this.rbtn_hoatdong.AutoSize = true;
            this.rbtn_hoatdong.Location = new System.Drawing.Point(100, 95);
            this.rbtn_hoatdong.Name = "rbtn_hoatdong";
            this.rbtn_hoatdong.Size = new System.Drawing.Size(82, 19);
            this.rbtn_hoatdong.TabIndex = 56;
            this.rbtn_hoatdong.TabStop = true;
            this.rbtn_hoatdong.Text = "Hoạt động";
            this.rbtn_hoatdong.UseVisualStyleBackColor = true;
            // 
            // rbtn_khonghoatdong
            // 
            this.rbtn_khonghoatdong.AutoSize = true;
            this.rbtn_khonghoatdong.Location = new System.Drawing.Point(200, 95);
            this.rbtn_khonghoatdong.Name = "rbtn_khonghoatdong";
            this.rbtn_khonghoatdong.Size = new System.Drawing.Size(118, 19);
            this.rbtn_khonghoatdong.TabIndex = 57;
            this.rbtn_khonghoatdong.TabStop = true;
            this.rbtn_khonghoatdong.Text = "Không hoạt động";
            this.rbtn_khonghoatdong.UseVisualStyleBackColor = true;
            // 
            // FrmChucVuService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.rbtn_khonghoatdong);
            this.Controls.Add(this.rbtn_hoatdong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgrid_chucvu);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Name = "FrmChucVuService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChucVuService";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_chucvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_timkiem;
        private Button btn_clear;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private DataGridView dgrid_chucvu;
        private TextBox txt_ten;
        private TextBox txt_ma;
        private Label label2;
        private Label label1;
        private Label label3;
        private RadioButton rbtn_hoatdong;
        private RadioButton rbtn_khonghoatdong;
    }
}