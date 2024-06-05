using Project_PSD.Models;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views
{
    public partial class generalHomePage : System.Web.UI.Page
    {
        RaisoRepository repo = new RaisoRepository();
        RAisoEntities1 db = new RAisoEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<MsStationery> stationeries = (from repo in RaisoRepository.GetStationeries() select repo).ToList();

            StationeryGridView.DataSource = stationeries;

            StationeryGridView.DataBind();
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LogInPage.aspx");
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Guest/guestHomePage.aspx");
        }
    }
}