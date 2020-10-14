using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            String ketnoi = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DuyTan\DuyTan\QLySinhVien_1\QLySinhVien_1\data\QLySinhVien.mdf; Integrated Security = True";
            SqlConnection conn = new SqlConnection(ketnoi);
            conn.Open();
            String SQL = "INSERT INTO SinhVien VALUES ('"+txt_MaSV+"',N'"+txt_TenSV+ "',N'"+txt_TenSV+"')"

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
