using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace NparkieApp
{
    class KoneksiDB
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new();
            Conn.ConnectionString = "Data Source=enpysekai;Initial Catalog=DB_NPARKIE;Integrated Security=True";
            return Conn;
        }
    }
}