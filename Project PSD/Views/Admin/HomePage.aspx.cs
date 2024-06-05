using Project_PSD.Controller;
using Project_PSD.Models;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views
{
    public partial class HomePage : System.Web.UI.Page
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

        protected void insertButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/InsertPage.aspx");

        }

        protected void StationeryGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = StationeryGridView.Rows[e.NewEditIndex];
            String id = row.Cells[0].Text.ToString(); 
            Response.Redirect("~/Views/Admin/UpdatePage.aspx?ID= "+id);

        }

        protected void StationeryGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = StationeryGridView.Rows[e.RowIndex];
            String id = row.Cells[0].Text.ToString();

            GetValidateDelete(Convert.ToInt32(id));

            StationeryGridView.DataSource = db.MsStationeries.ToList();
            StationeryGridView.DataBind();
        }
        private string GetValidateDelete(int StationeryId)
        {
            return StationeryController.GetValidateDelete(StationeryId);
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/HomePage.aspx");
        }

        protected void transactionButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/TransactionPage.aspx");
        }

        protected void profileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/UpdateProfile");
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}