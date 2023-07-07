using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QLBanXeMay
{
    public partial class FormChuongTrinh : Form
    {
        bool isThoat = true;
        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            DangNhap a = new DangNhap();
            a.Show();
        }

        private void FormChuongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinNCC a = new ThongTinNCC();
            a.Show();
            this.Hide();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien a = new NhanVien();
            a.Show();
            this.Hide();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinXe a = new ThongTinXe();
            a.Show();
            this.Hide();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang a = new KhachHang();
            a.Show();
            this.Hide();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon a = new HoaDon();
            a.Show();
            this.Hide();
        }
        void PhanQuyen()
        {
            switch (ToanCuc.TaiKhoan.Loaitk)
            {
                case TaiKhoan_MatKhau.LoaiTK.user:
                    nhàCungCấpToolStripMenuItem.Enabled = nhânViênToolStripMenuItem.Enabled = danhSáchToolStripMenuItem.Enabled = false;
                    break;
                case TaiKhoan_MatKhau.LoaiTK.nhanvien:
                    hóaĐơnToolStripMenuItem.Enabled = kháchHàngToolStripMenuItem.Enabled = false;
                    break;

            }
            lbl_LoaiTK.Text = ToanCuc.TaiKhoan.TenHienThi;
        }

        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        private void chiTiếtHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietHD a = new ChiTietHD();
            a.Show();
            this.Hide();
        }
    }
}
