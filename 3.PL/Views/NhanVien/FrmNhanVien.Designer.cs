namespace _3.PL.Views.NhanVien
{
    partial class FrmNhanVien
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
            this.btn_chucvuService = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.dgrid_nhanvien = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.cmb_locChucvu = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_chucvu = new System.Windows.Forms.ComboBox();
            this.dtpicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.rbtn_nu = new System.Windows.Forms.RadioButton();
            this.rbtn_nam = new System.Windows.Forms.RadioButton();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_tendem = new System.Windows.Forms.TextBox();
            this.txt_ho = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_khonghoatdong = new System.Windows.Forms.RadioButton();
            this.rbtn_hoatdong = new System.Windows.Forms.RadioButton();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.picBox_anhNhanvien = new System.Windows.Forms.PictureBox();
            this.btn_chonAnh = new System.Windows.Forms.Button();
            this.lbl_tenAnh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_anhNhanvien)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_chucvuService
            // 
            this.btn_chucvuService.Location = new System.Drawing.Point(1150, 95);
            this.btn_chucvuService.Name = "btn_chucvuService";
            this.btn_chucvuService.Size = new System.Drawing.Size(100, 45);
            this.btn_chucvuService.TabIndex = 138;
            this.btn_chucvuService.Text = "Quản lí chức vụ";
            this.btn_chucvuService.UseVisualStyleBackColor = true;
            this.btn_chucvuService.Click += new System.EventHandler(this.btn_chucvuService_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(1015, 55);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(245, 23);
            this.txt_timkiem.TabIndex = 137;
            this.txt_timkiem.Text = "Tìm Kiếm ...";
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            this.txt_timkiem.Leave += new System.EventHandler(this.txt_timkiem_Leave);
            // 
            // dgrid_nhanvien
            // 
            this.dgrid_nhanvien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgrid_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_nhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_nhanvien.Location = new System.Drawing.Point(0, 308);
            this.dgrid_nhanvien.Name = "dgrid_nhanvien";
            this.dgrid_nhanvien.RowTemplate.Height = 25;
            this.dgrid_nhanvien.Size = new System.Drawing.Size(1300, 417);
            this.dgrid_nhanvien.TabIndex = 136;
            this.dgrid_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_nhanvien_CellClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(1015, 215);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 45);
            this.btn_clear.TabIndex = 135;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(1015, 155);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 45);
            this.btn_sua.TabIndex = 133;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(1015, 95);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 45);
            this.btn_them.TabIndex = 132;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // cmb_locChucvu
            // 
            this.cmb_locChucvu.FormattingEnabled = true;
            this.cmb_locChucvu.Location = new System.Drawing.Point(1015, 15);
            this.cmb_locChucvu.Name = "cmb_locChucvu";
            this.cmb_locChucvu.Size = new System.Drawing.Size(245, 23);
            this.cmb_locChucvu.TabIndex = 131;
            this.cmb_locChucvu.Text = "Lọc Chức Vụ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label14.Location = new System.Drawing.Point(365, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 128;
            this.label14.Text = "Trạng Thái";
            // 
            // cmb_chucvu
            // 
            this.cmb_chucvu.FormattingEnabled = true;
            this.cmb_chucvu.Location = new System.Drawing.Point(455, 95);
            this.cmb_chucvu.Name = "cmb_chucvu";
            this.cmb_chucvu.Size = new System.Drawing.Size(245, 23);
            this.cmb_chucvu.TabIndex = 125;
            // 
            // dtpicker_ngaysinh
            // 
            this.dtpicker_ngaysinh.Location = new System.Drawing.Point(455, 55);
            this.dtpicker_ngaysinh.Name = "dtpicker_ngaysinh";
            this.dtpicker_ngaysinh.Size = new System.Drawing.Size(245, 23);
            this.dtpicker_ngaysinh.TabIndex = 124;
            // 
            // rbtn_nu
            // 
            this.rbtn_nu.AutoSize = true;
            this.rbtn_nu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rbtn_nu.Location = new System.Drawing.Point(75, 2);
            this.rbtn_nu.Name = "rbtn_nu";
            this.rbtn_nu.Size = new System.Drawing.Size(41, 19);
            this.rbtn_nu.TabIndex = 123;
            this.rbtn_nu.TabStop = true;
            this.rbtn_nu.Text = "Nữ";
            this.rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_nam
            // 
            this.rbtn_nam.AutoSize = true;
            this.rbtn_nam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rbtn_nam.Location = new System.Drawing.Point(5, 2);
            this.rbtn_nam.Name = "rbtn_nam";
            this.rbtn_nam.Size = new System.Drawing.Size(51, 19);
            this.rbtn_nam.TabIndex = 122;
            this.rbtn_nam.TabStop = true;
            this.rbtn_nam.Text = "Nam";
            this.rbtn_nam.UseVisualStyleBackColor = true;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(455, 175);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(245, 23);
            this.txt_matkhau.TabIndex = 121;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(455, 15);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(245, 23);
            this.txt_sdt.TabIndex = 120;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(90, 255);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(245, 23);
            this.txt_diachi.TabIndex = 119;
            this.txt_diachi.Leave += new System.EventHandler(this.txt_diachi_Leave);
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(90, 135);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(245, 23);
            this.txt_ten.TabIndex = 118;
            this.txt_ten.Leave += new System.EventHandler(this.txt_ten_Leave);
            // 
            // txt_tendem
            // 
            this.txt_tendem.Location = new System.Drawing.Point(90, 95);
            this.txt_tendem.Name = "txt_tendem";
            this.txt_tendem.Size = new System.Drawing.Size(245, 23);
            this.txt_tendem.TabIndex = 117;
            this.txt_tendem.Leave += new System.EventHandler(this.txt_tendem_Leave);
            // 
            // txt_ho
            // 
            this.txt_ho.Location = new System.Drawing.Point(90, 55);
            this.txt_ho.Name = "txt_ho";
            this.txt_ho.Size = new System.Drawing.Size(245, 23);
            this.txt_ho.TabIndex = 116;
            this.txt_ho.Leave += new System.EventHandler(this.txt_ho_Leave);
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(90, 15);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(245, 23);
            this.txt_ma.TabIndex = 115;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label12.Location = new System.Drawing.Point(365, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 15);
            this.label12.TabIndex = 113;
            this.label12.Text = "Mật Khẩu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label10.Location = new System.Drawing.Point(365, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 111;
            this.label10.Text = "Chức Vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label9.Location = new System.Drawing.Point(365, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 110;
            this.label9.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(365, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 109;
            this.label8.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(15, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 108;
            this.label7.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(15, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 107;
            this.label6.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(15, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 106;
            this.label5.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(15, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 105;
            this.label4.Text = "Tên Đệm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(15, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 104;
            this.label3.Text = "Họ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 103;
            this.label2.Text = "Mã";
            // 
            // txt_cccd
            // 
            this.txt_cccd.Location = new System.Drawing.Point(90, 215);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(245, 23);
            this.txt_cccd.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(15, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 139;
            this.label1.Text = "CCCD";
            // 
            // rbtn_khonghoatdong
            // 
            this.rbtn_khonghoatdong.AutoSize = true;
            this.rbtn_khonghoatdong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rbtn_khonghoatdong.Location = new System.Drawing.Point(100, 2);
            this.rbtn_khonghoatdong.Name = "rbtn_khonghoatdong";
            this.rbtn_khonghoatdong.Size = new System.Drawing.Size(118, 19);
            this.rbtn_khonghoatdong.TabIndex = 142;
            this.rbtn_khonghoatdong.TabStop = true;
            this.rbtn_khonghoatdong.Text = "Không hoạt động";
            this.rbtn_khonghoatdong.UseVisualStyleBackColor = true;
            // 
            // rbtn_hoatdong
            // 
            this.rbtn_hoatdong.AutoSize = true;
            this.rbtn_hoatdong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rbtn_hoatdong.Location = new System.Drawing.Point(5, 2);
            this.rbtn_hoatdong.Name = "rbtn_hoatdong";
            this.rbtn_hoatdong.Size = new System.Drawing.Size(82, 19);
            this.rbtn_hoatdong.TabIndex = 141;
            this.rbtn_hoatdong.TabStop = true;
            this.rbtn_hoatdong.Text = "Hoạt động";
            this.rbtn_hoatdong.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(455, 135);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(245, 23);
            this.txt_email.TabIndex = 144;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label11.Location = new System.Drawing.Point(365, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 15);
            this.label11.TabIndex = 143;
            this.label11.Text = "Email";
            // 
            // picBox_anhNhanvien
            // 
            this.picBox_anhNhanvien.Location = new System.Drawing.Point(750, 15);
            this.picBox_anhNhanvien.Name = "picBox_anhNhanvien";
            this.picBox_anhNhanvien.Size = new System.Drawing.Size(230, 195);
            this.picBox_anhNhanvien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_anhNhanvien.TabIndex = 145;
            this.picBox_anhNhanvien.TabStop = false;
            // 
            // btn_chonAnh
            // 
            this.btn_chonAnh.Location = new System.Drawing.Point(815, 245);
            this.btn_chonAnh.Name = "btn_chonAnh";
            this.btn_chonAnh.Size = new System.Drawing.Size(100, 23);
            this.btn_chonAnh.TabIndex = 146;
            this.btn_chonAnh.Text = "Chọn ảnh";
            this.btn_chonAnh.UseVisualStyleBackColor = true;
            this.btn_chonAnh.Click += new System.EventHandler(this.btn_chonAnh_Click);
            // 
            // lbl_tenAnh
            // 
            this.lbl_tenAnh.AutoSize = true;
            this.lbl_tenAnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_tenAnh.Location = new System.Drawing.Point(835, 225);
            this.lbl_tenAnh.Name = "lbl_tenAnh";
            this.lbl_tenAnh.Size = new System.Drawing.Size(48, 15);
            this.lbl_tenAnh.TabIndex = 147;
            this.lbl_tenAnh.Text = "Tên ảnh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_khonghoatdong);
            this.panel1.Controls.Add(this.rbtn_hoatdong);
            this.panel1.Location = new System.Drawing.Point(455, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 25);
            this.panel1.TabIndex = 148;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtn_nu);
            this.panel2.Controls.Add(this.rbtn_nam);
            this.panel2.Location = new System.Drawing.Point(90, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 25);
            this.panel2.TabIndex = 149;
            // 
            // FrmNhanVienService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_tenAnh);
            this.Controls.Add(this.btn_chonAnh);
            this.Controls.Add(this.picBox_anhNhanvien);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_cccd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_chucvuService);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.dgrid_nhanvien);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.cmb_locChucvu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmb_chucvu);
            this.Controls.Add(this.dtpicker_ngaysinh);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_tendem);
            this.Controls.Add(this.txt_ho);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhanVienService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNhanVienService";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_anhNhanvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_chucvuService;
        private TextBox txt_timkiem;
        private DataGridView dgrid_nhanvien;
        private Button btn_clear;
        private Button btn_sua;
        private Button btn_them;
        private ComboBox cmb_locChucvu;
        private Label label14;
        private ComboBox cmb_chucvu;
        private DateTimePicker dtpicker_ngaysinh;
        private RadioButton rbtn_nu;
        private RadioButton rbtn_nam;
        private TextBox txt_matkhau;
        private TextBox txt_sdt;
        private TextBox txt_diachi;
        private TextBox txt_ten;
        private TextBox txt_tendem;
        private TextBox txt_ho;
        private TextBox txt_ma;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_cccd;
        private Label label1;
        private RadioButton rbtn_khonghoatdong;
        private RadioButton rbtn_hoatdong;
        private TextBox txt_email;
        private Label label11;
        private PictureBox picBox_anhNhanvien;
        private Button btn_chonAnh;
        private Label lbl_tenAnh;
        private Panel panel1;
        private Panel panel2;
    }
}