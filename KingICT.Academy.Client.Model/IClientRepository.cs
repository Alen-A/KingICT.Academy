using KingICT.Academy.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingICT.Academy.Client.Model
{
    public interface IClientRepository : IRepository<ClientRoot, int>
    {
        ClientRoot Get(int id);
    }
}
