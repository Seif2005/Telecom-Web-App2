using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Web_App
{
    public partial class AdminOptions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void All_customers_wallets(object sender, EventArgs e)
        {
            Response.Redirect("/Wallets_Customers.aspx");

        }
        protected void Customer_Profile_Active_Account(object sender, EventArgs e)
        {
            Response.Redirect("/CustomerProfileActive.aspx");

        }

    }
}