using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLyBanHang
{
    public partial class ViewShop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session("gio");
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
    }
}