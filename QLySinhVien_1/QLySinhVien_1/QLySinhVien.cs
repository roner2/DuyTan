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
    public partial class QLySinhVien : Form
    {
        public QLySinhVien()
        {
            InitializeComponent();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_SinhVien"] == null)
            {
                frm_SinhVien sinhvien = new frm_SinhVien();
                sinhvien.MdiParent = this;
                sinhvien.Show();
            }
            else
                Application.OpenForms["frm_SinhVIen"].Activate();
        }

        private void toolcb_lop_Click(object sender, EventArgs e)
        {

        }
    }
}
