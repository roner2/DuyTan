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
                PTBat2();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.txt_HeSoA.Clear();
            this.txt_HeSoB.Clear();
            this.txt_HeSoC.Clear();
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
            float a = float.Parse(this.txt_HeSoA.Text);
            float b = float.Parse(this.txt_HeSoB.Text);            
            float c = float.Parse(this.txt_HeSoC.Text);
            float delta = (b / 2) * (b / 2) - a * c;
            MessageBox.Show("Phương trình nhập vào là:\n "+a+" x*x + "+b+"x + "+c+" = 0", "thong bao", MessageBoxButtons.YesNo,MessageBoxIcon.Question);          
            switch (delta < 0)
            {
                case true:
                    MessageBox.Show("Chương trình vô nghiệm");
                    this.txt_DapAn.Text = "Chương trình vô nghiệm";
                    break;
                case false:
                    switch (delta == 0)
                    {
                        case true:
                            float x = (-b / 2) / a;
                            MessageBox.Show("Phương trình có nghiệm kép x1 = x2 = "+ x);
                            this.txt_DapAn.Text = "Phương trình nhập vào là:\n " + a + " x* x +" + b + "x + " + c + " = 0" + "Phương trình có nghiệm kép x1 = x2 = " + x;
                            break;
                        default:
                            double x1 = 0;
                            double x2 = 0;
                            x1 = ((-b / 2) - Math.Sqrt(delta)) / a;
                            x2 = ((-b / 2) + Math.Sqrt(delta)) / a;
                            MessageBox.Show("Phương trình có 2 nghiệm phân biệt: " + "\nx1 = " + x1 + "\nx2 = " + x2);
                            this.txt_DapAn.Text = "Phương trình nhập vào là: "+a+" x* x +"+b+"x + "+c+" = 0" + "\nPhương trình có 2 nghiệm phân biệt: " + "\nx1 = " + x1 + "\nx2 = " + x2;
                            break;
                    }
                    break;
            }
        }
    }
}
