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
        tacosuccessv2Entities tse;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            tse = new tacosuccessv2Entities();
            // get cart item list from session
            List<CartItem> items = (List<CartItem>)Session["cart"];

            // bind items to data list
            DataList1.DataSource = items;
            DataList1.DataBind();

             // put ingredients into bulleted list
             //foreach (object cartItem in Session)
             //{
             //   CartItem c = (CartItem) cartItem;
             //   BulletedList bList = new BulletedList();
             //   bList.DataSource = c.selectedIngredients;
             //   bList.DataBind();
             //   //I'm working on this
             //}
             
        }

      

      

        protected void btnClearOrder_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Cart.aspx");
      
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            decimal subtotal = GetSubtotal();
            decimal totalTax = GetSalesTax(subtotal);
            decimal grandTotal = GetGrandTotal(subtotal, totalTax);
            Session["subtotal"] = subtotal;
            Session["tax"] = totalTax;
            Session["grandTotal"] = grandTotal;
            Response.Redirect("~/Checkout.aspx");
        }

        protected void btnRemoveItem_Click(object sender, EventArgs e)
        {

        }

        protected void btnContinueOrdering_Click(object sender, EventArgs e)
        {

        }

        protected decimal GetMarkupPrice(decimal cost, decimal markup)
        {
            decimal markupPrice;
            markupPrice = (cost * markup);
            return markupPrice;
        }

        protected decimal GetSubtotal()
        {
            decimal subtotal = 0;
            List<CartItem> items = (List<CartItem>)Session["cart"];
            foreach (var i in items)
            {
                foreach (SelectedIngredient si in i.selectedIngredients)
                {
                    ingredient ing = si.Ingredient;
                    subtotal += GetMarkupPrice(ing.cost.Value, (1 + (ing.markupPercent.Value/100)) * si.Quantity);
                }
                //subtotal += i.Entree.entreePrice; 
                // currently only calculating total value of item based on markup price of ingredients, entree price was throwing total way off
            }
            return subtotal;
        }

        protected decimal GetSalesTax(decimal subtotal)
        {
            decimal totalTax = 0;
            decimal salesTax = 0.08m;  // change this to the correct sales tax amount if needed
            totalTax = subtotal * salesTax;
            return totalTax;
        }

        protected decimal GetGrandTotal(decimal subtotal, decimal salestax)
        {
            decimal grandTotal = 0;
            grandTotal = subtotal * (1 + salestax);
            return grandTotal;
        }
    }
}