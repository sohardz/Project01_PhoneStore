using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PL.Views.Stuff
{
    public partial class FrmThemIMEI : Form
    {
        public List<IMEIView> lstIMEI;
        private string maCthd;
        private IHoaDonChiTietService hoaDonChiTietService;
        private IIMEIService iMEIService;

        public FrmThemIMEI(string MaCthd)
        {
            InitializeComponent();
            maCthd = MaCthd;
            hoaDonChiTietService = new HoaDonChiTietService();
            iMEIService = new IMEIService();
            LoadDgrid();
        }

        private void LoadDgrid()
        {
            int stt = 1;
            dgrid_imei.ColumnCount = 3;
            dgrid_imei.Columns[0].Name = "IMEI";
            dgrid_imei.Columns[1].Name = "Mã CTHĐ";
            dgrid_imei.Columns[2].Name = "IMEI";

            DataGridViewButtonColumn columnButton = new()
            {
                HeaderText = "Xác nhận",
                Text = "Quét",
                Name = "btn",
                UseColumnTextForButtonValue = true
            };
            dgrid_imei.Columns.Add(columnButton);

            //foreach (var x in hoaDonChiTietService.GetAll().FirstOrDefault(c=>c.Ma == maCthd).SoLuong)
            //{

            //}

            for (int i = 0; i < hoaDonChiTietService.GetAll().FirstOrDefault(c => c.Ma == maCthd).SoLuong; i++)
            {
                dgrid_imei.Rows.Add();
            }
        }
    }
}
