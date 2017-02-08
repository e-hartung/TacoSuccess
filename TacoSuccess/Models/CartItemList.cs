using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TacoSuccess.Models
{
    public class CartItemList
    {
        private List<CartItem> cartItems;
        public CartItemList()
        {
            cartItems = new List<CartItem>();
        }
        public int Count
        {
            get { return cartItems.Count; }
        }

        public decimal GetSubtotal()
        {
            decimal total = 0;
            foreach (CartItem item in cartItems)
            {
                foreach (SelectedIngredients i in item.selectedIngredients)
                {
                    total += (i.Ingredient.GetMarkupPrice() * i.Quantity);
                }
                total += item.Entree.entreePrice;
            }
            return total;
        }

        public decimal GetGrandTotal()
        {
            decimal total = 0;
            decimal salesTax = 0.08m;  // change this to the correct sales tax amount
            total = GetSubtotal() * (1 + salesTax);
            return total;
        }
    }
}