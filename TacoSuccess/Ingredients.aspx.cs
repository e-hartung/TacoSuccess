using System;
using System.Collections.Generic;
using System.Data;
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
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            

            // TO DO: for data sources, replace r.entreeID = 1 with session variable or whatever we use to pull selected entree id from menu page (currently using entree 1 for testing)
            SqlDataSource1.SelectCommand = "SELECT * FROM ingredients WHERE ingredientsID NOT IN (SELECT ingredientsID FROM recipe WHERE entreeID = 1)";
            SqlDataSource2.SelectCommand = "SELECT * FROM entree WHERE entreeID = 1";
            // SqlDataSource3.SelectParameters.Add("entreeID", "1");
            SqlDataSource3.SelectCommand = "SELECT * FROM recipe r JOIN ingredients i ON r.ingredientsID = i.ingredientsID WHERE r.entreeID = 1";

            // this gets entree name from entree table and assigns it to entree label
            DataView oDV = (System.Data.DataView)SqlDataSource2.Select(DataSourceSelectArguments.Empty);
            lblEntree.Text = oDV.Table.Rows[0].Field<string>(3);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products.aspx");
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products.aspx");
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart.aspx");
        }
    }
}