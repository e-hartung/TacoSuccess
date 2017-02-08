using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TacoSuccess
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int thisYear = DateTime.Now.Year;
            if (!IsPostBack)
                for (int i = 1; i <= 12; i++)
                {
                    ddlMonth.Items.Add(i.ToString());
                }
                for (int y = thisYear; y < (thisYear + 10); y++)
                    ddlYear.Items.Add(y.ToString());
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // add order to orders table in db
            Response.Redirect("~/Confirmation.aspx");
        }
    }
}