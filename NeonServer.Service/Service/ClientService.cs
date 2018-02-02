using NeonServer.Dominio.Model;
using NeonServer.Infraestrutura.Repository.Interface;
using NeonServer.Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonServer.Service.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<Client> GetClients()
        {
            return _clientRepository.GetClients();
        }
    }
}
