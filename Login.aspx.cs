using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Web_App
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LoginClick(object sender, EventArgs e)
        {
            

            string connStr = WebConfigurationManager.ConnectionStrings["dbConnection"].ToString();

            String mobile = txtMobileNo.Text;
            String pass = txtPassword.Text;
            //check if admin
            if (mobile == "admin"&&pass == "admin")
            {
                Response.Redirect("/AdminOptions.aspx");
            }
            //Response.Write(mobile + "<br/>");
            //Response.Write(pass + "<br/>");

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                //Response.Write("Connection successful<br />");

                using (SqlCommand command = new SqlCommand("SELECT dbo.AccountLoginValidation(@mobile_num, @pass)", conn))
                {
                    // Add the parameters required by the function
                    command.Parameters.AddWithValue("@mobile_num", mobile); // Replace with actual mobile number
                    command.Parameters.AddWithValue("@pass", pass); // Replace with actual password

                    // Execute the command and get the scalar value
                    object result = command.ExecuteScalar();
                    bool loginValid = (bool)result;
                    // Process the result
                    if (loginValid)
                    {
                        //creating Session
                        Session["mobileNo"] = mobile;
                        Response.Redirect("/Service5Months.aspx");
                    }
                    else
                    {
                        Response.Write("Invalid Login");
                    }
                    conn.Close();
                }
            }
        }
    }
}