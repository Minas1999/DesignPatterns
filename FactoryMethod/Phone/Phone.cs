using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Phone : IProduct
    {
        public string Operation()
        {
            return "result of Phone Class";
        }
    }
}
