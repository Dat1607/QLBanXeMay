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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        SqlConnection conn;

        private void grb_ChonXe_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormChuongTrinh a = new FormChuongTrinh();
            a.Show();
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO HOADON VALUES (@MAHD,@MAKH,@MANV,@MAXE,@SOLUONG,@GIATIEN,@THUEGTGT,@TONGTIEN)";
            SqlCommand cmd = new SqlCommand(sqlThem, conn);
            cmd.Parameters.AddWithValue("MAHD", txt_MaHD.Text);
            cmd.Parameters.AddWithValue("MAKH", txt_MaKH.Text);
            cmd.Parameters.AddWithValue("MANV", txt_MaNV.Text);
            cmd.Parameters.AddWithValue("MAXE", txt_MaXe.Text);
            cmd.Parameters.AddWithValue("SOLUONG", txt_SoLuong.Text);
            cmd.Parameters.AddWithValue("GIATIEN", txt_Gia.Text);
            cmd.Parameters.AddWithValue("THUEGTGT", txt_GTGT.Text);
            cmd.Parameters.AddWithValue("TONGTIEN", txt_ThanhTien.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["QLXEMAY"].ConnectionString.ToString();
            conn = new SqlConnection(constring);
            conn.Open();

            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSELECT = "select * from HOADON";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE HOADON SET MAHD = @MAHD, MAKH = @MAKH, MANV = @MANV, MAXE = @MAXE, SOLUONG = @SOLUONG, GIATIEN = @GIATIEN, THUEGTGT = @THUEGTGT, TONGTIEN = @TONGTIEN WHERE MAHD = @MAHD";
            SqlCommand cmd = new SqlCommand(sqlSua, conn);
            cmd.Parameters.AddWithValue("MAHD", txt_MaHD.Text);
            cmd.Parameters.AddWithValue("MAKH", txt_MaKH.Text);
            cmd.Parameters.AddWithValue("MANV", txt_MaNV.Text);
            cmd.Parameters.AddWithValue("MAXE", txt_MaXe.Text);
            cmd.Parameters.AddWithValue("SOLUONG", int.Parse(txt_SoLuong.Text));
            cmd.Parameters.AddWithValue("GIATIEN", double.Parse(txt_Gia.Text));
            cmd.Parameters.AddWithValue("THUEGTGT", double.Parse(txt_GTGT.Text));
            cmd.Parameters.AddWithValue("TONGTIEN", double.Parse(txt_ThanhTien.Text));

            cmd.ExecuteNonQuery();
            Hienthi();  
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM HOADON WHERE MAHD = @MAHD";
            SqlCommand cmd = new SqlCommand(sqlXoa, conn);
            cmd.Parameters.AddWithValue("MAHD", txt_MaHD.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_SoLuong.Text);
            double b = double.Parse(txt_Gia.Text);
            double c = double.Parse(txt_GTGT.Text);
            TinhToan t = new TinhToan(a, b, c);
            txt_ThanhTien.Text = t.ThanhTien().ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            txt_MaHD.Text = dataGridView1.Rows[e.RowIndex].Cells["MAHD"].FormattedValue.ToString();
            txt_MaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MAKH"].FormattedValue.ToString();
            txt_MaNV.Text = dataGridView1.Rows[e.RowIndex].Cells["MANV"].FormattedValue.ToString();
            txt_MaXe.Text = dataGridView1.Rows[e.RowIndex].Cells["MAXE"].FormattedValue.ToString();
            txt_SoLuong.Text = dataGridView1.Rows[e.RowIndex].Cells["SOLUONG"].FormattedValue.ToString();
            txt_Gia.Text = dataGridView1.Rows[e.RowIndex].Cells["GIATIEN"].FormattedValue.ToString();
            txt_GTGT.Text = dataGridView1.Rows[e.RowIndex].Cells["THUEGTGT"].FormattedValue.ToString();
            txt_ThanhTien.Text = dataGridView1.Rows[e.RowIndex].Cells["TONGTIEN"].FormattedValue.ToString();
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            this.Close();
            THONGKE a = new THONGKE();
            a.Show();
        }
    }
}
