using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FactoryMethod
{
    public class ConcreteCreatorB : Creator
    {
        protected override IProduct FactoryMethod()
        {
            return new ProductB();
        }
    }
}
