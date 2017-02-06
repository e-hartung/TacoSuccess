
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TacoSuccess.Models
{
    public class CartItem
    {
        public Entree Entree { get; set; }
        public int Quantity { get; set; }

        public CartItem() { }

        public CartItem(Entree entree, int quantity)
        {
            this.Entree = entree;
            this.Quantity = quantity;
        }
    }
}