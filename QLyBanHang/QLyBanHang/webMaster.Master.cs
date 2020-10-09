using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QLyBanHang.App_Code;

namespace QLyBanHang
{
    public partial class webMaster : System.Web.UI.MasterPage
    {
        XULYDULIEU xuly;
        protected void Page_Load(object sender, EventArgs e)
        {
            xuly = new XULYDULIEU(this.Page);
            String SQL = "select * from tbDANHMUC";
            this.Repeater1.DataSource = xuly.bang(SQL);
            this.Repeater1.DataBind();
        }
    }
}