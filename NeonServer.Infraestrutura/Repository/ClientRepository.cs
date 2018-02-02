using NeonServer.Dominio.Model;
using NeonServer.Infraestrutura.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonServer.Infraestrutura.Repository
{
    public class ClientRepository : IClientRepository
    {
        public IList<Client> GetClients()
        {
            var clients = new List<Client>();

            clients.Add(new Client() { Id = 1, Nome = "João" });
            clients.Add(new Client() { Id = 2, Nome = "Paulo" });

            return clients;
        }
    }
}
