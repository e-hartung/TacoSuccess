using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TacoSuccess.Models
{
    public class Entree
    {
        public int entreeID { get; set; }
        public int itemID { get; set; }
        public int ingredientsID { get; set; }
        public string entreeName { get; set; }
        public string description { get; set; }
        public decimal entreePrice { get; set; }
    }
}