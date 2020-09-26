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
    public partial class frm_ListBox : Form
    {       
        Dictionary<string, string[]> ds ;
        public frm_ListBox()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            //try
            //{
                for (int i = lib_A.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lib_B.Items.Add(lib_A.SelectedItem);
                    lib_A.Items.Remove(lib_A.SelectedItem);
                }
            //}
            //catch (ArgumentNullException nex)
            //{
            //    MessageBox.Show("Bạn chưa chọn sinh viên nào!!!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeComponent();
            ds = new Dictionary<string, string[]>();
            ds.Add("Dang", new string[] { "Dang Van A", "Dang Van B" });
            ds.Add("Le", new string[] { "Le Van A" });
            ds.Add("Nguyen", new string[] { "Nguyen Van A", "Nguyen Van B" });
            ds.Add("Ly", new string[] { "Ly Van A", "Ly Van B" });
            ds.Add("Bao", new string[] { "Bao Van A" });
            ds.Add("Thi", new string[] { "Thi Van A", "Thi Van B" });
            lib_A.Items.Clear();
            foreach (var ho in ds[lib_A.SelectedItem.ToString()]s)
                comboBox1.Items.Add(ho);
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            foreach (string item in lib_A.Items)
                lib_B.Items.Add(item);
            lib_A.Items.Clear();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            foreach (string item in lib_B.Items)
                lib_A.Items.Add(item);
            lib_B.Items.Clear();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            //try
            //{
                for (int i = lib_B.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lib_A.Items.Add(lib_B.SelectedItems);
                    lib_B.Items.Remove(lib_B.SelectedItems);
                }
            //}
            //catch (ArgumentNullException nex)
            //{
            //    MessageBox.Show("Bạn chưa chọn sinh viên nào!!!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
