using Project_PSD.Models;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views.Customer
{
    public partial class customerHomePage : System.Web.UI.Page
    {
        RaisoRepository repo = new RaisoRepository();
        RAisoEntities1 db = new RAisoEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Views/Guest/guestHomePage.aspx");
            }

            List<MsStationery> stationeries = (from repo in RaisoRepository.GetStationeries() select repo).ToList();

            StationeryGridView.DataSource = stationeries;

            StationeryGridView.DataBind();
        }

        protected void StationeryGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/StationeryDetailPage.aspx");
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/customerHomePage.aspx");
        }

        protected void cartButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/CartPage.aspx");
        }

        protected void transactionButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/cust_TransactionPage.aspx");
        }

        protected void profileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/cust_UpdateProfile.aspx");
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}