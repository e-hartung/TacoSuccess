using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TacoSuccess.Models;

namespace TacoSuccess
{
    public partial class Checkout : System.Web.UI.Page
    {
        tacosuccessv2Entities tse;
        public int currentMonth = DateTime.Now.Month;
        public int currentYear = DateTime.Now.Year;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            tse = new tacosuccessv2Entities();

            if (!IsPostBack)
                for (int i = 1; i <= 12; i++)
                {
                    ddlMonth.Items.Add(i.ToString());
                }
                for (int y = currentYear; y < (currentYear + 10); y++)
                    ddlYear.Items.Add(y.ToString());
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblExpiredMessage.Text = "";
            int expMonth = Convert.ToInt32(ddlMonth.SelectedValue);
            int expYear = Convert.ToInt32(ddlYear.SelectedValue);

            if (expYear == currentYear && expMonth < currentMonth)
            {
                lblExpiredMessage.Text = "Expiration date can not be in the past";
            }
            else
            {
                // to do: add order to orders table in db
                // put custom build in custom build table
                // put billing info into address table

                // put address info into address object, add address object to address table
                address address = new address
                {
                    line1 = txtBxAddressLine1.Text,
                    line2 = txtBxAddressLine2.Text,
                    city = txtBxCity.Text,
                    state = txtBxState.Text,
                    zipCode = txtBxZip.Text,
                    phone = txtBxPhone.Text
                };

                tse.addresses.Add(address);


                // need to find how to add to one table to generate id for order and then get that id to add to orderdetail table
                order order = new order
                {
                    cardNumber = txtBxCardNumber.Text,
                    cardExpress = txtBxCVV2.Text
                };

                tse.orders.Add(order);


                orderdetail orderDetail = new orderdetail
                {

                };

                tse.orderdetails.Add(orderDetail);


                // submit changes to db
                tse.SaveChanges();

                Response.Redirect("~/Confirmation.aspx");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}