using KingICT.Academy.Client.Messaging;
using KingICT.Academy.Clients.Contract;
using Microsoft.AspNetCore.Mvc;

namespace KingICT.Academy.Client.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {

        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
          _clientService = clientService;
        }

        [HttpGet("{id}")]
        public ClientDTO Get(int id)
        {
            return _clientService.GetClient(id);
        }
    }
}