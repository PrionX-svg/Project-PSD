using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_PSD.Models;

namespace Project_PSD.Factories
{
    public class StationeryFactory
    {
        public static MsStationery Create(int stationeryID, String staioneryName, int stationeryPrice)
        {
            MsStationery stationery = new MsStationery();
            stationery.StationeryID = stationeryID;
            stationery.StationeryName = staioneryName;
            stationery.StationeryPrice = stationeryPrice;

            return stationery;
        }
    }
}