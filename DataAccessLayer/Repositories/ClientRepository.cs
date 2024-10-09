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
    public class ClientRepository
    {
        private SqlDataAccess _dbConnection;

        public ClientRepository()
        {
            _dbConnection = new SqlDataAccess();   
        }

        public DataTable GetAllClients()
        {
            DataTable clientsTable = new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT ClientId, Name, Dui FROM Clients";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                clientsTable.Load(reader);
            }
            return clientsTable;    
        }

        public void AddClient(Client client)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = $"INSERT INTO Client VALUES(@Name, @Dui, @PhoneNumber, @Address)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", client.Name);
                command.Parameters.AddWithValue("@Dui", client.Dui);
                command.Parameters.AddWithValue("@PhoneNumber", client.PhoneNumber);
                command.Parameters.AddWithValue("@Address", client.Address);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while adding the Client.", ex);
                }
            }
        }

        public void UpdateClient(Client client)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = $"UPDATE Client SET Name = @Name, Dui = @Dui, PhoneNumber = @PhoneNumber, Address = @Address WHERE Id = @ClientId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", client.Name);
                command.Parameters.AddWithValue("@Dui", client.Dui);
                command.Parameters.AddWithValue("@PhoneNumber", client.PhoneNumber);
                command.Parameters.AddWithValue("@Address", client.Address);
                command.Parameters.AddWithValue("@ClientId", client.Id);
                try
                {
                    connection.Open(); 
                    command.ExecuteNonQuery(); 
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while updating the Client.", ex);
                }
            }
        }

        public void DeleteClient(int id)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE * FROM Client WHERE Id = @ClientId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientId", id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while deleting the Client.", ex);
                }
            }
        }
    }
}
