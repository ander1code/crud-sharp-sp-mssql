using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace libCRUD
{
    public class Connection
    {
        public static SqlConnection Connect()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                string path = Directory.GetCurrentDirectory();
                
                conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "\\dbRegistration.mdf;Integrated Security=True";
                
                conn.Open();
                return conn;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
