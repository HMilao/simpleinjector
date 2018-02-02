using NeonServer.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonServer.Service.Service.Interface
{
    public interface IClientService
    {
        IEnumerable<Client> GetClients();
    }
}
