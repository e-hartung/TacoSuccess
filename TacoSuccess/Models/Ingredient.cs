using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TacoSuccess.Models
{
    public class Ingredient
    {
        public int ingredientsID { get; set; }
        public int vendorID { get; set; }
        public string ingredientsCode { get; set; }
        public string ingredientsName { get; set; }
        public int qtyOnHand { get; set; }
        public DateTime dateAdded { get; set; }
        public decimal markupPrice { get; set; }
        public decimal cost { get; set; }
    }
}