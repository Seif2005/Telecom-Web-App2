using System.Data.SqlClient;
using System.Data;
using System;
using System.Web.Configuration;
namespace Telecom_Web_App
{
    public class Helpers
    {
        public static DataTable GetData(String sqlLine)
        {
            DataTable customerData = new DataTable();
            string connStr = WebConfigurationManager.ConnectionStrings["dbConnection"].ToString();

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();

                string sql = sqlLine; // Use the complete view name

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(customerData);
                    }
                }
            }

            return customerData;
        }
    }
}


