using NeonServer.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonServer.Infraestrutura.Repository.Interface
{
    public interface IClientRepository
    {
        IList<Client> GetClients();
    }
}
