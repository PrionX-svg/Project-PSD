using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Factories
{
    public class TransactionFactory
    {
        public static TransactionDetail Create(int transactionId, int stationeryId)
        {
            TransactionDetail trnDetail = new TransactionDetail();

            trnDetail.TransactionID = transactionId;
            trnDetail.StationeryID = stationeryId;

            return trnDetail;
        }
    }
}