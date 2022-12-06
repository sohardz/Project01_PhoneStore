using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PL.Views.Stuff;

namespace _3.PL.Views.DangNhap
{
    public partial class FrmDangNhap : Form
    {
        INhanVienService nhanVienService;
        readonly string username = "admin";
        readonly string password = "admin";

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmQuenMatKhau frmQuenMatKhau = new FrmQuenMatKhau();
            frmQuenMatKhau.Show();
            Hide();
        }

        private void cb_SaveAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_email.Text != "" && txt_password.Text != "")
            {
                if (cb_SaveAccount.Checked == true)
                {
                    string email = txt_email.Text;
                    string pass = txt_password.Text;
                    Properties.Settings.Default.Email = email;
                    Properties.Settings.Default.Password = pass;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txt_email.Text = Properties.Settings.Default.Email;
            txt_password.Text = Properties.Settings.Default.Password;
            if (Properties.Settings.Default.Email != string.Empty)
            {
                cb_SaveAccount.Checked = true;
            }
        }
    }
}
