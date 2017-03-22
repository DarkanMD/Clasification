using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clasification
{
    class TXTReaderWriter
    {

        public string Read(string type)
        {
            string path = $"d:\\{type}.txt";

                try
            {
                using (StreamReader myReader = new StreamReader(path))
                {
                    return myReader.ReadToEnd();
                }
            }
                catch (IOException e)
            {
                    Console.WriteLine(e.Message);
                    throw;
            }
               
        }


        public void Write(string type, string data)
        {
            string path = $"d:\\{type}.txt";
            using (StreamWriter myWriter = new StreamWriter(path))
            {
                myWriter.Write(data);
            }

        }
        
    }
}
