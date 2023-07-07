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
    public partial class ChiTietHD : Form
    {
        public ChiTietHD()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChiTietHD_Load(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["QLXEMAY"].ConnectionString.ToString();
            conn = new SqlConnection(constring);
            conn.Open();
            // load combobox hóa đơn
            //SqlDataAdapter da = new SqlDataAdapter("select * from HOADON", conn);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, cn là connection đến cơ sở dữ liệu
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //cb_MaHD.DisplayMember = "MAHD";//Word là tên trường bạn muốn hiển thị trong combobox
            //cb_MaHD.ValueMember = "MAHD";
            //cb_MaHD.DataSource = dt;
            // load combobox giá tiền
            SqlDataAdapter a = new SqlDataAdapter("select * from DSXE", conn);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, cn là connection đến cơ sở dữ liệu
            DataTable b = new DataTable();
            a.Fill(b);
            cb_Gia.DisplayMember = "TENXE";//Word là tên trường bạn muốn hiển thị trong combobox
            cb_Gia.ValueMember = "GIATIEN";
            cb_Gia.DataSource = b;

            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSELECT = "select MAHD,TENKH,GIATIEN,NGAYNHAP from CHITIETHOADON";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO CHITIETHOADON VALUES (@MAHD,@TENKH,@GIATIEN,@NGAYNHAP)";
            SqlCommand cmd = new SqlCommand(sqlThem, conn);
            cmd.Parameters.AddWithValue("MAHD", txt_MaHD.Text);
            cmd.Parameters.AddWithValue("TENKH", txt_TenKH.Text);
            cmd.Parameters.AddWithValue("NGAYNHAP", cb_Gia.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("GIATIEN", txt_NgayNhap.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM CHITIETHOADON WHERE MAHD = @MAHD";
            SqlCommand cmd = new SqlCommand(sqlXoa, conn);
            cmd.Parameters.AddWithValue("MAHD", txt_MaHD.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE CHITIETHOADON SET MAHD = @MAHD, TENKH = @TENKH, NGAYNHAP = @NGAYNHAP, GIATIEN = @GIATIEN WHERE MAHD = @MAHD";
            SqlCommand cmd = new SqlCommand(sqlSua, conn);
            cmd.Parameters.AddWithValue("MAHD", txt_MaHD.Text);
            cmd.Parameters.AddWithValue("TENKH", txt_TenKH.Text);
            cmd.Parameters.AddWithValue("GIATIEN", cb_Gia.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("NGAYNHAP", txt_NgayNhap.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void txt_TenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                dataGridView1.CurrentRow.Selected = true;
                txt_MaHD.Text = dataGridView1.Rows[e.RowIndex].Cells["MAHD"].FormattedValue.ToString();
                txt_TenKH.Text = dataGridView1.Rows[e.RowIndex].Cells["TENKH"].FormattedValue.ToString();
                cb_Gia.Text = dataGridView1.Rows[e.RowIndex].Cells["GIATIEN"].FormattedValue.ToString();
                txt_NgayNhap.Text = dataGridView1.Rows[e.RowIndex].Cells["NGAYNHAP"].FormattedValue.ToString();
            }
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
            FormChuongTrinh a = new FormChuongTrinh();
            a.Show();
        }
    }
}
