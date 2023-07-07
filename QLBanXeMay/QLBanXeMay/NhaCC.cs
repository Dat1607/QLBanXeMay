using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanXeMay
{
    public class NhaCC
    {
        public string MANCC { get; set; }
        public string TENNCC { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }

       
        public NhaCC(string maNCC,string tenNCC, string diaChi, string sdt)
        {
            MANCC = maNCC;
            TENNCC = tenNCC;
            DIACHI = diaChi;
            SDT = sdt;
        }
    }
}
