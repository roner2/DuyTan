using System;
using System.Windows.Forms;

namespace QLySinhVien
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_TenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string)this.txt_TenDN.Text.ToUpper() == "ADMIN" && (string)this.txt_MatKhau.Text == "123456")
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                QLySinhVien_Box_1 qLySinhVien = new QLySinhVien_Box_1();
                qLySinhVien.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu");
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.txt_TenDN.Clear();
            this.txt_MatKhau.Clear();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("ban muon thoat khong", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
                Application.Exit();
        }
    }
}
