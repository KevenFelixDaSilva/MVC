using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dev_Junior.Data
{
    public class ConecxaoSql
    {
        public void conecxaoSql(string[] args)
        {
            string connectionString = $"Data Source=DESKTOP-M3OQ381;Initial Catalog=keven;Integrated Security=True;";
         
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.CommandText = "SELECT * FROM Contacts";

                    SqlDataReader dr = cmd.ExecuteReader();


                    while (dr.Read())
                    {
                        string firstName = dr["FirstName"].ToString();
                        string lastName = dr["LastName"].ToString();

                        Console.WriteLine(firstName + " " + lastName);
                    }

                    dr.Close();
                }
            }
        }
    }
}
           
