namespace _3.PL.Views.Stuff
{
    partial class FrmDashBoard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.btn_customerService = new System.Windows.Forms.Button();
            this.btn_orderService = new System.Windows.Forms.Button();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.btn_staffService = new System.Windows.Forms.Button();
            this.btn_productDetailService = new System.Windows.Forms.Button();
            this.btn_sellingService = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.picBox_userAvatar = new System.Windows.Forms.PictureBox();
            this.lbl_timenow = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_formLoader = new System.Windows.Forms.Panel();
            this.timeNow = new System.Windows.Forms.Timer(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_userAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnl_nav);
            this.panel1.Controls.Add(this.btn_customerService);
            this.panel1.Controls.Add(this.btn_orderService);
            this.panel1.Controls.Add(this.btn_dangxuat);
            this.panel1.Controls.Add(this.btn_staffService);
            this.panel1.Controls.Add(this.btn_productDetailService);
            this.panel1.Controls.Add(this.btn_sellingService);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 1102);
            this.panel1.TabIndex = 2;
            // 
            // pnl_nav
            // 
            this.pnl_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnl_nav.Location = new System.Drawing.Point(0, 308);
            this.pnl_nav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(3, 133);
            this.pnl_nav.TabIndex = 7;
            // 
            // btn_customerService
            // 
            this.btn_customerService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customerService.FlatAppearance.BorderSize = 0;
            this.btn_customerService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerService.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_customerService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_customerService.Location = new System.Drawing.Point(0, 512);
            this.btn_customerService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_customerService.Name = "btn_customerService";
            this.btn_customerService.Size = new System.Drawing.Size(251, 53);
            this.btn_customerService.TabIndex = 6;
            this.btn_customerService.Text = "Khách hàng";
            this.btn_customerService.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_customerService.UseVisualStyleBackColor = true;
            this.btn_customerService.Click += new System.EventHandler(this.btn_customerService_Click);
            this.btn_customerService.Leave += new System.EventHandler(this.btn_customerService_Leave);
            // 
            // btn_orderService
            // 
            this.btn_orderService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_orderService.FlatAppearance.BorderSize = 0;
            this.btn_orderService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orderService.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_orderService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_orderService.Location = new System.Drawing.Point(0, 459);
            this.btn_orderService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_orderService.Name = "btn_orderService";
            this.btn_orderService.Size = new System.Drawing.Size(251, 53);
            this.btn_orderService.TabIndex = 5;
            this.btn_orderService.Text = "Hóa đơn";
            this.btn_orderService.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_orderService.UseVisualStyleBackColor = true;
            this.btn_orderService.Click += new System.EventHandler(this.btn_orderService_Click);
            this.btn_orderService.Leave += new System.EventHandler(this.btn_orderService_Leave);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangxuat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dangxuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_dangxuat.Location = new System.Drawing.Point(0, 1049);
            this.btn_dangxuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(251, 53);
            this.btn_dangxuat.TabIndex = 4;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            this.btn_dangxuat.Leave += new System.EventHandler(this.btn_setting_Leave);
            // 
            // btn_staffService
            // 
            this.btn_staffService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_staffService.FlatAppearance.BorderSize = 0;
            this.btn_staffService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staffService.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_staffService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_staffService.Location = new System.Drawing.Point(0, 406);
            this.btn_staffService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_staffService.Name = "btn_staffService";
            this.btn_staffService.Size = new System.Drawing.Size(251, 53);
            this.btn_staffService.TabIndex = 3;
            this.btn_staffService.Text = "Nhân viên";
            this.btn_staffService.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_staffService.UseVisualStyleBackColor = true;
            this.btn_staffService.Click += new System.EventHandler(this.btn_staffService_Click);
            this.btn_staffService.Leave += new System.EventHandler(this.btn_staffService_Leave);
            // 
            // btn_productDetailService
            // 
            this.btn_productDetailService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_productDetailService.FlatAppearance.BorderSize = 0;
            this.btn_productDetailService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productDetailService.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_productDetailService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_productDetailService.Location = new System.Drawing.Point(0, 353);
            this.btn_productDetailService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_productDetailService.Name = "btn_productDetailService";
            this.btn_productDetailService.Size = new System.Drawing.Size(251, 53);
            this.btn_productDetailService.TabIndex = 2;
            this.btn_productDetailService.Text = "Sản phẩm";
            this.btn_productDetailService.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_productDetailService.UseVisualStyleBackColor = true;
            this.btn_productDetailService.Click += new System.EventHandler(this.btn_productDetailService_Click);
            this.btn_productDetailService.Leave += new System.EventHandler(this.btn_productDetailService_Leave);
            // 
            // btn_sellingService
            // 
            this.btn_sellingService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sellingService.FlatAppearance.BorderSize = 0;
            this.btn_sellingService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sellingService.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sellingService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_sellingService.Location = new System.Drawing.Point(0, 300);
            this.btn_sellingService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sellingService.Name = "btn_sellingService";
            this.btn_sellingService.Size = new System.Drawing.Size(251, 53);
            this.btn_sellingService.TabIndex = 1;
            this.btn_sellingService.Text = "Bán hàng";
            this.btn_sellingService.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_sellingService.UseVisualStyleBackColor = true;
            this.btn_sellingService.Click += new System.EventHandler(this.btn_sellingService_Click);
            this.btn_sellingService.Leave += new System.EventHandler(this.btn_sellingService_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_userName);
            this.panel2.Controls.Add(this.picBox_userAvatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 300);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(61, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Some user text";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_userName.Location = new System.Drawing.Point(61, 172);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(97, 23);
            this.lbl_userName.TabIndex = 1;
            this.lbl_userName.Text = "User Name";
            // 
            // picBox_userAvatar
            // 
            this.picBox_userAvatar.Location = new System.Drawing.Point(61, 31);
            this.picBox_userAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox_userAvatar.Name = "picBox_userAvatar";
            this.picBox_userAvatar.Size = new System.Drawing.Size(114, 120);
            this.picBox_userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_userAvatar.TabIndex = 0;
            this.picBox_userAvatar.TabStop = false;
            // 
            // lbl_timenow
            // 
            this.lbl_timenow.AutoSize = true;
            this.lbl_timenow.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_timenow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_timenow.Location = new System.Drawing.Point(1424, 31);
            this.lbl_timenow.Name = "lbl_timenow";
            this.lbl_timenow.Size = new System.Drawing.Size(71, 30);
            this.lbl_timenow.TabIndex = 10;
            this.lbl_timenow.Text = "label3";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lbl_title.Location = new System.Drawing.Point(281, 31);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(170, 46);
            this.lbl_title.TabIndex = 9;
            this.lbl_title.Text = "Bán hàng";
            // 
            // pnl_formLoader
            // 
            this.pnl_formLoader.Location = new System.Drawing.Point(297, 147);
            this.pnl_formLoader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_formLoader.Name = "pnl_formLoader";
            this.pnl_formLoader.Size = new System.Drawing.Size(1486, 1000);
            this.pnl_formLoader.TabIndex = 8;
            // 
            // timeNow
            // 
            this.timeNow.Tick += new System.EventHandler(this.timeNow_Tick);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Blue;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1761, 25);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(44, 36);
            this.guna2ControlBox1.TabIndex = 11;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Blue;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1711, 25);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(44, 36);
            this.guna2ControlBox2.TabIndex = 12;
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1829, 1102);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lbl_timenow);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pnl_formLoader);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDashBoard";
            this.Load += new System.EventHandler(this.FrmDashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_userAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel pnl_nav;
        private Button btn_customerService;
        private Button btn_orderService;
        private Button btn_dangxuat;
        private Button btn_staffService;
        private Button btn_productDetailService;
        private Button btn_sellingService;
        private Panel panel2;
        private Label label2;
        private Label lbl_userName;
        private PictureBox picBox_userAvatar;
        private Label lbl_timenow;
        private Label lbl_title;
        private Panel pnl_formLoader;
        private System.Windows.Forms.Timer timeNow;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}