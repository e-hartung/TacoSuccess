using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TacoSuccess.Models;

namespace TacoSuccess
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             foreach (object cartItem in Session)
             {
                CartItem c = (CartItem) cartItem;
                BulletedList bList = new BulletedList();
                bList.DataSource = c.selectedIngredients;
                bList.DataBind();
                //I'm working on this
             }
           
        }

      

      

        protected void btnClearOrder_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Cart.aspx");
      
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