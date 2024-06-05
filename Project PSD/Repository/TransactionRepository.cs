using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_PSD.Factories;
using Project_PSD.Models;

namespace Project_PSD.Repository
{
    //Transaction Repository
    public class TransactionRepository
    {
        static RAisoEntities1 db = Singleton.GetInstance();

        public List<TransactionDetail> GetTransactions()
        {
            return (from TransactionDetail in db.TransactionDetails 
                    select TransactionDetail).ToList();
        }

        public TransactionDetail findID_TransactionDetail(int trnID, int stationeryID)
        {
            return (from TransactionDetail in db.TransactionDetails
                    where TransactionDetail.TransactionID == trnID &&
                    TransactionDetail.StationeryID == stationeryID
                    select TransactionDetail
                    ).FirstOrDefault();
        }
        public static void InsertTransaction(int trnID, int stationeryID)
        {
            TransactionDetail temp = TransactionFactory.Create(trnID, stationeryID);
            db.TransactionDetails.Add(temp);
            db.SaveChanges();
        }

    }
}