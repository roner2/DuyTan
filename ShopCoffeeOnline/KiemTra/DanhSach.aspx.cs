using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KiemTra.App_Code;

namespace KiemTra
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        XULYDULIEU xuly;
        protected void Page_Load(object sender, EventArgs e)
        {
            xuly = new XULYDULIEU(this.Page);
            String SQL = "select * from DOUONG";
            if (Request.QueryString.Get("MADANHMUC") != null)
            {
                string IDDM = Request.QueryString.Get("MADANHMUC");
                SQL += " where MADANHMUC =" + IDDM;
            }
            this.DataList1.DataSource = xuly.bang(SQL);
            this.DataList1.DataBind();
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}