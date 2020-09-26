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
        frm_Bac bac = new frm_Bac();
        private void btn_bat_Click(object sender, EventArgs e)
        {            
            int cout = Convert.ToInt32(txt_bac.Text);
            MessageBox.Show(cout.ToString());
            for (int i=1;i<= cout; i++)
            {
                addNewTextBox(i);
                //addNewLabel(i);
                a++;                
            }
            bac.Show();
            this.Hide();
        }
        public System.Windows.Forms.TextBox addNewTextBox(int number)
        {            
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            bac.Controls.Add(txt);
            if (number <= 10)
            {             
                txt.Top = number * 40;
                txt.Left = 50;                
            }
            else if(number <= 20)
            {
                if(number ==20)
                    txt.Top = 10 * 40;
                else 
                    txt.Top = number % 10 * 40;
                txt.Left = 250;
            }
            else
            {
                if (number == 30)
                    txt.Top = 10 * 40;
                else
                    txt.Top = number % 10 * 40;
                txt.Left = 450;
            }
            txt.Name = "txt_" + number.ToString();
            txt.Text = "txt_" + number.ToString();
            return txt;
        }
        //public System.Windows.Forms.Label addNewLabel()
        //{
        //    System.Windows.Forms.Label lb = new System.Windows.Forms.Label();
        //    bac.Controls.Add(lb);
        //    lb.Top = a * 28 + 1;
        //    lb.Left = 25;
        //    lb.Name = "lb_" + this.a.ToString();
        //    lb.Text = "lb_" + this.a.ToString();
        //    return lb;
        //}
    }
}
