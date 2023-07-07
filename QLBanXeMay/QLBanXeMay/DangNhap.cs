using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLBanXeMay
{
    public partial class DangNhap : Form
    {
        List<TaiKhoan_MatKhau> lstTaiKhoan = DSTaiKhoan.Instance.LstTaiKhoan;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(KiemTraDangNhap(txt_TaiKhoan.Text,txt_MatKhau.Text))
            {
                FormChuongTrinh f = new FormChuongTrinh();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi");
                txt_TaiKhoan.Focus();
            }    
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            Application.Exit();
        }
        bool KiemTraDangNhap(string tk,string mk)
        {
            for (int i = 0; i < lstTaiKhoan.Count; i++)
            {
                if (tk == lstTaiKhoan[i].Tk && mk == lstTaiKhoan[i].Mk)
                {
                    ToanCuc.TaiKhoan = lstTaiKhoan[i];
                    return true;
                }    
                
            }
            return false;
        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            txt_TaiKhoan.Text = txt_TaiKhoan.Text ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(txt_TaiKhoan.Text))
            {
                this.lbl_BaoLoi.Text = "Email hợp lệ!";
            }
            else
                this.lbl_BaoLoi.Text = "Email không hợp lệ!";

        }

        private void txt_MatKhau_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Bạn phải nhập mật khẩu");
            else
                this.errorProvider1.Clear();

        }

        private void txt_TaiKhoan_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Bạn phải nhập email");
            else
                this.errorProvider1.Clear();
        }
    }
}
