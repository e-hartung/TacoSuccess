using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TacoSuccess.Models
{
    
    public class CartItem
    {
        public List<SelectedIngredient> selectedIngredients {get;set;}
         
        public entree Entree { get; set; }

        public CartItem() { }

        public CartItem(entree entree)
        {
            this.Entree = entree;
            selectedIngredients = new List<SelectedIngredient>();

        }

        /*public CartItem(object cartItem)
        {
            this.Entree = cartItem.Entree;
            selectedIngredients = new List<SelectedIngredient>();
            this.selectedIngredients = cartItem.selectedIngredients;
        }*/
        
        public void AddSelectedIngredient(ingredient ingredient, int quantity)
        {
            selectedIngredients.Add(new SelectedIngredient(ingredient, quantity));
        }
    }

    
}