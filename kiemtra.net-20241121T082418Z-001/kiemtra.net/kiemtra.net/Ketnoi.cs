﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra.net
{
    internal class Ketnoi
    {
        string Constr = @"Data Source=TIENCHUNGLOVEU\TIENCHUNG;Initial Catalog=MobileShop;Integrated Security=True";
        SqlConnection conn;
        public Ketnoi()
        {
            conn = new SqlConnection(Constr);
        }

        public DataSet LayDuLieu(string query)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public bool ThucThi(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
