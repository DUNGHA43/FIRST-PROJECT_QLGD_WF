using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect_Close_DB
    {
        string strcon = @"Data Source=.;Initial Catalog=QUANLYGIANGDAY;Integrated Security=True";
        protected SqlConnection sqlcon = null;

        public void connect_DB()
        {
            sqlcon = new SqlConnection(strcon);
            if (sqlcon == null)
            {
                sqlcon.Open();
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
        }

        public void Close_DB()
        {
            if (sqlcon != null || sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }
    }
}