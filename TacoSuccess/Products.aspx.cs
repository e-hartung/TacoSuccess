using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TacoSuccess.Models;

namespace TacoSuccess
{
    public partial class Products : System.Web.UI.Page
    {
        tacosuccessv2Entities tse;
        public int categoryID;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            tse = new tacosuccessv2Entities();

            int.TryParse(Request.QueryString["category"], out categoryID); // example url format: /Products.aspx?category=1000

            if (!IsPostBack)
            {
                var entreeQuery = from en in tse.entrees
                                  where en.categoryID == categoryID
                                  select en;

                dtlProducts.DataSource = entreeQuery.ToList();
                dtlProducts.DataBind();

                // shows cart button if cart contains items
                /*if (Session["order"] != null)
                {
                    btnCart.Visible = true;
                }*/
            }
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart.aspx");
        }
    }
}