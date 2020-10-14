using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLySinhVien
{
    public partial class frm_Bac : Form
    {
        public frm_Bac()
        {
            InitializeComponent();
        }

        private void frm_Bac_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        public void ChangeLabel(string s)
        {
            lb_show.Text = this.lb_show.Text + s;
        }

        public void Changelocation(int a, int b)
        {
            btn_giai.Location = new Point(a, b);
            btn_exit.Location = new Point(a + 200, b);
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("ban muon thoat khong", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
                Application.Exit();
        }
    }
}
