using System.Text;
using System.Xml.Serialization;

namespace _3.PL.Utilities
{
    public class Utility
    {
        public static string ZenMaTuDong(string fullName)
        {
            string temp = fullName.Trim().ToLower();
            string[] arrValues = temp.Split(' ');
            string final = GetVietHoaChuCaiDau(arrValues[^1]).Trim();
            for (int i = 0; i < arrValues.Length - 1; i++)
            {
                final += GetChuCaiDau(arrValues[i]);
            }
            return LoaiBoDauTiengViet(final);
        }
        public static string GetNumber(int length)
        {
            Random random = new Random();
            string allchar = "0123456789";
            string ketqua = "";

            for (int i = 0; i < length; i++)
            {
                ketqua += allchar[(random.Next(length))];
            }
            return ketqua;
        }

        public static string VietHoaFullName(string fullName)
        {
            string temp = fullName.Trim().ToLower();
            string[] arrValues = temp.Split(' ');
            string final = "";

            for (int i = 0; i < arrValues.Length; i++)
            {
                final += GetVietHoaChuCaiDau(arrValues[i]);
            }
            return final;
        }

        private static string GetChuCaiDau(string value)
        {
            return string.IsNullOrEmpty(value) ? "" : Convert.ToString(value[0]);
        }

        private static string GetVietHoaChuCaiDau(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";
            return Convert.ToString(value[0]).ToUpper() + value.Substring(1) + " ";
        }

        //Loại bỏ toàn bộ dấu trong tiếng việt
        public static string LoaiBoDauTiengViet(string str)
        {
            string strFormD = str.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strFormD.Length; i++)
            {
                System.Globalization.UnicodeCategory uc =
                    System.Globalization.CharUnicodeInfo.GetUnicodeCategory(strFormD[i]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(strFormD[i]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }

        public static List<string> GetThanhPho()
        {
            return new List<string>() { "Hà Nội", "Hải Phòng", "Hải Dương", "Hồ Chí Minh", "Đà Nẵng", "Vũng Tàu", "Quảng Ninh" };
        }

        public static List<string> TrangThai()
        {
            return new List<string>() { "Không hoạt động", "Hoạt động" };
        }

        public static List<string> TrangThaiHoaDon()
        {
            return new List<string>() { "Chưa thanh toán", "Đã thanh toán", "Hủy", "Đang giao", "Đã giao", "Đã cọc", "Hoàn thành" };
        }

        //Đọc file XML
        public static List<T> DocFile<T>(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("file không tồn tại"); return null;
            }
            else
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<T>));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    List<T> result = ((List<T>)xs.Deserialize(fs));
                    fs.Close(); return result;
                }

            }
        }

        //Ghi file XML
        public static void GhiFile<T>(string path, List<T> t)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("file không tồn tại");
            }
            else
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<T>));
                using (TextWriter tw = new StreamWriter(path))
                {
                    xs.Serialize(tw, t); tw.Close();
                }
            }
        }

        //lấy đường dẫn ảnh
        public static void LoadImage(ref string imagePath)
        {
            OpenFileDialog fileImgName = new OpenFileDialog();
            if (fileImgName.ShowDialog() == DialogResult.OK)
            {
                imagePath = fileImgName.FileName;
            }
        }
    }
}
