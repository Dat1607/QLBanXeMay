using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanXeMay
{
    public class TT_HOADON
    {
        public string maHD { get; set; }
        public string maKH { get; set; }
        public string maNV { get; set; }
        public string maXe { get; set; }
        public int soLuong { get; set; }
        public double Gia { get; set; }
        public double GTGT { get; set; }
        public double thanhTien { get; set; }
        public TT_HOADON(string mahd,string makh,string manv,string maxe, int soluong,double gia,double gtgt,double thanhtien)
        {
            maHD = mahd;
            maKH = makh;
            maNV = manv;
            maXe = maxe;
            soLuong = soluong;
            Gia = gia;
            GTGT = gtgt;
            thanhTien = thanhtien;
        }
    }
}
