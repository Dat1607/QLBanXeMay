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
    public partial class ThongTinNCC : Form
    {
        public ThongTinNCC()
        {
            InitializeComponent();
            
        }
        SqlConnection conn;
        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
            FormChuongTrinh a = new FormChuongTrinh();
            a.Show();
        }

        private void ThongTinNCC_Load(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["QLXEMAY"].ConnectionString.ToString();
            conn = new SqlConnection(constring);
            conn.Open();
            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSELECT = "select * from NHACC";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO NHACC VALUES (@MANCC,@TENNCC,@DIACHI,@SDT)";
            SqlCommand cmd = new SqlCommand(sqlThem, conn);
            cmd.Parameters.AddWithValue("MANCC", txt_MaNCC.Text);
            cmd.Parameters.AddWithValue("TENNCC",txt_TenNCC.Text);
            cmd.Parameters.AddWithValue("DIACHI", txt_DiaChi.Text);
            cmd.Parameters.AddWithValue("SDT", txt_SDT.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM NHACC WHERE MANCC = @MANCC";
            SqlCommand cmd = new SqlCommand(sqlXoa, conn);
            cmd.Parameters.AddWithValue("MANCC", txt_MaNCC.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE NHACC SET MANCC = @MANCC, TENNCC = @TENNCC, DIACHI = @DIACHI, SDT = @SDT WHERE MANCC = @MANCC";
            SqlCommand cmd = new SqlCommand(sqlSua, conn);
            cmd.Parameters.AddWithValue("MANCC", txt_MaNCC.Text);
            cmd.Parameters.AddWithValue("TENNCC", txt_TenNCC.Text);
            cmd.Parameters.AddWithValue("DIACHI", txt_DiaChi.Text);
            cmd.Parameters.AddWithValue("SDT", txt_SDT.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void ThongTinNCC_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            txt_MaNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["MANCC"].FormattedValue.ToString();
            txt_TenNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["TENNCC"].FormattedValue.ToString();
            txt_DiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DIACHI"].FormattedValue.ToString();
            txt_SDT.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT"].FormattedValue.ToString();
        }
    }
}
