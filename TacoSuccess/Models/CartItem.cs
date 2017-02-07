using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TacoSuccess.Models
{
    
    public class CartItem
    {

        private List<SelectedIngredients> selectedIngredients;
         
        public Entree Entree { get; set; }

        public CartItem() { }

        public CartItem(Entree entree)
        {
            this.Entree = entree;
            selectedIngredients = new List<SelectedIngredients>();
        }
        
        public void AddSelectedIngredient(Ingredient ingredient, int quantity)
        {
            selectedIngredients.Add(new SelectedIngredients(ingredient, quantity));
        }
    }

    
}