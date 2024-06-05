using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_PSD.Models;
using Project_PSD.Factories;
using Project_PSD.Repository;

namespace Project_PSD.Handlers
{
    public class UserHandler
    {
       
        public List<MsUser> getAllUser(int userId)
        {
            return UserRepository.GetUsers();
        }
        public static int GenerateID()
        {
            int newID = 0;

            var lastID = RaisoRepository.GetStationeries().Select(x => x.StationeryID).LastOrDefault();

            if (lastID == null)
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
        public static MsUser getUserBYid(int userId) 
        {
            return UserRepository.findId_User(userId);
        }

        public static void insertUser(int userID,String UserName, String UserGender, DateTime UserDOB, String UserPhone, String UserAddress, String UserPassword, String UserRole)
        {
            
            UserRepository.InsertUsers(userID,UserName, UserGender, UserDOB, UserPhone, UserAddress, UserPassword, UserRole);
        }
        public static void updateUser(int userId, String UserName,String UserGender, DateTime UserDOB, String UserPhone, String UserAddress, String UserPassword)
        {
            UserRepository.updateUser(userId, UserName,UserGender, UserDOB, UserPhone, UserAddress, UserPassword);
        }

    }
}