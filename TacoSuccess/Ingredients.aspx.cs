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
            //I'm going to put a variable here to get the entree
            // Entree entree = ???
            //Then  I'll make a new cartItem object
            //CartItem cartItem = new CartItem(entree);
            int count = DataList1.Items.Count;
            for (int i = 0; i < count; i++)
            {
                TextBox txtBx = DataList1.Items[i].FindControl("txtBxIngredientQuantity") as TextBox;
                if (txtBx.Text == "" || txtBx.Text == "0")
                    continue; 
                int quantity = Convert.ToInt32(txtBx.Text);
                // add ingredient to list if not part of BOM.
                
                //cartItem.AddSelectedIngredient(/*parameter of type Ingredient*/, quantity);
            }
           // Session["cart"] = cartItem;
       
            Response.Redirect("~/Cart.aspx");
        }
    }
}