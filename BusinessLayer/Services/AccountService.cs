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
    public class AccountService
    {
        private AccountRepository _accountRepository;

        public AccountService()
        {
            _accountRepository = new AccountRepository();
        }

        public DataTable GetAccounts()
        {
            return _accountRepository.GetAllAccounts();
        }
        public DataTable GetTypes()
        {
            return _accountRepository.GetAllTypes();
        }
        public DataTable GetAllClients()
        {
            return _accountRepository.GetAllClients();
        }
        public void AddAccount(Account account)
        {
            _accountRepository.AddAccount(account);
        }
        public void UpdateAccount(Account account)
        {
            _accountRepository.UpdateAccount(account);
        }
        public void DeleteAccount(int id)
        {
            _accountRepository.DeleteAccount(id);
        }
        public void MakeTransaction(decimal amount, string accountNumber)
        {
            _accountRepository.MakingTransacction(amount, accountNumber);
        }
        public void MakeWithdrawal(decimal amount, string accountNumber)
        {
            decimal currentBalance = _accountRepository.GetAccountBalance(accountNumber);

            if(currentBalance >= amount)
            {
                _accountRepository.MakingWithdrawal(amount, accountNumber);
            }
            else
            {
                throw new Exception("Insufficient funds");
            }
        }
        public int GetAccountId(string accountNumber)
        {
            int accountId = _accountRepository.GetAccountId(accountNumber);
            if (accountId == 0)
            {
                throw new Exception("Account number not found.");
            }
            return accountId;
        } 
    }
}
