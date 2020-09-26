using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace QLyBanHang.App_Code
{
    public class XULYDULIEU
    {
        SqlConnection con;
        public XULYDULIEU()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nhatm\source\repos\DuyTan\QLyBanHang\QLyBanHang\App_Data\QLyBanHang.mdf;Integrated Security=True";
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