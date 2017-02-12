using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp
{
    class DisconnectionHelper
    {
        // fields
        private string con = GetConnectionString();
        private string query = GetQueryString();
        

        // methods
        public static DataSet GetDisconnectedResult(string connection, string query)
        {
            using (SqlConnection sqlcon = new SqlConnection(connection))
            {
                // BEGIN HERE AGAIN!!
                DataSet ds = new DataSet();
                SqlCommand command = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                return ds;
            }
        }

        public static string GetConnectionString()
        {
            return "Data Source=myinstancedemo.chppvnuzl4vk.us-east-1.rds.amazonaws.com,1433; Initial Catalog=RegistrationAppDB;Persist Security Info=True;User ID=stephenkirkland;Password=12345678;Encyrpt=False";
        }

        public static string GetQueryString()
        {
            return "SELECT * FROM [User].Student;";
        }
    }
}
