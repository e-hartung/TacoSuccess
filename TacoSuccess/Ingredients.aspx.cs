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
        public List<IngredientInfo> allChosenIngredients = new List<IngredientInfo>();
        public List<ingredient> everyIngredientRemaining = new List<ingredient>();
        public int entreeID;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            tse = new tacosuccessv2Entities();
            
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



                foreach (var i in recipeQuery)
                {
                    int id = i.ingredientsID;
                    string name = i.ingredientsName;
                    int qty = i.quantity;
                    allChosenIngredients.Add(new IngredientInfo(id, name, qty));
                }
                Session["ing"] = allChosenIngredients;
                dlIngredientsBuild.DataSource = allChosenIngredients;
                DataBind();

                foreach (var i in additionalIngredientQuery)
                {
                    everyIngredientRemaining.Add(i);
                }
                Session["rem"] = everyIngredientRemaining;
                dlIngredientsAdd.DataSource = everyIngredientRemaining;
                DataBind();
            }
        }

        public string GetIngredientName(string ingredientID)
        {
            int ingID;
            int.TryParse(ingredientID, out ingID);
            var nameQuery = from i in tse.ingredients
                            where i.ingredientsID == ingID
                            select i.ingredientsName;
            var nq = nameQuery.ToList();
            string name = nq[0];
            return name;
        }

        public int GetQuantity(string ingredientID)
        {
            int ingID;
            int.TryParse(ingredientID, out ingID);
            var quantityQuery = from r in tse.recipes
                                where r.ingredientsID == ingID
                                select r.quantity;
            int qty;
            int.TryParse(quantityQuery.ToString(), out qty);
            return qty;
        }

        public int GetIngredientID(string ingredientName)
        {
            var idQuery = from i in tse.ingredients
                          where i.ingredientsName == ingredientName
                          select i.ingredientsID;
            int ingID;
            int.TryParse(idQuery.ToString(), out ingID);
            return ingID;
        }

        public ingredient GetIngredient(string ingredientID)
        {
            int ingID;
            int.TryParse(ingredientID, out ingID);
            var ingQuery = from i in tse.ingredients
                           where i.ingredientsID == ingID
                           select i;
            var iq = ingQuery.ToList();
            ingredient ing = iq[0];
            return ing;
        }

        public entree GetEntree(int entreeID)
        {
            var entQuery = from e in tse.entrees
                           where e.entreeID == entreeID
                           select e;
            var eq = entQuery.ToList();
            entree ent = eq[0];
            return ent;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products.aspx");
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            // get entree
            entree entree = GetEntree(entreeID);

            // get list of ingredients
            allChosenIngredients = (List<IngredientInfo>)Session["ing"];

            // check if cartitemlist exists, create new list if one does not exist already
            if (Session["cart"] == null)
            {
                Session["cart"] = new List<CartItem>();
            }

            List<CartItem> items = (List<CartItem>)Session["cart"];

            // create new cart item
            CartItem cartItem = new CartItem(entree);

            // get each ingredient from list and create/add selected ingredient object to cart item
            foreach (var i in allChosenIngredients)
            {
                ingredient ing = GetIngredient(i.ingredientsID.ToString());
                int qty = i.quantity;
                cartItem.AddSelectedIngredient(ing, qty);
            }

            // add cart item to cart item list
            items.Add(cartItem);
            Session["cart"] = items;
            
            // can't get this to work right now
            //int count = dlIngredientsBuild.Items.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    TextBox txtBx = dlIngredientsBuild.Items[i].FindControl("txtBxIngredientQuantity") as TextBox;
            //    if (txtBx.Text == "" || txtBx.Text == "0")
            //        continue; 
            //    int quantity = Convert.ToInt32(txtBx.Text);
            //    // add ingredient to list if not part of BOM.
                
            //    //cartItem.AddSelectedIngredient(/*parameter of type Ingredient*/, quantity);
            //}

            Response.Redirect("~/Cart.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session["ing"] = "";
            Session["rem"] = "";
            Response.Redirect("~/Products.aspx");
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart.aspx");
        }
        
        protected void btnAddIngredient_Click(object sender, EventArgs e)
        {
            allChosenIngredients = (List<IngredientInfo>)Session["ing"];
            everyIngredientRemaining = (List<ingredient>)Session["rem"];

            Button btn = (Button)sender;
            string id = btn.CommandArgument;
            string name = GetIngredientName(id);
            int addID;
            int.TryParse(id, out addID);
            allChosenIngredients.Add(new IngredientInfo(addID, name, 1));
            dlIngredientsBuild.DataSource = allChosenIngredients;
            DataBind();

            // this doesn't work currently... need to remove ingredient from list when added to item
            ingredient ing = GetIngredient(id);
            everyIngredientRemaining.Remove(ing);
            dlIngredientsAdd.DataSource = everyIngredientRemaining;
            DataBind();
        }
    }
}