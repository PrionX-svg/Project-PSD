using Project_PSD.Models;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Handlers
{
    public class CartHandler
    {
        CartRepository cartrepo = new CartRepository();

        public List<Cart> getItemInCart(int userid, int stationeryid)
        {
            return cartrepo.GetCart();
        }

        public Cart getCartBYid(int userid, int stationeryid)
        {
            return cartrepo.findId_cart(userid, stationeryid);
        }

        public void insertItemtoCart(String StationeryName, int stationeryPrice, int Qty)
        {
            CartRepository.InserttoCart(StationeryName, stationeryPrice, Qty);
        }
    }
}