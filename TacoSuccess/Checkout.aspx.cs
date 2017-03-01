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
        public int currentMonth = DateTime.Now.Month;
        public int currentYear = DateTime.Now.Year;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
                for (int i = 1; i <= 12; i++)
                {
                    ddlMonth.Items.Add(i.ToString());
                }
                for (int y = currentYear; y < (currentYear + 10); y++)
                    ddlYear.Items.Add(y.ToString());
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblExpiredMessage.Text = "";
            int expMonth = Convert.ToInt32(ddlMonth.SelectedValue);
            int expYear = Convert.ToInt32(ddlYear.SelectedValue);

            if (expYear == currentYear && expMonth < currentMonth)
            {
                lblExpiredMessage.Text = "Expiration date can not be in the past";
            }
            else
            {
                // to do: add order to orders table in db

                Response.Redirect("~/Confirmation.aspx");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}