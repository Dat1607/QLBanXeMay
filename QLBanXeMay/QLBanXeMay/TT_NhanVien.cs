using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanXeMay
{
    public class TT_NhanVien
    {
        public string MANV { get; set; }
        public string TENNV { get; set; }
        public string GIOITINH { get; set; }
        public string DIACHI { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string CHUCVU { get; set; }
        public string NGAYSINH { get; set; }

        public TT_NhanVien(string maNV, string tenNV, string gioiTinh, string diChi, string cmnd, string sdt, string chucVu, string ngaySinh)
        {
            MANV = maNV;
            TENNV = tenNV;
            GIOITINH = gioiTinh;
            DIACHI = diChi;
            CMND = cmnd;
            SDT = sdt;
            CHUCVU = chucVu;
            NGAYSINH = ngaySinh;
        }
    }
}
