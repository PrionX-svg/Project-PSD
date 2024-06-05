using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_PSD.Factories;
using Project_PSD.Models;

namespace Project_PSD.Repository
{
    public class CartRepository
    {
        static RAisoEntities1 db = Singleton.GetInstance();

        public List<Cart> GetCart()
        {
            return(from Cart in db.Carts select Cart).ToList();
        }

        public Cart findId_cart(int userID, int stnID)
        {
            return (from Cart in db.Carts
                    where Cart.UserID == userID && Cart.StationeryID == stnID
                    select Cart
                   ).FirstOrDefault();
        }
        public static void InserttoCart(String stationeryName, int stationeryPrice, int Qty)
        {
            Cart temp = CartFactory.Create(stationeryName, stationeryPrice, Qty);
            db.Carts.Add(temp);
            db.SaveChanges();
        }

        public void UpdateCart(int Userid, int StationeryId, int Qty)
        {
            Cart updateCart = findId_cart(Userid, StationeryId);
            updateCart.UserID = Userid;
            updateCart.StationeryID = StationeryId;
            updateCart.Quantity = Qty;
        }
    }
}