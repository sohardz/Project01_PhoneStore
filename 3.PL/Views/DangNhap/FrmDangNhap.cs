using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PL.Views.Stuff;

namespace _3.PL.Views.DangNhap
{
    public partial class FrmDangNhap : Form
    {
        INhanVienService nhanVienService;
        string username = "admin";
        string password = "admin";

        public FrmDangNhap()
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
        }

        private bool KiemTranDangNhap(string tentaikhoan, string matkhau)
        {
            if (tentaikhoan == username && matkhau == password)
            {
                return true;
            }
            else
            {
                foreach (var item in nhanVienService.GetAll())
                {
                    if (item.Email == tentaikhoan && item.MatKhau == matkhau)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (KiemTranDangNhap(txt_email.Text, txt_password.Text))
            {
                FrmDashBoard frmDashBoard = new();
                frmDashBoard.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Error");
                txt_email.Clear();
                txt_password.Clear();
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
