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
    }
}