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
using static Project_PSD.Controller.StationeryController;

namespace Project_PSD.Views.Admin
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        RaisoRepository repo = new RaisoRepository();
        StationeryController controller = new StationeryController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                var stationeryName = RaisoRepository.GetStationeries().Select(x => x.StationeryName).ToList();
                MsStationery.DataSource = stationeryName;
                updateForm.DataBind();

                String Id = Request["StationeryID"];
                var currId = RaisoRepository.findID_Stationery(Convert.ToInt32(Id));
                
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            var stationeryContext = new StationeryController.StationeryContext();
            var stationeryModel = new StationeryController.StationeryModel
            {
                StationeryID = Convert.ToInt32(Request["StationeryID"]),
                StationeryName = nameBox.Text,
                StationeryPrice = Convert.ToInt32(priceBox.Text)

            };
            
            var stationeryId = RaisoRepository.findID_Stationery(stationeryModel.StationeryID);
            StationeryHandler.updateStationery(stationeryModel.StationeryID, stationeryModel.StationeryName, stationeryModel.StationeryPrice);

            Response.Redirect("~/Views/Admin/HomePage.aspx");

        }
        private string GetValidateUpdate_name(int Id, string fieldname, StationeryController.StationeryContext context)
        {
            return StationeryController.GetValidateUpdate_name(Id, fieldname, context);
        }
        private string GetValidateUpdate_price(int Id, string fieldprice, StationeryController.StationeryContext context)
        {
            return StationeryController.GetValidateUpdate_price(Id, fieldprice, context);
        }
    }
}