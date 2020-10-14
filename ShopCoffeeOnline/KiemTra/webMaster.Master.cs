using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KiemTra.App_Code;


namespace KiemTra
{
    public partial class webMaster : System.Web.UI.MasterPage
    {
        XULYDULIEU xuly;
        protected void Page_Load(object sender, EventArgs e)
        {
            xuly = new XULYDULIEU(this.Page);
            String SQL = "select * from DANHMUC";
            this.Repeater1.DataSource = xuly.bang(SQL);
            this.Repeater1.DataBind();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}