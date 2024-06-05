using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views.Customer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addToCartButton_Click(object sender, EventArgs e)
        {
            //Before redirect to cart page, add a validation first (See "6. Stationery Detail")
            Response.Redirect("~/Views/Customer/CartPage.aspx");
        }
    }
}