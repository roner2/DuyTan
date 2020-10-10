using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QLyBanHang.App_Code;

namespace QLyBanHang
{
    public partial class pageDanhSachSanPham : System.Web.UI.Page
    {
        XULYDULIEU xuly;
        protected void Page_Load(object sender, EventArgs e)
        {
            xuly = new XULYDULIEU(this.Page);
            String SQL = "select * from tbSANPHAM";
            if(Request.QueryString.Get("IdDM")!= null)
            {
                string IDDM = Request.QueryString.Get("IdDm");
                SQL += " where IdDM =" + IDDM;
            }
            this.DataList1.DataSource = xuly.bang(SQL);
            this.DataList1.DataBind();
        }
    }
}