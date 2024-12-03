using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Web_App
{
    public partial class HighestVoucher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String mobileNo = Session["mobileNo"] as string;
            string connStr = WebConfigurationManager.ConnectionStrings["dbConnection"].ToString();
            if (!IsPostBack)
            {
                //string query = $"Exec Ticket_Account_Customer @NID = (SELECT cp.nationalID FROM customer_account ca JOIN customer_profile cp ON ca.nationalID = cp.nationalID WHERE ca.mobileNo = {mobileNo})";
                //DataTable data = GetData(query);


                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    String nationalId;
                    connection.Open(); // (SELECT cp.nationalID FROM customer_account ca JOIN customer_profile cp ON ca.nationalID = cp.nationalID WHERE ca.mobileNo = @mobileNo)

                    //using (SqlCommand command1 = new SqlCommand("Exec Account_Highest_Voucher @mobile_num = @mobileNo", connection))
                    //{
                    //    command1.Parameters.AddWithValue("@mobileNo", mobileNo);
                    //    object result = command1.ExecuteScalar();

                    //    if (result != DBNull.Value && result != null)
                    //    {
                    //        // Cast the result to int first, then convert it to string
                    //        nationalId = ((int)result).ToString();
                    //    }
                    //    else
                    //    {
                    //        // Handle case where no data is returned
                    //        nationalId = string.Empty;
                    //    }
                    //}
                    using (SqlCommand command2 = new SqlCommand("Exec Account_Highest_Voucher @mobile_num = @mobileNo", connection))
                    {
                        command2.Parameters.AddWithValue("@mobileNo", mobileNo);
                        //data = (DataTable) command.ExecuteScalar();
                        using (SqlDataReader reader = command2.ExecuteReader())
                        {
                            data.Load(reader);
                        }
                    }
                    connection.Close();
                }


                Session["GridData"] = data;
                Response.Redirect("/Result.aspx");
            }
        }
    }
}