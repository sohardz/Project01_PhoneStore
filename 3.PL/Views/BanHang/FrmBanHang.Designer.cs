namespace _3.PL.Views.BanHang
{
    partial class FrmBanHang
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_pay = new System.Windows.Forms.Button();
            this.lbl_change = new System.Windows.Forms.Label();
            this.lbl_orderTotal = new System.Windows.Forms.Label();
            this.txt_customerGive = new System.Windows.Forms.TextBox();
            this.txt_sale = new System.Windows.Forms.TextBox();
            this.txt_maOrder = new System.Windows.Forms.TextBox();
            this.rtxt_note = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_searchProduct = new System.Windows.Forms.TextBox();
            this.dgrid_productDetail = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrid_undoneOrder = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_huy = new System.Windows.Forms.RadioButton();
            this.rbtn_dacoc = new System.Windows.Forms.RadioButton();
            this.rbtn_dahoanthanh = new System.Windows.Forms.RadioButton();
            this.rbtn_chuathanhtoan = new System.Windows.Forms.RadioButton();
            this.cmb_staff = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_customerPhoneNumber = new System.Windows.Forms.ComboBox();
            this.lbl_totalcart = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_listcamera = new System.Windows.Forms.ComboBox();
            this.txt_timgiohang = new System.Windows.Forms.TextBox();
            this.btn_updateOrder = new System.Windows.Forms.Button();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.btn_deleteCart = new System.Windows.Forms.Button();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.lbl_diemtichluy = new System.Windows.Forms.Label();
            this.lbl_customerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_orderDetail = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_productDetail)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_undoneOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_orderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_pay);
            this.groupBox4.Controls.Add(this.lbl_change);
            this.groupBox4.Controls.Add(this.lbl_orderTotal);
            this.groupBox4.Controls.Add(this.txt_customerGive);
            this.groupBox4.Controls.Add(this.txt_sale);
            this.groupBox4.Controls.Add(this.txt_maOrder);
            this.groupBox4.Controls.Add(this.rtxt_note);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.groupBox4.Location = new System.Drawing.Point(888, 493);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 325);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thanh toán";
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(107, 282);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(219, 37);
            this.btn_pay.TabIndex = 16;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Location = new System.Drawing.Point(137, 186);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(13, 15);
            this.lbl_change.TabIndex = 20;
            this.lbl_change.Text = "0";
            // 
            // lbl_orderTotal
            // 
            this.lbl_orderTotal.AutoSize = true;
            this.lbl_orderTotal.Location = new System.Drawing.Point(137, 110);
            this.lbl_orderTotal.Name = "lbl_orderTotal";
            this.lbl_orderTotal.Size = new System.Drawing.Size(13, 15);
            this.lbl_orderTotal.TabIndex = 19;
            this.lbl_orderTotal.Text = "0";
            // 
            // txt_customerGive
            // 
            this.txt_customerGive.Location = new System.Drawing.Point(137, 144);
            this.txt_customerGive.Name = "txt_customerGive";
            this.txt_customerGive.Size = new System.Drawing.Size(232, 23);
            this.txt_customerGive.TabIndex = 18;
            this.txt_customerGive.TextChanged += new System.EventHandler(this.txt_customerGive_TextChanged);
            // 
            // txt_sale
            // 
            this.txt_sale.Location = new System.Drawing.Point(137, 66);
            this.txt_sale.Name = "txt_sale";
            this.txt_sale.Size = new System.Drawing.Size(232, 23);
            this.txt_sale.TabIndex = 17;
            // 
            // txt_maOrder
            // 
            this.txt_maOrder.Location = new System.Drawing.Point(137, 22);
            this.txt_maOrder.Name = "txt_maOrder";
            this.txt_maOrder.Size = new System.Drawing.Size(232, 23);
            this.txt_maOrder.TabIndex = 16;
            // 
            // rtxt_note
            // 
            this.rtxt_note.Location = new System.Drawing.Point(137, 219);
            this.rtxt_note.Name = "rtxt_note";
            this.rtxt_note.Size = new System.Drawing.Size(307, 45);
            this.rtxt_note.TabIndex = 6;
            this.rtxt_note.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Ghi chú";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tiền thừa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tiền khách đưa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tổng tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giảm giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã hóa đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_searchProduct);
            this.groupBox3.Controls.Add(this.dgrid_productDetail);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(862, 457);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm";
            // 
            // txt_searchProduct
            // 
            this.txt_searchProduct.Location = new System.Drawing.Point(6, 22);
            this.txt_searchProduct.Name = "txt_searchProduct";
            this.txt_searchProduct.Size = new System.Drawing.Size(297, 23);
            this.txt_searchProduct.TabIndex = 3;
            this.txt_searchProduct.Text = "Tìm kiếm...";
            // 
            // dgrid_productDetail
            // 
            this.dgrid_productDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgrid_productDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_productDetail.Location = new System.Drawing.Point(6, 51);
            this.dgrid_productDetail.Name = "dgrid_productDetail";
            this.dgrid_productDetail.RowTemplate.Height = 25;
            this.dgrid_productDetail.Size = new System.Drawing.Size(850, 400);
            this.dgrid_productDetail.TabIndex = 2;
            this.dgrid_productDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_productDetail_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrid_undoneOrder);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.groupBox2.Location = new System.Drawing.Point(963, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 331);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đơn hàng đang xử lí";
            // 
            // dgrid_undoneOrder
            // 
            this.dgrid_undoneOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgrid_undoneOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_undoneOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_undoneOrder.Location = new System.Drawing.Point(3, 19);
            this.dgrid_undoneOrder.Name = "dgrid_undoneOrder";
            this.dgrid_undoneOrder.RowTemplate.Height = 25;
            this.dgrid_undoneOrder.Size = new System.Drawing.Size(369, 309);
            this.dgrid_undoneOrder.TabIndex = 1;
            this.dgrid_undoneOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_undoneOrder_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_huy);
            this.groupBox1.Controls.Add(this.rbtn_dacoc);
            this.groupBox1.Controls.Add(this.rbtn_dahoanthanh);
            this.groupBox1.Controls.Add(this.rbtn_chuathanhtoan);
            this.groupBox1.Controls.Add(this.cmb_staff);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_customerPhoneNumber);
            this.groupBox1.Controls.Add(this.lbl_totalcart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb_listcamera);
            this.groupBox1.Controls.Add(this.txt_timgiohang);
            this.groupBox1.Controls.Add(this.btn_updateOrder);
            this.groupBox1.Controls.Add(this.btn_addOrder);
            this.groupBox1.Controls.Add(this.btn_deleteCart);
            this.groupBox1.Controls.Add(this.btn_deleteProduct);
            this.groupBox1.Controls.Add(this.lbl_diemtichluy);
            this.groupBox1.Controls.Add(this.lbl_customerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgrid_orderDetail);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 331);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ hàng";
            // 
            // rbtn_huy
            // 
            this.rbtn_huy.AutoSize = true;
            this.rbtn_huy.Location = new System.Drawing.Point(716, 213);
            this.rbtn_huy.Name = "rbtn_huy";
            this.rbtn_huy.Size = new System.Drawing.Size(47, 19);
            this.rbtn_huy.TabIndex = 24;
            this.rbtn_huy.TabStop = true;
            this.rbtn_huy.Text = "Hủy";
            this.rbtn_huy.UseVisualStyleBackColor = true;
            // 
            // rbtn_dacoc
            // 
            this.rbtn_dacoc.AutoSize = true;
            this.rbtn_dacoc.Location = new System.Drawing.Point(585, 213);
            this.rbtn_dacoc.Name = "rbtn_dacoc";
            this.rbtn_dacoc.Size = new System.Drawing.Size(61, 19);
            this.rbtn_dacoc.TabIndex = 23;
            this.rbtn_dacoc.TabStop = true;
            this.rbtn_dacoc.Text = "Đã cọc";
            this.rbtn_dacoc.UseVisualStyleBackColor = true;
            // 
            // rbtn_dahoanthanh
            // 
            this.rbtn_dahoanthanh.AutoSize = true;
            this.rbtn_dahoanthanh.Location = new System.Drawing.Point(716, 176);
            this.rbtn_dahoanthanh.Name = "rbtn_dahoanthanh";
            this.rbtn_dahoanthanh.Size = new System.Drawing.Size(100, 19);
            this.rbtn_dahoanthanh.TabIndex = 20;
            this.rbtn_dahoanthanh.TabStop = true;
            this.rbtn_dahoanthanh.Text = "Đã thanh toán";
            this.rbtn_dahoanthanh.UseVisualStyleBackColor = true;
            // 
            // rbtn_chuathanhtoan
            // 
            this.rbtn_chuathanhtoan.AutoSize = true;
            this.rbtn_chuathanhtoan.Location = new System.Drawing.Point(585, 176);
            this.rbtn_chuathanhtoan.Name = "rbtn_chuathanhtoan";
            this.rbtn_chuathanhtoan.Size = new System.Drawing.Size(114, 19);
            this.rbtn_chuathanhtoan.TabIndex = 19;
            this.rbtn_chuathanhtoan.TabStop = true;
            this.rbtn_chuathanhtoan.Text = "Chưa thanh toán";
            this.rbtn_chuathanhtoan.UseVisualStyleBackColor = true;
            // 
            // cmb_staff
            // 
            this.cmb_staff.FormattingEnabled = true;
            this.cmb_staff.Location = new System.Drawing.Point(690, 126);
            this.cmb_staff.Name = "cmb_staff";
            this.cmb_staff.Size = new System.Drawing.Size(172, 23);
            this.cmb_staff.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nhân viên";
            // 
            // cmb_customerPhoneNumber
            // 
            this.cmb_customerPhoneNumber.FormattingEnabled = true;
            this.cmb_customerPhoneNumber.Location = new System.Drawing.Point(690, 17);
            this.cmb_customerPhoneNumber.Name = "cmb_customerPhoneNumber";
            this.cmb_customerPhoneNumber.Size = new System.Drawing.Size(172, 23);
            this.cmb_customerPhoneNumber.TabIndex = 16;
            // 
            // lbl_totalcart
            // 
            this.lbl_totalcart.AutoSize = true;
            this.lbl_totalcart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalcart.Location = new System.Drawing.Point(398, 300);
            this.lbl_totalcart.Name = "lbl_totalcart";
            this.lbl_totalcart.Size = new System.Drawing.Size(19, 21);
            this.lbl_totalcart.TabIndex = 15;
            this.lbl_totalcart.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(309, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng tiền";
            // 
            // cmb_listcamera
            // 
            this.cmb_listcamera.FormattingEnabled = true;
            this.cmb_listcamera.Location = new System.Drawing.Point(131, 302);
            this.cmb_listcamera.Name = "cmb_listcamera";
            this.cmb_listcamera.Size = new System.Drawing.Size(172, 23);
            this.cmb_listcamera.TabIndex = 13;
            // 
            // txt_timgiohang
            // 
            this.txt_timgiohang.Location = new System.Drawing.Point(6, 302);
            this.txt_timgiohang.Name = "txt_timgiohang";
            this.txt_timgiohang.Size = new System.Drawing.Size(119, 23);
            this.txt_timgiohang.TabIndex = 12;
            // 
            // btn_updateOrder
            // 
            this.btn_updateOrder.Location = new System.Drawing.Point(354, 250);
            this.btn_updateOrder.Name = "btn_updateOrder";
            this.btn_updateOrder.Size = new System.Drawing.Size(110, 30);
            this.btn_updateOrder.TabIndex = 11;
            this.btn_updateOrder.Text = "Cập nhật HĐ";
            this.btn_updateOrder.UseVisualStyleBackColor = true;
            this.btn_updateOrder.Click += new System.EventHandler(this.btn_updateOrder_Click);
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.Location = new System.Drawing.Point(238, 250);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(110, 30);
            this.btn_addOrder.TabIndex = 10;
            this.btn_addOrder.Text = "Tạo hóa đơn";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // btn_deleteCart
            // 
            this.btn_deleteCart.Location = new System.Drawing.Point(122, 250);
            this.btn_deleteCart.Name = "btn_deleteCart";
            this.btn_deleteCart.Size = new System.Drawing.Size(110, 30);
            this.btn_deleteCart.TabIndex = 9;
            this.btn_deleteCart.Text = "Xóa giỏ hàng";
            this.btn_deleteCart.UseVisualStyleBackColor = true;
            this.btn_deleteCart.Click += new System.EventHandler(this.btn_deleteCart_Click);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Location = new System.Drawing.Point(6, 250);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(110, 30);
            this.btn_deleteProduct.TabIndex = 8;
            this.btn_deleteProduct.Text = "Xóa sản phẩm";
            this.btn_deleteProduct.UseVisualStyleBackColor = true;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // lbl_diemtichluy
            // 
            this.lbl_diemtichluy.AutoSize = true;
            this.lbl_diemtichluy.Location = new System.Drawing.Point(690, 93);
            this.lbl_diemtichluy.Name = "lbl_diemtichluy";
            this.lbl_diemtichluy.Size = new System.Drawing.Size(16, 15);
            this.lbl_diemtichluy.TabIndex = 7;
            this.lbl_diemtichluy.Text = "...";
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.AutoSize = true;
            this.lbl_customerName.Location = new System.Drawing.Point(690, 56);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(16, 15);
            this.lbl_customerName.TabIndex = 5;
            this.lbl_customerName.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điểm tích lũy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sđt Khách hàng";
            // 
            // dgrid_orderDetail
            // 
            this.dgrid_orderDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgrid_orderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_orderDetail.Location = new System.Drawing.Point(6, 20);
            this.dgrid_orderDetail.Name = "dgrid_orderDetail";
            this.dgrid_orderDetail.RowTemplate.Height = 25;
            this.dgrid_orderDetail.Size = new System.Drawing.Size(562, 212);
            this.dgrid_orderDetail.TabIndex = 0;
            this.dgrid_orderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_orderDetail_CellClick);
            this.dgrid_orderDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_orderDetail_CellValueChanged);
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1350, 830);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBanHangService";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_productDetail)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_undoneOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_orderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox4;
        private Button btn_pay;
        private Label lbl_change;
        private Label lbl_orderTotal;
        private TextBox txt_customerGive;
        private TextBox txt_sale;
        private TextBox txt_maOrder;
        private RichTextBox rtxt_note;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox3;
        private TextBox txt_searchProduct;
        private DataGridView dgrid_productDetail;
        private GroupBox groupBox2;
        private DataGridView dgrid_undoneOrder;
        private GroupBox groupBox1;
        private ComboBox cmb_staff;
        private Label label4;
        private ComboBox cmb_customerPhoneNumber;
        private Label lbl_totalcart;
        private Label label6;
        private ComboBox cmb_listcamera;
        private TextBox txt_timgiohang;
        private Button btn_updateOrder;
        private Button btn_addOrder;
        private Button btn_deleteCart;
        private Button btn_deleteProduct;
        private Label lbl_diemtichluy;
        private Label lbl_customerName;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgrid_orderDetail;
        private RadioButton rbtn_chuathanhtoan;
        private RadioButton rbtn_dacoc;
        private RadioButton rbtn_dahoanthanh;
        private RadioButton rbtn_huy;
    }
}