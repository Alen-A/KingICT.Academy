using KingICT.Academy.Client.Messaging;

namespace KingICT.Academy.Clients.Contract
{
    public interface IClientService
    {
        ClientDTO GetClient(int id);
    }
}