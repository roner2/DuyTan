using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
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

        protected void btn_GioHang_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (Session["gio"] == null)// neu chua co gio hang thi tao moi
            {
                dt = taoGio();
            }
            else// neu da co gio hang
            {
                dt = (DataTable)Session["gio"];
            }
            DataTable hangThem = xuly.bang("Select * from tbSANPHAM where IdSP="+ Request.QueryString.Get("IdSP"));
            themGio(hangThem, dt);
            Session["gio"] = dt;
        }
        private void themGio(DataTable hang, DataTable dt)
        {
            int vt = -1;
            for(int i=0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["IdSP"] + "" == hang.Rows[0]["IdSP"] + "")
                {
                    vt = i;
                    break;
                }
            }
            if (vt == -1)
            {
                DataRow dr = dt.NewRow();
                dr["IdSP"] = hang.Rows[0]["IdSP"];
                dr["TenSP"] = hang.Rows[0]["TenSP"];
                dr["SoLuong"] = 1;
                dr["DonGia"] = hang.Rows[0]["DonGia"];
                dr["ThanhTien"] = 0;
                dr["HinhAnh"] = hang.Rows[0]["H"];
                dr["GG"] = 0;
                dt.Rows.Add(dr);
            }
            else
            {
                dt.Rows[vt]["SoLuong"] = int.Parse(dt.Rows[vt]["SoLuong"].ToString()) + 1;
            }            
        }

        private DataTable taoGio()
        {
        } 
    }
}