using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TacoSuccess
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

      

        protected void btnClearOrder_Click(object sender, EventArgs e)
        {
           // Response.Redirect("~/Products.aspx");
           //Stay on same page, but clear cart.
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {

        }

        protected void btnRemoveItem_Click(object sender, EventArgs e)
        {

        }

        protected void btnContinueOrdering_Click(object sender, EventArgs e)
        {

        }
    }
}