using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; // Replace with your data provider if needed
using System.Linq;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Telecom_Web_App.Helpers;

namespace Telecom_Web_App
{
    public partial class ServicePlan5Months : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string mobileNumber = Request.QueryString["MobileNo"];
                if (string.IsNullOrEmpty(mobileNumber))
                {
                    Response.Write("Mobile number is required.");
                    return;
                }
                DataTable data = GetData($"SELECT * FROM Subscribed_plans_5_Months('{mobileNumber}')");
                Session["GridData"] = data;
                Response.Redirect("/Result.aspx");

            }
        }

        
    }
}
