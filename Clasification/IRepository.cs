using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();

        T Get(Func<T, bool> expression);

        void Add(T entity);

        void Delete(T entity);

        void Save();

    }
}
