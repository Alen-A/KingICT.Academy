using KingICT.Academy.Client.Model;

namespace KingICT.Academy.Client.Repository
{
    public class ClientRepository : IClientRepository
    {

        public ClientRoot Get(int id)
        {
            //return new ClientRoot(id, "ime", "prezime");
            ClientRoot client = new ClientRoot(0, null, null, new ClientOrganization());
            client.SetClientOrganization(new ClientOrganization());

            return client;

        }

        public ClientRoot Add(ClientRoot entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ClientRoot entity)
        {
            throw new NotImplementedException();
        }

        public ClientRoot Update(ClientRoot entity)
        {
            throw new NotImplementedException();
        }
    }
}