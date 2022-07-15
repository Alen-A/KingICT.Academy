using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingICT.Academy.Infrastructure
{
    public interface IRepository<T, TId> where T: IAggregateRoot
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
