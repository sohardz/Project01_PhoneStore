using _3.PL.Views.BanHang;
using _3.PL.Views.CtDienthoai;
using _3.PL.Views.DangNhap;
using _3.PL.Views.NhanVien;
using System.Runtime.InteropServices;

namespace _3.PL.Views.Stuff
{
    public partial class FrmDashBoard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public FrmDashBoard()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnl_nav.Height = btn_sellingService.Height;
            pnl_nav.Top = btn_sellingService.Top;
            pnl_nav.Left = btn_sellingService.Left;
            btn_sellingService.BackColor = Color.FromArgb(46, 51, 73);
        }

        #region Load time
        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            timeNow.Start();
            lbl_timenow.Text = DateTime.Now.ToString();
            btn_sellingService_Click(sender, e);
        }

        private void timeNow_Tick(object sender, EventArgs e)
        {
            lbl_timenow.Text = DateTime.Now.ToString();
            timeNow.Start();
        }
        #endregion

        #region đổi dash board
        private void btn_sellingService_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_sellingService.Height;
            pnl_nav.Top = btn_sellingService.Top;
            pnl_nav.Left = btn_sellingService.Left;
            btn_sellingService.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Bán hàng";
            pnl_formLoader.Controls.Clear();
            FrmBanHang frmBanhang = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            pnl_formLoader.Controls.Add(frmBanhang);
            frmBanhang.Show();
        }

        private void btn_productDetailService_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_productDetailService.Height;
            pnl_nav.Top = btn_productDetailService.Top;
            btn_productDetailService.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Sản phẩm";
            pnl_formLoader.Controls.Clear();
            FrmCtDienthoai frmCtDienThoai = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            pnl_formLoader.Controls.Add(frmCtDienThoai);
            frmCtDienThoai.Show();
        }

        private void btn_staffService_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_staffService.Height;
            pnl_nav.Top = btn_staffService.Top;
            btn_staffService.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Nhân viên";
            pnl_formLoader.Controls.Clear();
            FrmNhanVien frmNhanVien = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            pnl_formLoader.Controls.Add(frmNhanVien);
            frmNhanVien.Show();
        }

        private void btn_orderService_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_orderService.Height;
            pnl_nav.Top = btn_orderService.Top;
            btn_orderService.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Hóa Đơn";
            pnl_formLoader.Controls.Clear();
            FrmHoaDon frmHoaDon = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            pnl_formLoader.Controls.Add(frmHoaDon);
            frmHoaDon.Show();
        }

        private void btn_customerService_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_customerService.Height;
            pnl_nav.Top = btn_customerService.Top;
            btn_customerService.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Khách hàng";
            pnl_formLoader.Controls.Clear();
            FrmKhachHang frmKhachHang = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            pnl_formLoader.Controls.Add(frmKhachHang);
            frmKhachHang.Show();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_dangxuat.Height;
            pnl_nav.Top = btn_dangxuat.Top;
            btn_dangxuat.BackColor = Color.FromArgb(46, 51, 73);

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn đăng xuất ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
                FrmDangNhap frmDangNhap = new();
                frmDangNhap.Show();
            }
            else return;
        }
        #endregion

        #region đổi màu ở đâu không biết
        private void btn_sellingService_Leave(object sender, EventArgs e)
        {
            btn_sellingService.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void btn_productDetailService_Leave(object sender, EventArgs e)
        {
            btn_productDetailService.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void btn_staffService_Leave(object sender, EventArgs e)
        {
            btn_staffService.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void btn_orderService_Leave(object sender, EventArgs e)
        {
            btn_orderService.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void btn_customerService_Leave(object sender, EventArgs e)
        {
            btn_customerService.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void btn_setting_Leave(object sender, EventArgs e)
        {
            btn_dangxuat.BackColor = Color.FromArgb(20, 30, 54);
        }
        #endregion
    }
}
