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
    public partial class Shops : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable data = GetData("SELECT * FROM allShops");
                Session["GridData"] = data;
                Response.Redirect("/Result.aspx");

            }
        }

        
    }
}
