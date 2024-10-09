using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    
    public class TransactionsServices
    {
        private TransactionRepository _transactionRepository;
        public TransactionsServices()
        {
            _transactionRepository = new TransactionRepository();
        }
        public DataTable GetTransacctions()
        {
            return _transactionRepository.GetAllAccounts();
        }
        public void AddTransacction(Transaction transaction)
        {
            _transactionRepository.AddTransfer(transaction);
        }
        public void UpdateTransacction(Transaction transaction)
        {
            _transactionRepository.UpdateTransfer(transaction);
        }
        public void DeleteTransacction(int id)
        {
            _transactionRepository.DeleteTransfer(id);
        }
    }
}
