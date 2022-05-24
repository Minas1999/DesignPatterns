using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class PrinterCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new Printer();
        }
    }
}
