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
    public partial class frm_NhapBac : Form
    {
        public frm_NhapBac()
        {
            InitializeComponent();
        }
        int a = 1;
        string[] heso = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", };
        frm_Bac bac = new frm_Bac();
        private void btn_bat_Click(object sender, EventArgs e)
        {            
            int cout = Convert.ToInt32(txt_bac.Text);
            MessageBox.Show(cout.ToString());
            bac.ChangeLabel(this.txt_bac.Text);
            for (int i=0;i<= cout; i++)
            {               
                addNewTextBox();
                addNewLabel();
                a++;                
            }
            bac.Changelocation(a+100, a*45);
            bac.Show();
            this.Hide();
        }
        public System.Windows.Forms.TextBox addNewTextBox()
        {            
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            bac.Controls.Add(txt);                     
            txt.Top = (a+1) * 40;
            txt.Left = 80;                        
            txt.Name = "txt_" + this.heso[a];
            txt.Text = "txt_" + this.heso[a];
            return txt;
        }
        
        public System.Windows.Forms.Label addNewLabel()
        {
            System.Windows.Forms.Label lb = new System.Windows.Forms.Label();
            bac.Controls.Add(lb);
            lb.Top = (a + 1) * 40 + 1;
            lb.Left = 25;
            lb.Name = "lb_HS" + this.heso[a];
            lb.Text = "He So:" + this.heso[a];
            return lb;
        }
        private void txt_bac_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
