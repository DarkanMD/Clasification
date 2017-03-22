
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    class TextRepository<T> : IRepository<T> where T: class
    {
        List<T> _myrepository = new List<T>();
        

        public void Add(T entity)
        {
            _myrepository.Add(entity);
        }

        public void Delete(T entity)
        {
            _myrepository.Remove(entity);
        }

        public T Get(Func<T, bool> expression)
        {
            return new List<T>().FirstOrDefault(expression);
        }

        public List<T> GetAll()
        {
            return _myrepository;
        }

        public void Save()
        {
            txtHandler.Write(_myrepository[0].ToString(), json.Serialize(_myrepository));
        }
    }
}
