using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace QLyBanHang
{
    public partial class pageDanhMuc : System.Web.UI.Page
    {
        SqlConnection con;
        public void LoadDANHMUC()
        {
            con.Open();
            String SQL = "select * from tbDANHMUC";
            SqlDataAdapter ADP = new SqlDataAdapter(SQL, con);
            DataSet ds = new DataSet();
            ADP.Fill(ds);
            this.GridView1.DataSource = ds.Tables[0];
            this.GridView1.DataBind();
            con.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DuyTan\DuyTan\QLyBanHang\QLyBanHang\App_Data\QLyBanHang.mdf;Integrated Security=True";
            LoadDANHMUC();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.con.Open();          
            String SQL = " insert into tbDANHMUC(TenDM, IdDMCHA)"
                + " VALUES (N'" + txt_TenDM.Text + "'," + txt_MaDM.Text + ")";
            SqlCommand cmd = new SqlCommand(SQL, this.con);
            cmd.ExecuteNonQuery();
            this.con.Close();
            LoadDANHMUC();
        }

        protected void txt_TenDM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}