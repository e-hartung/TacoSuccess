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

        public decimal tax;
        public decimal total;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            tse = new tacosuccessv2Entities();
            
            decimal.TryParse(Session["tax"].ToString(), out tax);
            decimal.TryParse(Session["grandTotal"].ToString(), out total);

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
                tse.SaveChanges();

                int addressID = address.addressID;


                Random rnd = new Random();
                order order = new order
                {
                    stationID = rnd.Next(1, 5),
                    orderDate = DateTime.Today,
                    taxAmount = tax,
                    cardType = GetCardType(txtBxCardNumber.Text),
                    cardNumber = txtBxCardNumber.Text,
                    cardExpress = txtBxCVV2.Text,
                    billingAddressID = addressID
                };

                tse.orders.Add(order);
                tse.SaveChanges();

                int orderID = order.orderID;


                orderdetail orderDetail = new orderdetail
                {
                    orderID = orderID,
                    orderPrice = total
                };

                tse.orderdetails.Add(orderDetail);
                tse.SaveChanges();

                Session.Clear();
                Response.Redirect("~/Confirmation.aspx");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Landing.aspx");
        }

        public int GetCardType(string cardNumber)
        {
            // using value of start of card number as the card type
            // 3 = amex
            // 4 = visa
            // 5 = mastercard
            // 6 = discover
            string firstNumber = cardNumber.Substring(0, 1);
            int firstNum;
            int.TryParse(firstNumber, out firstNum);
            return firstNum;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart.aspx");
        }
    }
}