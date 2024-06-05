using Project_PSD.Controller;
using Project_PSD.Handlers;
using Project_PSD.Models;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views.Admin
{
    public partial class InsertPage : System.Web.UI.Page
    {
        RaisoRepository repo = new RaisoRepository();
        StationeryController controller = new StationeryController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                var stationeryName = RaisoRepository.GetStationeries().Select(x => x.StationeryName).ToList();
                MsStationery.DataSource = stationeryName;
                insertForm.DataBind();
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            var stationeryContext = new StationeryController.StationeryContext();
            var stationeryModel = new StationeryController.StationeryModel
            {               
                StationeryName = nameBox.Text,
                StationeryPrice = Convert.ToInt32(priceBox.Text),
            };

            RaisoRepository.InsertStationeries(
                StationeryHandler.GenerateID(),
                stationeryModel.StationeryName, 
                stationeryModel.StationeryPrice
                );

            Response.Redirect("~/Views/Admin/HomePage.aspx");
        }
        private string GetValidatedNameInput(string fieldName, StationeryController.StationeryContext context)
        {
            return StationeryController.GetValidatedNameInput(fieldName, context);
        }
        private string GetValidatedPriceInput(string fieldprice, StationeryController.StationeryContext context)
        {
            return StationeryController.GetValidatedPriceInput(fieldprice, context);
        }
    }
}