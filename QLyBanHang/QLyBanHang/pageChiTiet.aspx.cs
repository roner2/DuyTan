using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QLyBanHang.App_Code;

namespace QLyBanHang
{
    public partial class pageChiTiet : System.Web.UI.Page
    {
        XULYDULIEU xuly;
        protected void Page_Load(object sender, EventArgs e)
        {
            xuly = new XULYDULIEU(this.Page);
            String SQL = "select * from tbSANPHAM";
            if (Request.QueryString.Get("IdSP") != null)
            {
                string IDSP = Request.QueryString.Get("IdSP");
                SQL += " where IdSP =" + IDSP;
                DataTable tb = xuly.bang(SQL);
                this.Repeater2.DataSource = tb;
                this.Repeater2.DataBind();

                int SoLuong = Convert.ToInt32(tb.Rows[0]["SoLuong"].ToString());
                for (int i = 1; i <= SoLuong; i++)
                    drl_SoLuong.Items.Add(i.ToString());
            }
            
        }
    }
}