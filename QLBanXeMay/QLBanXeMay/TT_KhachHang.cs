using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanXeMay
{
    public class TT_KhachHang
    {
        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public string GIOITINH { get; set; }
        public string GHICHU { get; set; }

        public TT_KhachHang(string maKH, string tenKH, string diachi, string sdt, string gioitinh, string ghichu)
        {
            MAKH = maKH;
            TENKH = tenKH;
            DIACHI = diachi;
            SDT = sdt;
            GIOITINH = gioitinh;
            GHICHU = ghichu;
        }
    }
}
