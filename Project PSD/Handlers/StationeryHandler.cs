using Project_PSD.Models;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Handlers
{
    public class StationeryHandler
    {
        public List<MsStationery> getAllStationery()
        {
            return RaisoRepository.GetStationeries();
        }

        public static MsStationery getStationeryBYid(int StationeryId)
        {
            return RaisoRepository.findID_Stationery(StationeryId);
        }
        public static int GenerateID()
        {
            int newID = 0;

            var lastID = UserRepository.GetUsers().Select(x => x.UserID).LastOrDefault();

            if(lastID == null)
            {
                newID = 1;
               
            }
            else
            {
                int currID = lastID;
                currID++;
                return currID;
            }

            return newID;
        }
        public static void insertStationery(int newstationeryID, String Stationeryname, int Stationeryprice)
        {
            RaisoRepository.InsertStationeries(newstationeryID, Stationeryname, Stationeryprice);
        }
        public static void updateStationery(int StationeryId, String Stationeryname, int Stationeryprice)
        {
            RaisoRepository.UpdateStationeries(StationeryId, Stationeryname, Stationeryprice);
        }
        public static void deleteStationery(int StationeryId)
        {
            RaisoRepository.DeleteStationeries(StationeryId);
        }
    }
}