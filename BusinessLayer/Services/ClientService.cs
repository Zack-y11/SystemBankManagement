using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;




namespace BusinessLayer.Services
{
    public class ClientService
    {
        private ClientRepository _clientRepository;
        public ClientService()
        {
            _clientRepository = new ClientRepository();
        }
        public DataTable GetClients()
        {
            return _clientRepository.GetAllClients();
        }
        public void AddClient (Client client)
        {
            _clientRepository.AddClient(client);
        }
        public void UpdateClient (Client client)
        {
            _clientRepository.UpdateClient(client);
        }
        public void DeleteClient(int idClient)
        {
            _clientRepository.DeleteClient(idClient);
        }
    }
}
