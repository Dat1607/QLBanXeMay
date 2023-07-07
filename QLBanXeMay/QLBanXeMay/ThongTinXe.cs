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
    public partial class ThongTinXe : Form
    {
        public ThongTinXe()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void ThongTinXe_Load(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["QLXEMAY"].ConnectionString.ToString();
            conn = new SqlConnection(constring);
            conn.Open();

            // combobox loại xe
            cmb_LoaiXe.Items.Add("XE SỐ");
            cmb_LoaiXe.Items.Add("TAY GA");
            cmb_LoaiXe.Items.Add("TAY CÔN");
            // combobox màu xe
            cmb_MauXe.Items.Add("ĐEN");
            cmb_MauXe.Items.Add("TRẮNG");
            cmb_MauXe.Items.Add("ĐỎ");
            cmb_MauXe.Items.Add("XANH LÁ");
            cmb_MauXe.Items.Add("NÂU");
            cmb_MauXe.Items.Add("XANH ĐEN");
            cmb_MauXe.Items.Add("XÁM");
            cmb_MauXe.Items.Add("ĐEN NHÁM");
            cmb_MauXe.Items.Add("XANH DƯƠNG");
            // combobox mã ncc
            SqlDataAdapter da = new SqlDataAdapter("select * from NHACC", conn);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, cn là connection đến cơ sở dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_MaNCC.DisplayMember = "TENNCC";//Word là tên trường bạn muốn hiển thị trong combobox
            cmb_MaNCC.ValueMember = "MANCC";
            cmb_MaNCC.DataSource = dt;



            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSELECT = "select * from DSXE";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
            FormChuongTrinh a = new FormChuongTrinh();
            a.Show();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE DSXE SET MAXE = @MAXE, TENXE = @TENXE, LOAIXE = @LOAIXE, MAUXE = @MAUXE, NAMSANXUAT = @NAMSANXUAT, GIATIEN = @GIATIEN, MANCC = @MANCC WHERE MAXE = @MAXE";
            SqlCommand cmd = new SqlCommand(sqlSua, conn);
            cmd.Parameters.AddWithValue("MAXE", txt_MaXe.Text);
            cmd.Parameters.AddWithValue("TENXE", txt_TenXe.Text);
            cmd.Parameters.AddWithValue("LOAIXE", cmb_LoaiXe.Text);
            cmd.Parameters.AddWithValue("MAUXE", cmb_MauXe.Text);
            cmd.Parameters.AddWithValue("NAMSANXUAT", txt_NamSX.Text);
            cmd.Parameters.AddWithValue("GIATIEN", txt_Gia.Text);
            cmd.Parameters.AddWithValue("MANCC",cmb_MaNCC.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO DSXE VALUES (@MAXE,@TENXE,@LOAIXE,@MAUXE,@NAMSANXUAT,@GIATIEN,@MANCC)";
            SqlCommand cmd = new SqlCommand(sqlThem, conn);
            cmd.Parameters.AddWithValue("MAXE", txt_MaXe.Text);
            cmd.Parameters.AddWithValue("TENXE", txt_TenXe.Text);
            cmd.Parameters.AddWithValue("LOAIXE", cmb_LoaiXe.Text);
            cmd.Parameters.AddWithValue("MAUXE", cmb_MauXe.Text);
            cmd.Parameters.AddWithValue("NAMSANXUAT", txt_NamSX.Text);
            cmd.Parameters.AddWithValue("GIATIEN", txt_Gia.Text);
            cmd.Parameters.AddWithValue("MANCC", cmb_MaNCC.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM DSXE WHERE MAXE = @MAXE";
            SqlCommand cmd = new SqlCommand(sqlXoa, conn);
            cmd.Parameters.AddWithValue("MAXE", txt_MaXe.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void cmb_LoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sqlTim = "SELECT * FROM DSXE WHERE MAXE LIKE '%" + txt_TimKiem.Text.Trim() + "%' OR TENXE LIKE '%" + txt_TimKiem.Text.Trim() + "%' ";
            SqlCommand cmd = new SqlCommand(sqlTim, conn);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            txt_MaXe.Text = dataGridView1.Rows[e.RowIndex].Cells["MAXE"].FormattedValue.ToString();
            txt_TenXe.Text = dataGridView1.Rows[e.RowIndex].Cells["TENXE"].FormattedValue.ToString();
            cmb_LoaiXe.Text = dataGridView1.Rows[e.RowIndex].Cells["LOAIXE"].FormattedValue.ToString();
            cmb_MauXe.Text = dataGridView1.Rows[e.RowIndex].Cells["MAUXE"].FormattedValue.ToString();
            txt_NamSX.Text = dataGridView1.Rows[e.RowIndex].Cells["NAMSANXUAT"].FormattedValue.ToString();
            txt_Gia.Text = dataGridView1.Rows[e.RowIndex].Cells["GIATIEN"].FormattedValue.ToString();
            cmb_MaNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["MANCC"].FormattedValue.ToString();
        }
    }
}
