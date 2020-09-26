using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;

namespace QLyBanHang.App_Code
{
    public class XULYDULIEU
    {
        SqlConnection con;
        public XULYDULIEU(Page p)
        {
            string path = p.Server.MapPath("App_Data/QLyBanHang.mdf");
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";
        }
        public void moKetNoi()
        {
            if (this.con.State == ConnectionState.Closed)
                this.con.Open();
        }
        public void dongKetNoi()
        {
            if (this.con.State == ConnectionState.Open)
                this.con.Close();
        }
        public DataTable bang(String SQL)
        {
            this.moKetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter ADP = new SqlDataAdapter(SQL, this.con);
            ADP.Fill(tb);
            this.dongKetNoi();
            return tb;
        }public int countDB(String SQL)
        {
            this.moKetNoi();
            SqlCommand ADP = new SqlCommand(SQL, this.con);
            int db = (int)ADP.ExecuteScalar();
            this.dongKetNoi();
            return db;
        }
        public int thucThiSQL(String SQL)
        {
            this.moKetNoi();
            SqlCommand CMD = new SqlCommand(SQL, this.con);
            int result = CMD.ExecuteNonQuery();
            this.dongKetNoi();
            return result;
        }
    }
}