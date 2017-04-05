using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Ninject;
using System.Reflection;

namespace Clasification
{
    class TextRepository<T> : IRepository<T> where T : class
    {
        static string path = "d:\\mydata.txt";
        IFactory<T> _factory;
       


        public TextRepository()
        {
            var kernel = new StandardKernel(Bindings.Instance);
            _factory = kernel.Get<IFactory<T>>();
        }

        public void Add(T entity)
        {
            using (StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Append, FileAccess.Write)))
            {
                writer.WriteLine($"{typeof(T).Name};{entity.ToString()}");
            }
        }

        public void Add(List<T> entity)
        {
            using (StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Append, FileAccess.Write)))
            {
                foreach (var item in entity)
                {
                    writer.WriteLine($"{typeof(T).Name};{item.ToString()}");
                }
            }
        }

        public void Delete(T entity)
        {
            List<string> result = new List<string>();
            string line = "";
            string lineToDelete = $"{typeof(T).Name};{entity.ToString()}";
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
                    if (line.Contains(typeof(T).Name.ToString()))
                    {
                            result.Add(_factory.Create(line));
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
                    if (line.Contains(typeof(T).Name.ToString()))
                    {
                        result.Add(_factory.Create(line));
                    }
                }
            }
            return result;
        }

       // public PagedResult<T> ListOrdersForCustomer(
       //Guid customerId, int page, int pageSize)
       // {
       //     var results = from o in _context.Orders
       //                   where o.Customer.Id == customerId
       //                   orderby o.Id
       //                   select o;

       //     var result = GetPagedResultForQuery(results, page, pageSize);
       //     return result;
       // }

        public static PagedResult<T> GetPagedResultForQuery(
        IEnumerable<T> query, int page, int pageSize)
        {
            var result = new PagedResult<T>();
            result.CurrentPage = page;
            result.PageSize = pageSize;
            result.RowCount = query.Count();
            var pageCount = (double)result.RowCount / pageSize;
            result.PageCount = (int)Math.Ceiling(pageCount);
            var skip = (page - 1) * pageSize;
            result.Results = query.Skip(skip).Take(pageSize).ToList();

            return result;

        }

        public void Save()
        {
         //   txtHandler.Write(json.Serialize(_myrepository), typeof(T).ToString());
        }
    }
}
