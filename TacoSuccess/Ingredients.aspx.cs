using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TacoSuccess.Models;

namespace TacoSuccess
{
    public partial class Ingredients : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products.aspx");
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            Entree entree;
            // need to initialize entree
            CartItem cartItem = new CartItem(entree);
            int count = DataList1.Items.Count;
            for (int i = 0; i < count; i++)
            {
                int quantity = Convert.ToInt32(DataList1.Items[i].FindControl("txtBxIngredientQuantity") as TextBox);
                cartItem.AddSelectedIngredient(/*parameter of type Ingredient*/, quantity);
            }
            Session["cart"] = cartItem;
       
            Response.Redirect("~/Cart.aspx");
        }
    }
}