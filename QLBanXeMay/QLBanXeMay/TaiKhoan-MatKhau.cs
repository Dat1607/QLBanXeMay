using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanXeMay
{
    public class TaiKhoan_MatKhau
    {
        private string tk;

        public string Tk 
        { 
            get => tk; 
            set => tk = value; 
        }
        public string Mk 
        { 
            get => mk; 
            set => mk = value; 
        }
        public enum LoaiTK
        {
            admin,
            nhanvien,
            user,
        }
        public LoaiTK Loaitk 
        { 
            get => loaitk; 
            set => loaitk = value;
        }

        public string TenHienThi
        {
            get
            {
                switch (loaitk)
                {
                    case LoaiTK.admin:
                        TenHienThi = "Admin";
                        break;
                    case LoaiTK.nhanvien:
                        TenHienThi = "Nhân viên 1";
                        break;
                    default:
                        TenHienThi = "Nhân viên 2";
                        break;

                }
                return tenHienThi;
            }
            set => tenHienThi = value;
        }
        private LoaiTK loaitk;
        private string tenHienThi;
        private string mk;
        public TaiKhoan_MatKhau(string tk,string mk,LoaiTK loaitk)
        {
            this.tk = tk;
            this.mk = mk;
            this.loaitk= loaitk;
        }
    }
}
