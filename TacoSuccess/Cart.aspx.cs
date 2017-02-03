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

        protected void btnStartOver_Click(object sender, EventArgs e)
        {
            //Some code for clearing the session here
            Response.Redirect("~/Products.aspx");
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            /*Message appears saying order was placed. I may use a timer.
             Sends order to employees. Goes back to products screen.*/ 
        }
    }
}