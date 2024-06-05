using Project_PSD.Models;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Handlers
{
    public class TransactionHandler
    {
        TransactionRepository transactionrepo = new TransactionRepository();

        public List<TransactionDetail> getAllTransactions(int trnId)
        {
            return transactionrepo.GetTransactions();
        }

        public TransactionDetail getTransactionBYid(int trnId, int StationeryId)
        {
            return transactionrepo.findID_TransactionDetail(trnId, StationeryId);
        }
    }
}