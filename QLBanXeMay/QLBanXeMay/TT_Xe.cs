using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanXeMay
{
    public class TT_Xe
    {
        public string maXe { get; set; }
        public string tenXe { get; set; }
        public string loaiXe { get; set; }
        public string mauXe { get; set; }
        public string namSX { get; set; }
        public double Gia { get; set; }
        public string maNCC { get; set; }
        public TT_Xe(string maxe,string tenxe,string loaixe,string mauxe,string namsx,double gia,string mancc)
        {
            maXe = maxe;
            tenXe = tenxe;
            loaiXe = loaixe;
            mauXe = mauxe;
            namSX = namsx;
            Gia = gia;
            maNCC = mancc;
        }
    }
}
