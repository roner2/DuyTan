using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KiemTra.App_Code;

namespace KiemTra
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        XULYDULIEU xuly;
        protected void Page_Load(object sender, EventArgs e)
        {
            xuly = new XULYDULIEU(this.Page);
            String SQL = "select * from DOUONG";
            if (Request.QueryString.Get("MADOUONG") != null)
            {
                string IDSP = Request.QueryString.Get("MADOUONG");
                SQL += " where MADOUONG =" + IDSP;
                DataTable tb = xuly.bang(SQL);
                this.Repeater2.DataSource = tb;
                this.Repeater2.DataBind();

                //int SoLuong = Convert.ToInt32(tb.Rows[0]["SoLuong"].ToString());
                //for (int i = 1; i <= SoLuong; i++)
                //    drl_SoLuong.Items.Add(i.ToString());
            }
        }
        
        protected void btn_ThemGioHang_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (Session["gio" == null])
            {
                dt = taoGio();
            }
        }

        protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

    }
}