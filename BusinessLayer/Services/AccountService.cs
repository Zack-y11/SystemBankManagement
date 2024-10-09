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
    }
}
