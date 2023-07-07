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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void lbl_maNCC_Click(object sender, EventArgs e)
        {

        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
            FormChuongTrinh a = new FormChuongTrinh();
            a.Show();
        }

        private void grp_NCC_Enter(object sender, EventArgs e)
        {

        }

        private void txt_CMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO NHANVIEN VALUES (@MANV,@TENNV,@GIOITINH,@DIACHI,@CMND,@SDT,@CHUCVU,@NGAYSINH)";
            SqlCommand cmd = new SqlCommand(sqlThem, conn);
            cmd.Parameters.AddWithValue("MANV", txt_MaNV.Text);
            cmd.Parameters.AddWithValue("TENNV", txt_TenNV.Text);
            cmd.Parameters.AddWithValue("GIOITINH", txt_GioiTinh.Text);
            cmd.Parameters.AddWithValue("DIACHI", txt_DiaChi.Text);
            cmd.Parameters.AddWithValue("CMND", txt_CMND.Text);
            cmd.Parameters.AddWithValue("SDT", txt_SDT.Text);
            cmd.Parameters.AddWithValue("CHUCVU", txt_ChucVu.Text);
            cmd.Parameters.AddWithValue("NGAYSINH", txt_NgaySinh.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE NHANVIEN SET MANV = @MANV, TENNV = @TENNV, GIOITINH = @GIOITINH, DIACHI = @DIACHI, CMND = @CMND, SDT = @SDT, CHUCVU = @CHUCVU, NGAYSINH = @NGAYSINH WHERE MANV = @MANV";
            SqlCommand cmd = new SqlCommand(sqlSua, conn);
            cmd.Parameters.AddWithValue("MANV", txt_MaNV.Text);
            cmd.Parameters.AddWithValue("TENNV", txt_TenNV.Text);
            cmd.Parameters.AddWithValue("GIOITINH", txt_GioiTinh.Text);
            cmd.Parameters.AddWithValue("DIACHI", txt_DiaChi.Text);
            cmd.Parameters.AddWithValue("CMND", txt_CMND.Text);
            cmd.Parameters.AddWithValue("SDT", txt_SDT.Text);
            cmd.Parameters.AddWithValue("CHUCVU", txt_ChucVu.Text);
            cmd.Parameters.AddWithValue("NGAYSINH", txt_NgaySinh.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM NHANVIEN WHERE MANV = @MANV";
            SqlCommand cmd = new SqlCommand(sqlXoa, conn);
            cmd.Parameters.AddWithValue("MANV", txt_MaNV.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSELECT = "select * from NHANVIEN";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["QLXEMAY"].ConnectionString.ToString();
            conn = new SqlConnection(constring);
            conn.Open();
            Hienthi();
        }

        private void NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            txt_MaNV.Text = dataGridView1.Rows[e.RowIndex].Cells["MANV"].FormattedValue.ToString();
            txt_TenNV.Text = dataGridView1.Rows[e.RowIndex].Cells["TENNV"].FormattedValue.ToString();
            txt_GioiTinh.Text = dataGridView1.Rows[e.RowIndex].Cells["GIOITINH"].FormattedValue.ToString();
            txt_DiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DIACHI"].FormattedValue.ToString();
            txt_CMND.Text = dataGridView1.Rows[e.RowIndex].Cells["CMND"].FormattedValue.ToString();
            txt_SDT.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT"].FormattedValue.ToString();
            txt_ChucVu.Text = dataGridView1.Rows[e.RowIndex].Cells["CHUCVU"].FormattedValue.ToString();
            txt_NgaySinh.Text = dataGridView1.Rows[e.RowIndex].Cells["NGAYSINH"].FormattedValue.ToString();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sqlTim = "SELECT * FROM NHANVIEN WHERE MANV LIKE '%" + txt_TimKiem.Text.Trim() + "%' OR TENNV LIKE '%" + txt_TimKiem.Text.Trim() + "%' OR GIOITINH LIKE '%" + txt_TimKiem.Text + "%'";
            SqlCommand cmd = new SqlCommand(sqlTim, conn);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
