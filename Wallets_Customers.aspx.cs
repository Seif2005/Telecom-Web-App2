using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Telecom_Web_App.Helpers;
namespace Telecom_Web_App
{
    public partial class Wallets_Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable data = GetData("Select * from CustomerWallet");
                Session["GridData"] = data;
                Response.Redirect("/Result.aspx");

            }
        }
    }
}