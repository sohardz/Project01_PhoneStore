using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Views.BanHang;

namespace _3.PL.Views.Stuff
{
    public partial class FrmThemIMEI : Form
    {
        public List<IMEIView> listIMEI; 
        private int soluong;
        private string maCthd;
        private IHoaDonChiTietService hoaDonChiTietService;
        private IIMEIService iMEIService;

        //public delegate void SendIMEI(List<IMEIView> lst);

        public FrmThemIMEI(string MaCthd, int SoLuong)
        {
            InitializeComponent();
            listIMEI = new List<IMEIView>();
            maCthd = MaCthd;
            soluong = SoLuong;
            hoaDonChiTietService = new HoaDonChiTietService();
            iMEIService = new IMEIService();
            LoadDgrid();
        }

        //Load Dgrid với button thêm IMEI
        private void LoadDgrid()
        {
            dgrid_imei.ColumnCount = 2;
            dgrid_imei.Columns[0].Name = "Mã CTHĐ";
            dgrid_imei.Columns[1].Name = "IMEI";

            DataGridViewButtonColumn columnButton = new()
            {
                HeaderText = "Xác nhận",
                Text = "Thêm",
                Name = "btn",
                UseColumnTextForButtonValue = true
            };
            dgrid_imei.Columns.Add(columnButton);

            for (int i = 0; i < soluong; i++)
            {
                dgrid_imei.Rows.Add(maCthd);
            }
        }

        //check IMEI
        private bool CheckIMEI(string IMEI)
        {
            if (IMEI.Contains(' '))
            {
                MessageBox.Show("IMEI không được chứa khoảng trắng");
                return false;
            }

            if (IMEI.Length < 15)
            {
                MessageBox.Show("IMEI chưa đủ độ dài");
                return false;
            }

            bool c = long.TryParse(IMEI, out _);


            if (!long.TryParse(IMEI, out _))
            {
                MessageBox.Show("IMEI không hợp lệ");
                return false;
            }

            foreach (var x in iMEIService.GetAll())
            {
                if (x.MaIMEI == IMEI)
                {
                    MessageBox.Show("IMEI đã tồn tại");
                    return false;
                }
            }

            foreach (var x in listIMEI)
            {
                if (x.MaIMEI == IMEI)
                {
                    MessageBox.Show("IMEI đã tồn tại");
                    return false;
                }
            }

            return true;
        }

        //thêm IMEI với button ở DataGridView
        private void dgrid_imei_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dgrid_imei.RowCount - 1)
            {
                int r = e.RowIndex;

                if (e.ColumnIndex == 2)
                {
                    if (CheckIMEI(dgrid_imei.Rows[r].Cells[1].Value.ToString()))
                    {
                        var imei = new IMEIView()
                        {
                            MaHoaDonChiTiet = dgrid_imei.Rows[r].Cells[0].Value.ToString(),
                            MaIMEI = dgrid_imei.Rows[r].Cells[1].Value.ToString(),
                            TrangThai = 1,
                        };

                        listIMEI.Add(imei);
                        MessageBox.Show("Thêm IMEI thành công", "Thông báo");
                    }
                }
            }
            else return;
        }

        private void btn_sendIMEI_Click(object sender, EventArgs e)
        {
           DialogResult = DialogResult.OK;
            Close();
        }
    }
}
