using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Factories
{
    public class CartFactory
    {
        public static Cart Create(String stationeryName, int stationeryPrice, int qty)
        {
            Cart cart = new Cart();
            MsStationery stationery = new MsStationery();

            stationery.StationeryName = stationeryName;
            stationery.StationeryPrice = stationeryPrice;
            cart.Quantity = qty;

            return cart;
        }
    }
}