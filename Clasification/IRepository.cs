using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    public interface IRepository<T, in TKey> where T : class
    {
        T Get(TKey id);
        void Save(T entity);
        void Delete(T entity);
    }
}
