using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace suBilet
{
    internal class SqlConfig
    {
        internal SqlConnection ToConnect() 
        { 
            // kendi DBconnection string'inizi kullanınız.
            SqlConnection connection = new SqlConnection(@"Data Source=MERT\SQLEXPRESS;Initial Catalog=buBilet;Integrated Security=True"); 
            connection.Open();
            return connection;
        }
    }
}
