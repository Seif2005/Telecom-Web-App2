using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Web_App
{
    public partial class CustomerOptions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void viewBenefitsClick(object sender, EventArgs e)
        {
            Response.Redirect("ActiveBenefits.aspx");
        }

        protected void ticketsNotResolvedClick(object sender, EventArgs e)
        {
            Response.Redirect("TicketsNotResolved.aspx");
        }

        protected void highestVoucherClick(object sender, EventArgs e)
        {
            Response.Redirect("HighestVoucher.aspx");
        }
    }
}