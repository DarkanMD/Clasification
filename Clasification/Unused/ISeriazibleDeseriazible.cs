using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    interface ISeriazibleDeseriazible<T> where T : class
    {
         T  Deserialize(string input);
         string Serialize(T entity);
    }
}
