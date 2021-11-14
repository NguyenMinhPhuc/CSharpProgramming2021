using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
   public class cls_ActionString
    {
        /// <summary>
        /// Kiểm tra một chuỗi có phải là số hay không
        /// </summary>
        /// <param name="pValue">Chuỗi ký tự cần kiểm tra</param>
        /// <returns>Nếu là số trả về True, ngược lại trả về False</returns>
        public static bool IsNumber1(string pValue)
        {
           
                foreach (Char c in pValue)
                {
                    if (!Char.IsDigit(c))
                        return false;
                }
                return true;
           
        }
        /// <summary>
        /// Kiểm tra một chuỗi có phải là số hay không
        /// </summary>
        /// <param name="pValue">Chuỗi ký tự cần kiểm tra</param>
        /// <returns>Nếu là số trả về True, ngược lại trả về False</returns>
        public static bool IsNumber2(string pText)
        {
            
                Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
                return regex.IsMatch(pText);
            
        }
        /// <summary>
        /// Mảng sử dụng để bỏ dấu tiếng việt
        /// </summary>
        private static readonly string[] VietnameseSigns = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởõ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞÕ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỷỹỵ",
            "ÝỲỶỸỴ"
        };
        /// <summary>
        /// Phương thức sử dụng để bỏ dấu tiếng việt.
        /// chuyển một câu có dấu thành một câu không dấu tương ứng.
        /// </summary>
        /// <param name="str">Chuỗi có dấu được truyền vào phương thức</param>
        /// <returns>Chuỗi không dấu tương ứng</returns>
        public static string bodautiengviet(string str)
        {
            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                {
                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
                }
            }
            return str;
        }
        /// <summary>
        /// Xóa khoảng trắng dư trong chuỗi truyền vào
        /// </summary>
        /// <param name="chuoi">Chuỗi truyền vào phương thức</param>
        /// <returns>Chuỗi đã được xóa khoảng trắng dư</returns>
        public static string xoakhoangtrangdu(string chuoi)
        {
            chuoi = chuoi.Trim();//xoa khoang trang dau va cuoi cua chuoi
            string mau = @"\s+";
            Regex myregex = new Regex(mau);
            return myregex.Replace(chuoi, " ");
        }
        public static string xoakhoangtrang(string chuoi)
        {
            chuoi = chuoi.Trim();//xoa khoang trang dau va cuoi cua chuoi
            string mau = @"\s+";
            Regex myregex = new Regex(mau);
            return myregex.Replace(chuoi, "");
        }
        /// <summary>
        /// Phương thức xóa các ký tự đặc biệt có trong chuỗi truyền vào
        /// </summary>
        /// <param name="chuoi">Chuỗi truyền vào phương thức</param>
        /// <returns>Chuỗi đã được xóa ký tự đặc biệt</returns>
        public static string xoakytudacbiet(string chuoi)
        {
            chuoi = chuoi.Trim();//xoa khoang trang dau va cuoi cua chuoi
            string mau = @"\W+";
            Regex myregex = new Regex(mau);
            return myregex.Replace(chuoi, " ");
        }
        /// <summary>
        /// Phương thức lấy ký tự tắt từ chuỗi ký tự truyền vào
        /// Lấy ký tự đầu tiên trong chuỗi để ghép thành ký tự tắt
        /// </summary>
        /// <param name="chuoi">Chuỗi cần lấy ký tự tắt</param>
        /// <returns>Chuỗi viết tắt</returns>
        public static string laykytutat(string chuoi)
        {
            chuoi = xoakytudacbiet(chuoi.ToUpper());
            char[] charArr = chuoi.ToCharArray();
            string chuoitat = "";
            chuoitat = charArr[0].ToString();
            string mau = @"\s\S";
            Regex Myregex = new Regex(mau);
            MatchCollection mc;
            mc = Myregex.Matches(chuoi);
            foreach (Match item in mc)
            {
                chuoitat += item.Value.ToUpper().Trim()[0];
            }
            return chuoitat;
        }
        /// <summary>
        /// Phương thức sử dụng để tách tên ra khỏi chuỗi họ tên
        /// </summary>
        /// <param name="chuoi">Họ tên cần tách tên</param>
        /// <returns>Tên được tách</returns>
        public static string tachten(string chuoi)
        {
            int x = chuoi.LastIndexOf(" ");
            string ten = "";
            ten = chuoi.Substring(x);
            return ten.Trim();
        }
        /// <summary>
        /// Phương thức tách lấy họ trong chuỗi họ tên truyền vào
        /// </summary>
        /// <param name="chuoi">Chuỗi họ tên cần tách</param>
        /// <returns>Họ và tên lót được tách</returns>
        public static string tachho(string chuoi)
        {
            int x = chuoi.LastIndexOf(" ");
            string ho = "";
            ho = chuoi.Substring(0, x);
            return ho.Trim();
        }
        /// <summary>
        /// Phương thức tách lấy tên file trong chuỗi đường dẫn truyền vào.
        /// </summary>
        /// <param name="chuoi">Đường dẫn tập tin</param>
        /// <returns>Tên tập tin</returns>
        public static string tachtenfile(string chuoi)
        {
            int x = chuoi.LastIndexOf("\\");
            string tenfile = "";
            tenfile = chuoi.Substring(x);
            return tenfile.Trim();
        }
        /// <summary>
        /// Hàm chuyển các ký tự đầu các từ thành hoa
        /// </summary>
        /// <param name="str">tham số truyền vào</param>
        /// <returns>ví vụ: chuoi so --> Chuoi So</returns>

        public static string chuyenhoadautu(string str)
        {
            str = str.ToLower();
            char[] charArr = str.ToCharArray();
            charArr[0] = char.ToUpper(charArr[0]);
            foreach (Match m in Regex.Matches(str, @"\s\S"))
            {
                charArr[m.Index + 1] = m.Value.ToUpper().Trim()[0];
            }
            return new string(charArr);
        }
        public static string themdauphanngan(string str, TextBox txt)
        {

            str = str.Replace(",", "");
            int cd = str.Length;
            if (cd > 3 && cd <= 6)
            {
                str = str.Insert(cd - 3, ",");
            }
            if (cd > 6 && cd <= 9)
            {
                str = str.Insert(cd - 3, ",");
                str = str.Insert(cd - 6, ",");
            }
            if (cd > 9 && cd <= 12)
            {
                str = str.Insert(cd - 3, ",");
                str = str.Insert(cd - 6, ",");
                str = str.Insert(cd - 9, ",");
            }
            if (cd > 12 && cd <= 15)
            {
                str = str.Insert(cd - 3, ",");
                str = str.Insert(cd - 6, ",");
                str = str.Insert(cd - 9, ",");
                str = str.Insert(cd - 12, ",");
            }
            if (cd > 15 && cd <= 18)
            {
                str = str.Insert(cd - 3, ",");
                str = str.Insert(cd - 6, ",");
                str = str.Insert(cd - 9, ",");
                str = str.Insert(cd - 12, ",");
                str = str.Insert(cd - 15, ",");
            }
            if (cd > 18 && cd <= 21)
            {
                str = str.Insert(cd - 3, ",");
                str = str.Insert(cd - 6, ",");
                str = str.Insert(cd - 9, ",");
                str = str.Insert(cd - 12, ",");
                str = str.Insert(cd - 15, ",");
                str = str.Insert(cd - 18, ",");
            }
            txt.SelectionStart = txt.TextLength;
            return str;
        }
        private static void themdauphanngan(TextBox txt)
        {
            txt.Text = String.Format("0:#,###", Convert.ToDouble(txt.Text.Replace(",", "")));
        }
        public static string themdauphanngan(string str, string dau, TextBox txt)
        {

            str = str.Replace(dau, "");
            int cd = str.Length;
            if (cd > 3 && cd <= 6)
            {
                str = str.Insert(cd - 3, dau);
            }
            if (cd > 6 && cd <= 9)
            {
                str = str.Insert(cd - 3, dau);
                str = str.Insert(cd - 6, dau);
            }
            if (cd > 9 && cd <= 12)
            {
                str = str.Insert(cd - 3, dau);
                str = str.Insert(cd - 6, dau);
                str = str.Insert(cd - 9, dau);
            }
            if (cd > 12 && cd <= 15)
            {
                str = str.Insert(cd - 3, dau);
                str = str.Insert(cd - 6, dau);
                str = str.Insert(cd - 9, dau);
                str = str.Insert(cd - 12, dau);
            }
            if (cd > 15 && cd <= 18)
            {
                str = str.Insert(cd - 3, dau);
                str = str.Insert(cd - 6, dau);
                str = str.Insert(cd - 9, dau);
                str = str.Insert(cd - 12, dau);
                str = str.Insert(cd - 15, dau);
            }
            if (cd > 18 && cd <= 21)
            {
                str = str.Insert(cd - 3, dau);
                str = str.Insert(cd - 6, dau);
                str = str.Insert(cd - 9, dau);
                str = str.Insert(cd - 12, dau);
                str = str.Insert(cd - 15, dau);
                str = str.Insert(cd - 18, dau);
            }
            txt.SelectionStart = txt.TextLength;
            return str;
        }
        /// <summary>
        /// Hàm bỏ dấu ngăn cách phần ngàn
        /// </summary>
        /// <param name="str">số cần bỏ dấu</param>
        /// <returns>số đã bỏ dấu</returns>
        public static string bodauthamphan(string str)
        {
            return str.Replace(",", "");
        }
        /// <summary>
        /// Hàm bỏ dấu ngăn cách phần ngàn
        /// </summary>
        /// <param name="str">số cần bỏ dấu</param>
        /// <param name="dau">dấu cần bỏ</param>
        /// <returns>số đã bỏ dấu</returns>
        public static string bodauthamphan(string str, string dau)
        {
            return str.Replace(dau, "");
        }

        public static bool kiemtrangaythangnamhople(ref string err, string _datetime)
        {
            bool ketqua = false;
            try
            {
                DateTime ngayhople = Convert.ToDateTime(_datetime);
                ketqua = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return ketqua;
        }
    }
}
