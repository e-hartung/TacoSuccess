using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TacoSuccess.Models
{
    public class SelectedIngredient
    {
        public ingredient Ingredient { get; set; }
        public int Quantity { get; set; }
        public SelectedIngredient() { }
        public SelectedIngredient(ingredient ingredient, int quantity)
        {
            this.Ingredient = ingredient;
            this.Quantity = quantity;
        }
    }
}