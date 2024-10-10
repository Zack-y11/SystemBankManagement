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
                string query = "SELECT A.AccountId, A.AccountNumber, A.Saldo, A.OpenDateAccount, AT.Type AS AccountType, " +
               "C.Name AS ClientName, C.Dui AS ClientDUI " +
               "FROM Accounts A " +
               "JOIN AccountType AT ON A.AccountTypeId = AT.AccountTypeId " +
               "JOIN Clients C ON A.ClientId = C.ClientId;";



                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                accountsTable.Load(reader);
            }
            return accountsTable;
        }
        public DataTable GetAllTypes()
        {
            DataTable typesTable = new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT AccountTypeId, Type FROM AccountType";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    typesTable.Load(reader);
                }
                catch(SqlException ex)
                {
                    throw new Exception("An error occurred while getting the account types", ex);
                }
            }
            return typesTable;
        }
        //GET TABLE CLIENTS ID AND NAME
        public DataTable GetAllClients()
        {
            DataTable clientsTable = new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT ClientId, Name FROM Clients";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    clientsTable.Load(reader);
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while getting the clients", ex);
                }
            }
            return clientsTable;
        }

        public void AddAccount(Account account) 
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = "INSERT INTO Accounts VALUES(@AccountNumber, @Saldo, @OpenDateAccount, @AccountTypeId, @ClientId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
                command.Parameters.AddWithValue("@Saldo", account.Saldo);
                command.Parameters.AddWithValue("@OpenDateAccount", DateTime.Parse(account.OpenDateAccount));
                command.Parameters.AddWithValue("@AccountTypeId", account.AccountTypeId);
                command.Parameters.AddWithValue("@ClientId", account.ClientId);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while adding the account.", ex);
                }
            }
        }

        public void UpdateAccount(Account account)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = $"UPDATE Accounts SET AccountNumber = @AccountNumber, Saldo = @Saldo, OpenDateAccount = @OpenDateAccount, AccountTypeId = @AccountTypeId, ClientId = @ClientId WHERE AccountId = @AccountId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
                command.Parameters.AddWithValue("@Saldo", account.Saldo);
                command.Parameters.AddWithValue("@OpenDateAccount", DateTime.Parse(account.OpenDateAccount));
                command.Parameters.AddWithValue("@AccountTypeId", account.AccountTypeId);
                command.Parameters.AddWithValue("@ClientId", account.ClientId);
                command.Parameters.AddWithValue("@AccountId", account.AccountId);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch(SqlException ex)
                {
                    throw new Exception("An error occurred while updating the Account.", ex);
                }


            }
        }
        public void DeleteAccount (int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Accounts WHERE AccountId = @AccountId ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountId", id);

                try
                {
                    connection.Open(); 
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while deleting the account.", ex);
                }
                
            }
        }
        public void MakingTransacction(decimal amount, string AccountNumber)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "UPDATE Accounts SET Saldo = Saldo + @Amount WHERE AccountNumber = @AccountNumber\r\n";
                SqlCommand command = new SqlCommand (query, connection);
                command.Parameters.AddWithValue("Saldo", amount);
                command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch(SqlException ex)
                {
                    throw new Exception("An error occurred while processing the transaction", ex);
                }
            }
        }
        public decimal GetAccountBalance(string AccountNumber)
        {
            decimal balance = 0;
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT Saldo FROM Accounts WHERE AccountNumber = @AccountNumber";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                try
                {
                    connection.Open();
                    balance = Convert.ToDecimal(command.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while getting the account balance", ex);
                }
            }
            return balance;
        }
        //Making withdrawal
        public void MakingWithdrawal(decimal amount, string AccountNumber)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "UPDATE Accounts SET Saldo = Saldo - @Amount WHERE AccountNumber = @AccountNumber";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while processing the transaction", ex);
                }
            }
        }
        
    }   
}
