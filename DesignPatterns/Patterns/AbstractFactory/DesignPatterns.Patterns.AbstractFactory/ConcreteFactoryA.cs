using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    public class ConcreteFactoryA : AbstractFactory
    {
        public ConcreteProductAA ConcreteProductAA;

        public ConcreteProductBA ConcreteProductBA;

        public override AbstractProductA CreateProductA()
        {
            ConcreteProductAA = new ConcreteProductAA();
            return ConcreteProductAA;
        }

        public override AbstractProductB CreateProductB()
        {
            ConcreteProductBA = new ConcreteProductBA();
            return ConcreteProductBA;
        }
    }
}
