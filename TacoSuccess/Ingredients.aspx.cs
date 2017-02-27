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
        tacosuccessv2Entities tse;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            tse = new tacosuccessv2Entities();

            int entreeID;
            int.TryParse(Request.QueryString["entree"], out entreeID); // example url format: /Ingredients.aspx?entree=1000

            if (!IsPostBack)
            {
                var entreeNameQuery = from en in tse.entrees
                                      where en.entreeID == entreeID
                                      select en.entreeName;


                var ingredientQuery = from i in tse.ingredients
                                      orderby i.ingredientsID
                                      select i;


                var recipeQuery = from r in tse.recipes
                                  join i in tse.ingredients on r.ingredientsID equals i.ingredientsID
                                  where r.entreeID == entreeID
                                  orderby r.ingredientsID
                                  select new { r.ingredientsID, r.quantity, i.ingredientsName };


                var additionalIngredientQuery = from i in tse.ingredients
                                                where !(from r in tse.recipes where r.entreeID == entreeID select r.ingredientsID).Contains(i.ingredientsID)
                                                select i;



                // there has to be a better way to do this but this works for now
                var hmm = entreeNameQuery.ToList();
                lblEntreeName.Text = hmm[0];



                dlIngredientsBuild.DataSource = recipeQuery.ToList();
                DataBind();

                dlIngredientsAdd.DataSource = additionalIngredientQuery.ToList();
                DataBind();
            }
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
            int count = dlIngredientsBuild.Items.Count;
            for (int i = 0; i < count; i++)
            {
                TextBox txtBx = dlIngredientsBuild.Items[i].FindControl("txtBxIngredientQuantity") as TextBox;
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