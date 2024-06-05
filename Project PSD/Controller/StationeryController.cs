using Project_PSD.Handlers;
using Project_PSD.Models;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

namespace Project_PSD.Controller
{
    public class StationeryController
    {
        public static void main(string[] args)
        {
            var stationeryrepo = new RaisoRepository();
            var stationerycontext = new StationeryContext();
            var stationerymodel = new StationeryModel
            {
                StationeryName = GetValidatedNameInput("Name", stationerycontext),
                StationeryPrice = Convert.ToInt32(GetValidatedPriceInput("Price", stationerycontext))              
                
            };
            StationeryHandler.insertStationery(stationerymodel.StationeryID, stationerymodel.StationeryName, stationerymodel.StationeryPrice);

            var stationerymodel2 = new StationeryModel
            {
                StationeryID = stationerymodel.StationeryID,
                StationeryName = GetValidateUpdate_name(stationerymodel.StationeryID,"Name", stationerycontext),
                StationeryPrice = Convert.ToInt32(GetValidateUpdate_price(stationerymodel.StationeryID, "Price", stationerycontext))
            };
            StationeryHandler.updateStationery(stationerymodel2.StationeryID, stationerymodel2.StationeryName, stationerymodel2.StationeryPrice);

        }
        public static string GetValidatedNameInput(string fieldname,StationeryContext context)
        {
            string input;
            while(true)
            {
                Console.Write($"{fieldname}: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"{fieldname} is must be filled.");
                    continue;
                }

                if (fieldname == "Name")
                {
                    if(input.Length < 3 || input.Length > 50)
                    {
                        Console.WriteLine($"{fieldname} must be between 3 and 50 characters.");
                        continue;
                    }
                }
                break;
            }
            return input;
        }
        public static string GetValidatedPriceInput(string fieldprice, StationeryContext context)
        {
            string price;
            while (true)
            {
                Console.Write($"{fieldprice}: ");
                price = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(price))
                {
                    Console.WriteLine($"{fieldprice} is must be filled.");
                    continue;
                }

                if (fieldprice == "Price")
                {
                    if (price.Length < 3 || price.Length > 50)
                    {
                        Console.WriteLine($"{fieldprice} must be between 3 and 50 characters.");
                        continue;
                    }
                }
                if(!fieldprice.All(char.IsNumber))
                {
                    Console.WriteLine($"{fieldprice} must be a numeric");
                    continue;
                }
                if(Convert.ToInt32(fieldprice) < 2000)
                {
                    Console.WriteLine($"{fieldprice} must be greate or equal to 2000");
                    continue;
                }

                break;
            }
            return price;
        }
        public static string GetValidateUpdate_name(int stationeryId,string fieldname, StationeryContext context)
        {
            MsStationery temp = StationeryHandler.getStationeryBYid(stationeryId);
            string nameupdate;

            if(temp == null)
            {
                Console.WriteLine("Invalid stationery");
            }
            while (true)
            {
                Console.Write($"{fieldname}: ");
                nameupdate = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nameupdate))
                {
                    Console.WriteLine($"{fieldname} is must be filled.");
                    continue;
                }

                if (fieldname == "Name")
                {
                    if (nameupdate.Length < 3 || nameupdate.Length > 50)
                    {
                        Console.WriteLine($"{fieldname} must be between 3 and 50 characters.");
                        continue;
                    }
                }
                break;
            }
            return nameupdate;
        }
        public static string GetValidateUpdate_price(int stationeryId, string fieldprice, StationeryContext context)
        {
            MsStationery temp = StationeryHandler.getStationeryBYid(stationeryId);
            string priceupdate;
            if (temp == null)
            {
                Console.WriteLine("Invalid stationery");
            }
            while (true)
            {
                Console.Write($"{fieldprice}: ");
                priceupdate = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(priceupdate))
                {
                    Console.WriteLine($"{fieldprice} is must be filled.");
                    continue;
                }

                if (fieldprice == "Price")
                {
                    if (priceupdate.Length < 3 || priceupdate.Length > 50)
                    {
                        Console.WriteLine($"{fieldprice} must be between 3 and 50 characters.");
                        continue;
                    }
                }
                if (!fieldprice.All(char.IsNumber))
                {
                    Console.WriteLine($"{fieldprice} must be a numeric");
                    continue;
                }
                if (Convert.ToInt32(fieldprice) < 2000)
                {
                    Console.WriteLine($"{fieldprice} must be greate or equal to 2000");
                    continue;
                }

                break;
            }
            return priceupdate;
        }
        public static string GetValidateDelete(int StationeryID)
        {
            MsStationery temp = StationeryHandler.getStationeryBYid(StationeryID);

            if(temp == null)
            {
                return "Must select at least 1 stationery"; 
            }

            StationeryHandler.deleteStationery(Convert.ToInt32(StationeryID));

            return null;

        }
        public class StationeryContext
        {
            public List<StationeryModel> Stationeries { get; set; } = new List<StationeryModel>();
        }
        public class StationeryModel
        {
            public int StationeryID { get; set; }
            public string StationeryName { get; set; }
            public int StationeryPrice { get; set; }
        }


    }
}