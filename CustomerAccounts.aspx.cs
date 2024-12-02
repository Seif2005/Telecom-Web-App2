using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; // Replace with your data provider if needed
using System.Linq;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Web_App
{
    public partial class CustomerAccounts : System.Web.UI.Page
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["dbConnection"].ToString(); // Replace with your actual connection string

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable customerData = GetCustomerData();
                Session["GridData"] = customerData;
                Response.Redirect("/Result.aspx");

            }
        }

        private DataTable GetCustomerData()
        {
            DataTable customerData = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM CustomerWallet"; // Use the complete view name

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
