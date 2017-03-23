using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    class TextRepository<T> /*: IRepository<T>*/ where T: class
    {
        static string path = "d:\\mydata.txt";

        ISeriazibleDeseriazible<T> json;
        public TextRepository(ISeriazibleDeseriazible<T> serial)
        {
            json = serial;
        }

        public void Add(T entity)
        {
            using (StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Append, FileAccess.Write)))
            {
                writer.WriteLine($"{typeof(T)}  {json.Serialize(entity)}");
            }
        }

        public void Add(List<T> entity)
        {
            using (StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Append, FileAccess.Write)))
            {
                foreach (var item in entity)
                {
                    writer.WriteLine($"{typeof(T)} {json.Serialize(item)}");
                }
            }
        }

        public void Delete(T entity)
        {
            List<string> result = new List<string>();
            string line = "";
            string lineToDelete = $"{typeof(T)} {json.Serialize(entity)}";
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (String.Compare(line, lineToDelete) != 0)
                    result.Add(line);
                }
            }
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var item in result)
                {
                    writer.WriteLine(item);
                }
            }
        }

        public List<T> Get(Func<T, bool> expression)
        {
            List<T> result = new List<T>();
            string line = "";
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(typeof(T).ToString()))
                    {
                        result.Add(json.Deserialize(line.Replace(typeof(T).ToString(), "")));
                    }
                }
            }
            return  result.Where(expression).ToList();
        }

        public List<T> GetAll()
        {
            List<T> result = new List<T>();
            string line = "";
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(typeof(T).ToString()))
                    {
                        result.Add(json.Deserialize(line.Replace(typeof(T).ToString(), "")));
                    }
                }
            }
            return result;
        }

        public void Save()
        {
         //   txtHandler.Write(json.Serialize(_myrepository), typeof(T).ToString());
        }
    }
}
