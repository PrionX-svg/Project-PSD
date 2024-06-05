using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_PSD.Models;


namespace Project_PSD.Factories
{
    public class UserFactory
    {
        public static MsUser Create(int userID, String UserName, String UserGender, DateTime UserDOB, String UserPhone, String UserAddress, String UserPassword, String UserRole)
        {
            MsUser user = new MsUser();
            user.UserID = userID;
            user.UserName = UserName;
            user.UserGender = UserGender;
            user.UserDOB = UserDOB;
            user.UserPhone = UserPhone;
            user.UserAddress = UserAddress;
            user.UserPassword = UserPassword;
            user.UserRole = UserRole;
            

            return user;
        }
    }
}