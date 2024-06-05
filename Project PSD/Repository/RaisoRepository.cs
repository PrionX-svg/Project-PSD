using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_PSD.Factories;
using Project_PSD.Models;

namespace Project_PSD.Repository
{
    //Stationery Repository
    public class RaisoRepository
    {
        static RAisoEntities1 db = Singleton.GetInstance();

        public static List<MsStationery> GetStationeries()
        {
            return(from MsStationery in db.MsStationeries select MsStationery).ToList();
        }
        
        public static MsStationery findID_Stationery(int stationeryId)
        {
            return (from MsStationery in db.MsStationeries
                    where MsStationery.StationeryID == stationeryId
                    select MsStationery).FirstOrDefault();
        }
        public static void InsertStationeries(int stationeryID, String Stationeryname, int Stationeryprice)
        {
            MsStationery temp = StationeryFactory.Create(stationeryID,Stationeryname, Stationeryprice);
            db.MsStationeries.Add(temp);
            db.SaveChanges();
        }

        public static void UpdateStationeries(int StationeryId, String Stationeryname, int Stationeryprice)
        {
            MsStationery temp = findID_Stationery(StationeryId);          
            temp.StationeryName = Stationeryname;
            temp.StationeryPrice = Stationeryprice;
            db.SaveChanges();
        }
        public static void DeleteStationeries(int StationeryId)
        {
            db.MsStationeries.Remove(findID_Stationery(StationeryId));
            db.SaveChanges();
        }
        
    }
}