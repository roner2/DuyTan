using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QLyBanHang
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            DataTable tbLop = new DataTable();
            DataColumn clMaLop = new DataColumn("maLop", typeof(int));
            tbLop.Columns.Add(clMaLop);
            tbLop.Columns.Add("TenLop", typeof(string));
            DataRow rowLop = tbLop.NewRow();
            rowLop[0] = 1;
            rowLop[1] = "IS382E";
            tbLop.Rows.Add(rowLop);
            ds.Tables.Add(tbLop);

            DataTable tbSV = new DataTable();
            tbSV.Columns.Add("MaSV", typeof(int));
            tbSV.Columns.Add("HoTen");
            tbSV.Columns.Add("MaLop", typeof(int));
            DataRow rowSV = tbSV.NewRow();
            rowSV[0] = 1;
            rowSV[1] = "Nguyen Van A";
            rowSV[2] = 1;
            tbSV.Rows.Add(rowSV);
            rowSV = tbSV.NewRow();
            rowSV[0] = 2;
            rowSV[1] = "Nguyen Van Teo";
            rowSV[2] = 1;
            tbSV.Rows.Add(rowSV);
            ds.Tables.Add(tbSV);

            DataRelation RD = new DataRelation("tbLop_tbSV", ds.Tables[0].Columns["MaLop"], ds.Tables[1].Columns["MaLop"]);
            ds.Relations.Add(RD);
            this.GridView1.DataSource = ds.Tables[1];
            this.GridView1.DataBind();
        }

        protected void btn_button1_Click(object sender, EventArgs e)
        {

        }
    }
}