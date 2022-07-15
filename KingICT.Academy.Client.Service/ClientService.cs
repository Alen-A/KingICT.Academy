using KingICT.Academy.Client.Messaging;
using KingICT.Academy.Client.Model;
using KingICT.Academy.Clients.Contract;

namespace KingICT.Academy.Client.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public ClientDTO GetClient(int id)
        {
            // TODO Authorization
            // TODO Exception Handling

            ClientRoot client = _clientRepository.Get(id);

            // TAKO NE
            //if (string.IsNullOrWhiteSpace(client.FirstName))
            //{

            //}

            return new ClientDTO()
            {
                Name = client.FirstName,
                Surname = client.LastName
            };
        }
    }
}