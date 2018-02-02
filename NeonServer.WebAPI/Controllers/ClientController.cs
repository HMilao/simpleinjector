using NeonServer.Dominio.Model;
using NeonServer.Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NeonServer.WebAPI.Controllers
{
    public class ClientController : ApiController
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        // GET api/Client
        public IEnumerable<Client> GetClients()
        {
            return _clientService.GetClients();
        }

    }
}
