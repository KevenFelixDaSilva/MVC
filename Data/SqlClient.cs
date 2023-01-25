using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace dev_Junior
{
    public class SqlClient
    {
       
       
        private static string strConn { get; set; }
        private string Conn;

        SqlConnection conn = new SqlConnection(strConn); 
    
    }
    public string ConnectionString { get; set; }  
    using (SqlConnection connection = new SqlConnection(connectionString))  
    {  

        connection.Open();   
    }      
}
    

