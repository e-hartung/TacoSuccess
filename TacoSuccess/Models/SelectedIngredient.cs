using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TacoSuccess.Models
{
    public class SelectedIngredient
    {
        public Ingredient Ingredient { get; set; }
        public int Quantity { get; set; }
        public SelectedIngredient() { }
        public SelectedIngredient(Ingredient ingredient, int quantity)
        {
            this.Ingredient = ingredient;
            this.Quantity = quantity;
        }
    }
}