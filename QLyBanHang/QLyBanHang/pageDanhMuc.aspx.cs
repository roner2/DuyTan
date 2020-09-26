using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using QLyBanHang.App_Code;

namespace QLyBanHang
{    
    public partial class pageDanhMuc : System.Web.UI.Page
    {
        XULYDULIEU xuLy;
        public void LoadDANHMUC()
        {
            String SQL = "select * from tbDANHMUC";            
            this.GridView1.DataSource = xuLy.bang(SQL);
            this.GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            xuLy = new XULYDULIEU();
            LoadDANHMUC();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {         
            String SQL = " insert into tbDANHMUC(TenDM, IdDMCHA)"
                + " VALUES (N'" + txt_TenDM.Text + "'," + txt_MaDM.Text + ")";
            int kq = this.xuLy.thucThiSQL(SQL);
            LoadDANHMUC();
        }

        protected void txt_TenDM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}