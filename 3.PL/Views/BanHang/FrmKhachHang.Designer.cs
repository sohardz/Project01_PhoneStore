namespace _3.PL.Views.BanHang
{
    partial class FrmKhachHang
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
            this.cmb_thanhpho = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.dgrid_khachhang = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dtpicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_tendem = new System.Windows.Forms.TextBox();
            this.txt_ho = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_thanhpho
            // 
            this.cmb_thanhpho.FormattingEnabled = true;
            this.cmb_thanhpho.Location = new System.Drawing.Point(450, 95);
            this.cmb_thanhpho.Name = "cmb_thanhpho";
            this.cmb_thanhpho.Size = new System.Drawing.Size(220, 23);
            this.cmb_thanhpho.TabIndex = 155;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 153;
            this.label6.Text = "Thành phố";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 152;
            this.label1.Text = "Địa chỉ";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(350, 175);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(332, 23);
            this.txt_timkiem.TabIndex = 151;
            this.txt_timkiem.Text = "Tìm Kiếm ...";
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            this.txt_timkiem.Leave += new System.EventHandler(this.txt_timkiem_Leave);
            // 
            // dgrid_khachhang
            // 
            this.dgrid_khachhang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgrid_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_khachhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_khachhang.Location = new System.Drawing.Point(0, 347);
            this.dgrid_khachhang.Name = "dgrid_khachhang";
            this.dgrid_khachhang.RowTemplate.Height = 25;
            this.dgrid_khachhang.Size = new System.Drawing.Size(1350, 483);
            this.dgrid_khachhang.TabIndex = 150;
            this.dgrid_khachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_khachhang_CellClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(750, 165);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(125, 45);
            this.btn_clear.TabIndex = 149;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(750, 90);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(125, 45);
            this.btn_sua.TabIndex = 147;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(750, 15);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(125, 45);
            this.btn_them.TabIndex = 146;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dtpicker_ngaysinh
            // 
            this.dtpicker_ngaysinh.Location = new System.Drawing.Point(85, 175);
            this.dtpicker_ngaysinh.Name = "dtpicker_ngaysinh";
            this.dtpicker_ngaysinh.Size = new System.Drawing.Size(220, 23);
            this.dtpicker_ngaysinh.TabIndex = 145;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(450, 55);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(220, 23);
            this.txt_diachi.TabIndex = 143;
            this.txt_diachi.Leave += new System.EventHandler(this.txt_diachi_Leave);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(450, 15);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(220, 23);
            this.txt_sdt.TabIndex = 142;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(85, 135);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(220, 23);
            this.txt_ten.TabIndex = 141;
            this.txt_ten.Leave += new System.EventHandler(this.txt_ten_Leave);
            // 
            // txt_tendem
            // 
            this.txt_tendem.Location = new System.Drawing.Point(85, 95);
            this.txt_tendem.Name = "txt_tendem";
            this.txt_tendem.Size = new System.Drawing.Size(220, 23);
            this.txt_tendem.TabIndex = 140;
            this.txt_tendem.Leave += new System.EventHandler(this.txt_tendem_Leave);
            // 
            // txt_ho
            // 
            this.txt_ho.Location = new System.Drawing.Point(85, 55);
            this.txt_ho.Name = "txt_ho";
            this.txt_ho.Size = new System.Drawing.Size(220, 23);
            this.txt_ho.TabIndex = 139;
            this.txt_ho.Leave += new System.EventHandler(this.txt_ho_Leave);
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(85, 15);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(220, 23);
            this.txt_ma.TabIndex = 138;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 136;
            this.label9.Text = "Ngày Sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 134;
            this.label7.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 133;
            this.label5.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 132;
            this.label4.Text = "Tên Đệm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 131;
            this.label3.Text = "Họ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 130;
            this.label2.Text = "Mã";
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1350, 830);
            this.Controls.Add(this.cmb_thanhpho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.dgrid_khachhang);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtpicker_ngaysinh);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_tendem);
            this.Controls.Add(this.txt_ho);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKhachHangService";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_khachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_thanhpho;
        private Label label6;
        private Label label1;
        private TextBox txt_timkiem;
        private DataGridView dgrid_khachhang;
        private Button btn_clear;
        private Button btn_sua;
        private Button btn_them;
        private DateTimePicker dtpicker_ngaysinh;
        private TextBox txt_diachi;
        private TextBox txt_sdt;
        private TextBox txt_ten;
        private TextBox txt_tendem;
        private TextBox txt_ho;
        private TextBox txt_ma;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}