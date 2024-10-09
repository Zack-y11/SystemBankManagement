﻿using CommonLayer.Entities;
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
    public class TransactionRepository
    {
        public SqlDataAccess _dbConnection;
        public TransactionRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetAllAccounts()
        {
            DataTable transactionTable = new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {
                string query = $"SELECT \r\n    T.TransactionId,\r\n    C.Name AS ClientName,\r\n    A.AccountNumber,\r\n    T.TypeTransaction,\r\n    T.Amount,\r\n    T.DateTransaction,\r\n    T.Description\r\nFROM \r\n    Transactions T\r\nJOIN \r\n    Accounts A ON T.AccountId = A.AccountId\r\nJOIN \r\n    Clients C ON A.ClientId = C.ClientId;";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                transactionTable.Load(reader);
            }
            return transactionTable;
        }
        // Transacction by idClient and account number
        public DataTable GetTransacctionsById(string accountNumber)
        {
            DataTable transactionTable = new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {
                string query = $"SELECT T.TransactionId, C.Name AS ClientName, A.AccountNumber, T.TypeTransaction, T.Amount, T.DateTransaction, T.Description FROM Transactions T JOIN Accounts A ON T.AccountId = A.AccountId JOIN Clients C ON A.ClientId = C.ClientId WHERE A.AccountNumber = 'ACC12345';";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                transactionTable.Load(reader);
            }
            return transactionTable;
        }


        public void AddTransfer(Transaction transaction)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = $"INSERT INTO Transactions" +
                    $" (@AccountId ,@TypeTransaction, @Amount, @DateTransaction, @Description)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountId", transaction.AccountId);
                command.Parameters.AddWithValue("@TypeTransaction", transaction.Type);
                command.Parameters.AddWithValue("@Amount", transaction.Amount);
                command.Parameters.AddWithValue("@DateTransaction", transaction.Date);
                command.Parameters.AddWithValue("@Description", transaction.Description);
                try
                {
                    connection.Open(); 
                    command.ExecuteNonQuery(); 
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while updating the transaction.", ex);
                }
            }
        }

        public void UpdateTransfer(Transaction transaction)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = $"UPDATE Transactions SET AccountId = @AccountId ,Type = @TypeTransaction, Amount = @Amount, Date = @DateTransaction, Description = @Description WHERE TransactionId = @TransactionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountId", transaction.AccountId);
                command.Parameters.AddWithValue("@TypeTransaction", transaction.Type);
                command.Parameters.AddWithValue("@Amount", transaction.Amount);
                command.Parameters.AddWithValue("@DateTransaction", transaction.Date);
                command.Parameters.AddWithValue("@Description", transaction.Description);
                command.Parameters.AddWithValue("@TransactionId", transaction.TransactionId);
                try
                {
                    connection.Open(); // Open the connection
                    command.ExecuteNonQuery(); // Execute the update
                }
                catch (SqlException ex)
                {
                    // Handle exception (log it or rethrow)
                    throw new Exception("An error occurred while updating the transaction.", ex);
                }
            }
        }

        public void DeleteTransfer(int id)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Transactions WHERE Id = @TransactionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransactionId", id);
                try
                {
                    connection.Open(); 
                    command.ExecuteNonQuery(); 
                }
                catch (SqlException ex)
                {

                    throw new Exception("An error occurred while deleting the transaction.", ex);
                }

            }
        }
    }
}
