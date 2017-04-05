using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Clasification
{
    class SerializeDeserialize<T> : ISeriazibleDeseriazible<T> where T : class
    {
        public T Deserialize(string input)
        {
            return JsonConvert.DeserializeObject<T>(input);
        }

        public string Serialize(T entity)
        {
            return JsonConvert.SerializeObject(entity);
        }
    }
}
