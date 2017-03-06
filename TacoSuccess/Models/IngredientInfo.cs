using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TacoSuccess.Models
{
    public class IngredientInfo
    {
        public int ingredientsID { get; set; }
        public string ingredientsName { get; set; }
        public int quantity { get; set; }

        public IngredientInfo(int ingredientsID, string ingredientsName, int quantity)
        {
            this.ingredientsID = ingredientsID;
            this.ingredientsName = ingredientsName;
            this.quantity = quantity;
        }
    }
}