using _3.PL.Views.DangNhap;
using _3.PL.Views.NhanVien;
using _3.PL.Views.Stuff;

namespace _3.PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmDangNhap());
        }
    }
}