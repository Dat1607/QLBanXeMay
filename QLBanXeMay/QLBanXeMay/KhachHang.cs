using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QLBanXeMay
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        SqlConnection conn;

        private void grp_NCC_Enter(object sender, EventArgs e)
        {

        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
            FormChuongTrinh a = new FormChuongTrinh();
            a.Show();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO KHACHHANG VALUES (@MAKH,@TENKH,@DIACHI,@GIOITINH,@SDT,@GHICHU)";
            SqlCommand cmd = new SqlCommand(sqlThem, conn);
            cmd.Parameters.AddWithValue("MAKH", txt_MaKH.Text);
            cmd.Parameters.AddWithValue("TENKH", txt_TenKH.Text);
            cmd.Parameters.AddWithValue("DIACHI", txt_DiaChi.Text);
            cmd.Parameters.AddWithValue("GIOITINH", txt_GioiTinh.Text);
            cmd.Parameters.AddWithValue("SDT", txt_SDT.Text);
            cmd.Parameters.AddWithValue("GHICHU", txt_GhiChu.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["QLXEMAY"].ConnectionString.ToString();
            conn = new SqlConnection(constring);
            conn.Open();

            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSELECT = "select * from KHACHHANG";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE KHACHHANG SET MAKH = @MAKH, TENKH = @TENKH, DIACHI = @DIACHI, GIOITINH = @GIOITINH, SDT = @SDT, GHICHU = @GHICHU WHERE MAKH = @MAKH";
            SqlCommand cmd = new SqlCommand(sqlSua, conn);
            cmd.Parameters.AddWithValue("MAKH", txt_MaKH.Text);
            cmd.Parameters.AddWithValue("TENKH", txt_TenKH.Text);
            cmd.Parameters.AddWithValue("DIACHI", txt_DiaChi.Text);
            cmd.Parameters.AddWithValue("GIOITINH", txt_GioiTinh.Text);
            cmd.Parameters.AddWithValue("SDT", txt_SDT.Text);
            cmd.Parameters.AddWithValue("GHICHU", txt_GhiChu.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM KHACHHANG WHERE MAKH = @MAKH";
            SqlCommand cmd = new SqlCommand(sqlXoa, conn);
            cmd.Parameters.AddWithValue("MAKH", txt_MaKH.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            txt_MaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MAKH"].FormattedValue.ToString();
            txt_TenKH.Text = dataGridView1.Rows[e.RowIndex].Cells["TENKH"].FormattedValue.ToString();
            txt_DiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DIACHI"].FormattedValue.ToString();
            txt_GioiTinh.Text = dataGridView1.Rows[e.RowIndex].Cells["GIOITINH"].FormattedValue.ToString();
            txt_SDT.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT"].FormattedValue.ToString();
            txt_GhiChu.Text = dataGridView1.Rows[e.RowIndex].Cells["GHICHU"].FormattedValue.ToString();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sqlTim = "SELECT * FROM KHACHHANG WHERE MAKH LIKE '%" + txt_TimKiem.Text.Trim() + "%' OR TENKH LIKE '%" + txt_TimKiem.Text.Trim() + "%'";
            SqlCommand cmd = new SqlCommand(sqlTim, conn);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
