using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    public class ConcreteFactoryB : AbstractFactory
    {
        public ConcreteProductAB ConcreteProductAB;
        public ConcreteProductBB ConcreteProductBB;
        

        public override AbstractProductA CreateProductA()
        {
            ConcreteProductAB = new ConcreteProductAB();
            return ConcreteProductAB;
        }

        public override AbstractProductB CreateProductB()
        {
            ConcreteProductBB = new ConcreteProductBB();
            return ConcreteProductBB;
        }
    }
}
