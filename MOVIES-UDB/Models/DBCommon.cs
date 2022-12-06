using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MOVIES_UDB.Models
{
    public class DBCommon
    {
        private static string Conn = @"Data Source=DESKTOP-NFDMETJ\SQLEXPRESS;Initial Catalog=Demo2;Integrated Security=True";

        public static IDbConnection Conexion()
        {
            return new SqlConnection(Conn);
        }
    }
}