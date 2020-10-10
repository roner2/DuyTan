using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLySinhVien_1
{
    public partial class frm_SinhVien : Form
    {
        public frm_SinhVien()
        {
            InitializeComponent();
        }

        private void pic_Hinh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openHinh = new OpenFileDialog();
                openHinh.Title = "Moi ban nhap hinh";
                openHinh.Filter = "JPG|*.jpg|PNG|*.png|tat ca|*.*";
                if (openHinh.ShowDialog() == DialogResult.OK)
                    pic_Hinh.Image = Image.FromFile(openHinh.FileName);
            }
            catch(Exception)
            {
                MessageBox.Show("sai");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
