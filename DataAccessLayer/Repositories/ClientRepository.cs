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
                //agregar Password
                string query = "SELECT ClientId, Name, Dui, PhoneNumber, Address, Password FROM Clients";

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
                string query = $"INSERT INTO Clients VALUES(@Name, @Dui, @PhoneNumber, @Address, @Password)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", client.Name);
                command.Parameters.AddWithValue("@Dui", client.Dui);
                command.Parameters.AddWithValue("@PhoneNumber", client.PhoneNumber);
                command.Parameters.AddWithValue("@Address", client.Address);
                command.Parameters.AddWithValue("@Password", client.Password);
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

                string query = $"UPDATE Clients SET Name = @Name, Dui = @Dui, PhoneNumber = @PhoneNumber, Address = @Address, Password = @Password WHERE ClientId = @ClientId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", client.Name);
                command.Parameters.AddWithValue("@Dui", client.Dui);
                command.Parameters.AddWithValue("@PhoneNumber", client.PhoneNumber);
                command.Parameters.AddWithValue("@Address", client.Address);
                command.Parameters.AddWithValue("@ClientId", client.Id);
                command.Parameters.AddWithValue("@Password", client.Password);


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
                string query = "DELETE FROM Clients WHERE ClientId = @ClientId";
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
        public void LoginClient(string name, string password)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Clients WHERE Name = @Name AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Password", password);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while logging in.", ex);
                }
            }
        }
    }
}
