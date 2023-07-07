using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanXeMay
{
    public class DSTaiKhoan
    {
        private static DSTaiKhoan instance;

        List<TaiKhoan_MatKhau> lstTaiKhoan;
        public static DSTaiKhoan Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new DSTaiKhoan();
                return instance;
            }
            set => instance = value;
        }

        public List<TaiKhoan_MatKhau> LstTaiKhoan 
        { 
            get => lstTaiKhoan; 
            set => lstTaiKhoan = value; 
        }

        DSTaiKhoan()
        {
            LstTaiKhoan = new List<TaiKhoan_MatKhau>();
            LstTaiKhoan.Add(new TaiKhoan_MatKhau("thanhdat@gmail.com", "123456",TaiKhoan_MatKhau.LoaiTK.nhanvien));
            LstTaiKhoan.Add(new TaiKhoan_MatKhau("tandung@gmail.com", "654321",TaiKhoan_MatKhau.LoaiTK.user));
            LstTaiKhoan.Add(new TaiKhoan_MatKhau("a", "1",TaiKhoan_MatKhau.LoaiTK.admin));
        }
    }
}
