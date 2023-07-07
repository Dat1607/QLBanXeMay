using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanXeMay
{
    public class TinhToan
    {
        int soLuong;
        double Gia;
        double GTGT;

        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double Gia1 { get => Gia; set => Gia = value; }
        public double GTGT1 { get => GTGT; set => GTGT = value; }
        public TinhToan(int soluong,double gia,double gtgt)
        {
            soLuong = soluong;
            Gia = gia;
            GTGT = gtgt;
        }
        public double ThanhTien()
        {
            return soLuong * Gia - ((soLuong * Gia) * GTGT);
        }
    }
}
