﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    interface IFactory<T> where T:class
    {

         T Create(string data);
       
    }
}
