using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AccountRepository
    {
        public SqlDataAccess _dbConnection;

        public AccountRepository()
        {
            _dbConnection = new SqlDataAccess();
        } 

        public DataTable GetAllAccounts()
        {
            DataTable accountsTable = new DataTable();

            using(var connection = _dbConnection.GetConnection())
            {
                string query = $"SELECT A.AccountNumber, A.Saldo,      AT.Type AS AccountType, \r\n       C.Name AS ClientName, C.Dui AS ClientDUI\r\nFROM Accounts A\r\nJOIN AccountType AT\r\n  ON A.AccountTypeId = AT.AccountTypeId\r\nJOIN Clients C\r\n  ON A.ClientId = C.ClientId;";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                accountsTable.Load(reader);
            }
            return accountsTable;
        }

        public void AddAccount(Account account) 
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = "INSERT INTO Accounts VALUES(@AccountNumber, @Saldo, @OpenDateAccount, @AccountTypeId, @ClientId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
                command.Parameters.AddWithValue("@Saldo", account.Saldo);
                command.Parameters.AddWithValue("@OpenDateAccount", account.OpenDateAccount);
                command.Parameters.AddWithValue("@AccountTypeId", account.AccountTypeId);
                command.Parameters.AddWithValue("@ClientId", account.ClientId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateAccount(Account account)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = $"UPDATE Accounts SET AccountNumber = @AccountNumber, Saldo = @Saldo, OpenDateAccount = @OpenDateAccount, AccountTypeId = @AccountTypeId, ClientId = @ClientId WHERE Id = @AccountId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
                command.Parameters.AddWithValue("@Saldo", account.Saldo);
                command.Parameters.AddWithValue("@OpenDateAccount", account.OpenDateAccount);
                command.Parameters.AddWithValue("@AccountTypeId", account.AccountTypeId);
                command.Parameters.AddWithValue("@ClientId", account.ClientId);
                command.Parameters.AddWithValue("@AccountId", account.AccountId);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        public void DeleteAccount (int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Accounts WHERE Id = @AccountId ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountId", id);
                connection.Open(); 
                command.ExecuteNonQuery();
            }
        }
    }   
}
