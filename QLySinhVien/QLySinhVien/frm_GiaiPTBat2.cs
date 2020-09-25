using System;
using System.Windows.Forms;

namespace QLySinhVien
{
    public partial class frm_GiaiPTBat2 : Form
    {
        public frm_GiaiPTBat2()
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
            if (txt_HeSoA.Text == "" || txt_HeSoB.Text == "" || txt_HeSoC.Text == "")
            {
                MessageBox.Show("Thieu gia tri A or B or C");                
            }
            else
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu");
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.txt_HeSoA.Clear();
            this.txt_HeSoB.Clear();
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
        private void PTBat2()
        {
            double a = double.Parse(this.txt_HeSoA.Text);
            double b = double.Parse(this.txt_HeSoB.Text);
            double c = double.Parse(this.txt_HeSoC.Text);
            double x1,x2
            double delta = b * b - 4 * a * c;
            if (delta < 0)
                return.LoaiN = 0;
            else if (delta == 0)
            {
                return.LoaiN = 1;
                return string x1 = -b / 2 * a;
            }
            else
            {
                cNghiem.LoaiN = 2;
                cNghiem.x1 = -b - Math.Sqrt(delta) / 2 * a;
                cNghiem.x2 = -b + Math.Sqrt(delta) / 2 * a;
            }
            return cNghiem;
        }
    }
    }
}
