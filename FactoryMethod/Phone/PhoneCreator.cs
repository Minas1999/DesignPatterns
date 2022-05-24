using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class PhoneCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new Phone();
        }
    }
}
