using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views.DangNhap
{
    public partial class FrmQuenMatKhau : Form
    {
        INhanVienService nhanVienService;
        string body;
        string email;
        
        string from = "hieulmph27350@fpt.edu.vn";
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
        }

        public void SendMail(string ballsack)
        {
 
            MailMessage message = new MailMessage(from, email, "", body);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            client.Credentials = new NetworkCredential("hieulmph27350@fpt.edu.vn", "olanibba123");
            client.EnableSsl = true;
            client.Send(message);

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            var nhanVien = nhanVienService.GetAll().FirstOrDefault(c => c.Email == txtEmail.Text).Email;
            var matkhau = nhanVienService.GetAll().FirstOrDefault(c => c.Email == txtEmail.Text).MatKhau;

            DialogResult dialogResult = MessageBox.Show("Confirm ko con bitch?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (nhanVien == txtEmail.Text)
                {
                    email = txtEmail.Text;
                    body = "Mật khẩu của bạn là" + matkhau;
                    SendMail(txtEmail.Text);
                    MessageBox.Show("Gửi mail thành công ", "Thông ball");
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new ();
            frmDangNhap.Show();
            Close();  
        }


    }
}
