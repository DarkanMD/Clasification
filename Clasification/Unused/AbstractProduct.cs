using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    public abstract class AbstractProduct
    {
        public abstract string ProductName { get; set; }
       public abstract decimal ProductPrice { get; set; } 
    }
}
