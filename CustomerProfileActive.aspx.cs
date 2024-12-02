using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Telecom_Web_App.Helpers;
namespace Telecom_Web_App
{
    public partial class CustomerProfileActive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable data = GetData("SELECT * FROM allCustomerAccounts");
            Session["GridData"] = data;
            Response.Redirect("/Result.aspx");
        }
    }
}