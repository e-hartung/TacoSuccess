﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TacoSuccess
{
    public partial class Landing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart.aspx");
        }

        /*protected void Button_Click(object sender, EventArgs e)
        {
            
           // Response.Redirect("~/Products.aspx");
        }*/

        /* protected void lbtnSignUp_Click(object sender, EventArgs e)
         {

         }*/
    }
}