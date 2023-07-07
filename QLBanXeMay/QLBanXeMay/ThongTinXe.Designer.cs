
namespace QLBanXeMay
{
    partial class ThongTinXe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_LoaiXe = new System.Windows.Forms.ComboBox();
            this.cmb_MauXe = new System.Windows.Forms.ComboBox();
            this.cmb_MaNCC = new System.Windows.Forms.ComboBox();
            this.txt_NamSX = new System.Windows.Forms.TextBox();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.txt_TenXe = new System.Windows.Forms.TextBox();
            this.txt_MaXe = new System.Windows.Forms.TextBox();
            this.lbl_tenXe = new System.Windows.Forms.Label();
            this.lbl_MauXe = new System.Windows.Forms.Label();
            this.lbl_NamSX = new System.Windows.Forms.Label();
            this.lbl_LoaiXe = new System.Windows.Forms.Label();
            this.lbl_MaNCC = new System.Windows.Forms.Label();
            this.lbl_gia = new System.Windows.Forms.Label();
            this.lbl_maXe = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thông tin xe máy";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(685, 370);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 36);
            this.btn_Xoa.TabIndex = 13;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(529, 370);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 36);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(366, 370);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 36);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.Location = new System.Drawing.Point(211, 370);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(75, 36);
            this.btn_TroVe.TabIndex = 14;
            this.btn_TroVe.Text = "Trở về";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_LoaiXe);
            this.groupBox1.Controls.Add(this.cmb_MauXe);
            this.groupBox1.Controls.Add(this.cmb_MaNCC);
            this.groupBox1.Controls.Add(this.txt_NamSX);
            this.groupBox1.Controls.Add(this.txt_Gia);
            this.groupBox1.Controls.Add(this.txt_TenXe);
            this.groupBox1.Controls.Add(this.txt_MaXe);
            this.groupBox1.Controls.Add(this.lbl_tenXe);
            this.groupBox1.Controls.Add(this.lbl_MauXe);
            this.groupBox1.Controls.Add(this.lbl_NamSX);
            this.groupBox1.Controls.Add(this.lbl_LoaiXe);
            this.groupBox1.Controls.Add(this.lbl_MaNCC);
            this.groupBox1.Controls.Add(this.lbl_gia);
            this.groupBox1.Controls.Add(this.lbl_maXe);
            this.groupBox1.Location = new System.Drawing.Point(136, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 229);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DS xe máy";
            // 
            // cmb_LoaiXe
            // 
            this.cmb_LoaiXe.FormattingEnabled = true;
            this.cmb_LoaiXe.Location = new System.Drawing.Point(151, 136);
            this.cmb_LoaiXe.Name = "cmb_LoaiXe";
            this.cmb_LoaiXe.Size = new System.Drawing.Size(163, 24);
            this.cmb_LoaiXe.TabIndex = 3;
            this.cmb_LoaiXe.SelectedIndexChanged += new System.EventHandler(this.cmb_LoaiXe_SelectedIndexChanged);
            // 
            // cmb_MauXe
            // 
            this.cmb_MauXe.FormattingEnabled = true;
            this.cmb_MauXe.Location = new System.Drawing.Point(151, 179);
            this.cmb_MauXe.Name = "cmb_MauXe";
            this.cmb_MauXe.Size = new System.Drawing.Size(163, 24);
            this.cmb_MauXe.TabIndex = 4;
            // 
            // cmb_MaNCC
            // 
            this.cmb_MaNCC.FormattingEnabled = true;
            this.cmb_MaNCC.Location = new System.Drawing.Point(493, 136);
            this.cmb_MaNCC.Name = "cmb_MaNCC";
            this.cmb_MaNCC.Size = new System.Drawing.Size(163, 24);
            this.cmb_MaNCC.TabIndex = 7;
            // 
            // txt_NamSX
            // 
            this.txt_NamSX.Location = new System.Drawing.Point(497, 48);
            this.txt_NamSX.Name = "txt_NamSX";
            this.txt_NamSX.Size = new System.Drawing.Size(159, 22);
            this.txt_NamSX.TabIndex = 5;
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(497, 89);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(159, 22);
            this.txt_Gia.TabIndex = 6;
            // 
            // txt_TenXe
            // 
            this.txt_TenXe.Location = new System.Drawing.Point(151, 91);
            this.txt_TenXe.Name = "txt_TenXe";
            this.txt_TenXe.Size = new System.Drawing.Size(163, 22);
            this.txt_TenXe.TabIndex = 2;
            // 
            // txt_MaXe
            // 
            this.txt_MaXe.Location = new System.Drawing.Point(151, 48);
            this.txt_MaXe.Name = "txt_MaXe";
            this.txt_MaXe.Size = new System.Drawing.Size(163, 22);
            this.txt_MaXe.TabIndex = 1;
            // 
            // lbl_tenXe
            // 
            this.lbl_tenXe.AutoSize = true;
            this.lbl_tenXe.Location = new System.Drawing.Point(86, 94);
            this.lbl_tenXe.Name = "lbl_tenXe";
            this.lbl_tenXe.Size = new System.Drawing.Size(51, 17);
            this.lbl_tenXe.TabIndex = 30;
            this.lbl_tenXe.Text = "Tên xe";
            // 
            // lbl_MauXe
            // 
            this.lbl_MauXe.AutoSize = true;
            this.lbl_MauXe.Location = new System.Drawing.Point(84, 180);
            this.lbl_MauXe.Name = "lbl_MauXe";
            this.lbl_MauXe.Size = new System.Drawing.Size(53, 17);
            this.lbl_MauXe.TabIndex = 28;
            this.lbl_MauXe.Text = "Màu xe";
            // 
            // lbl_NamSX
            // 
            this.lbl_NamSX.AutoSize = true;
            this.lbl_NamSX.Location = new System.Drawing.Point(385, 48);
            this.lbl_NamSX.Name = "lbl_NamSX";
            this.lbl_NamSX.Size = new System.Drawing.Size(94, 17);
            this.lbl_NamSX.TabIndex = 26;
            this.lbl_NamSX.Text = "Năm sản xuất";
            // 
            // lbl_LoaiXe
            // 
            this.lbl_LoaiXe.AutoSize = true;
            this.lbl_LoaiXe.Location = new System.Drawing.Point(80, 139);
            this.lbl_LoaiXe.Name = "lbl_LoaiXe";
            this.lbl_LoaiXe.Size = new System.Drawing.Size(53, 17);
            this.lbl_LoaiXe.TabIndex = 29;
            this.lbl_LoaiXe.Text = "Loại xe";
            // 
            // lbl_MaNCC
            // 
            this.lbl_MaNCC.AutoSize = true;
            this.lbl_MaNCC.Location = new System.Drawing.Point(419, 135);
            this.lbl_MaNCC.Name = "lbl_MaNCC";
            this.lbl_MaNCC.Size = new System.Drawing.Size(59, 17);
            this.lbl_MaNCC.TabIndex = 27;
            this.lbl_MaNCC.Text = "Mã NCC";
            // 
            // lbl_gia
            // 
            this.lbl_gia.AutoSize = true;
            this.lbl_gia.Location = new System.Drawing.Point(449, 92);
            this.lbl_gia.Name = "lbl_gia";
            this.lbl_gia.Size = new System.Drawing.Size(30, 17);
            this.lbl_gia.TabIndex = 31;
            this.lbl_gia.Text = "Giá";
            // 
            // lbl_maXe
            // 
            this.lbl_maXe.AutoSize = true;
            this.lbl_maXe.Location = new System.Drawing.Point(92, 48);
            this.lbl_maXe.Name = "lbl_maXe";
            this.lbl_maXe.Size = new System.Drawing.Size(45, 17);
            this.lbl_maXe.TabIndex = 32;
            this.lbl_maXe.Text = "Mã xe";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(601, 74);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(135, 32);
            this.btn_TimKiem.TabIndex = 31;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(232, 74);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(354, 32);
            this.txt_TimKiem.TabIndex = 30;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tìm kiếm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 428);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 150);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ThongTinXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_TroVe);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinXe";
            this.Text = "ThongTinXe";
            this.Load += new System.EventHandler(this.ThongTinXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_LoaiXe;
        private System.Windows.Forms.ComboBox cmb_MauXe;
        private System.Windows.Forms.ComboBox cmb_MaNCC;
        private System.Windows.Forms.TextBox txt_NamSX;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.TextBox txt_TenXe;
        private System.Windows.Forms.TextBox txt_MaXe;
        private System.Windows.Forms.Label lbl_tenXe;
        private System.Windows.Forms.Label lbl_MauXe;
        private System.Windows.Forms.Label lbl_NamSX;
        private System.Windows.Forms.Label lbl_LoaiXe;
        private System.Windows.Forms.Label lbl_MaNCC;
        private System.Windows.Forms.Label lbl_gia;
        private System.Windows.Forms.Label lbl_maXe;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}