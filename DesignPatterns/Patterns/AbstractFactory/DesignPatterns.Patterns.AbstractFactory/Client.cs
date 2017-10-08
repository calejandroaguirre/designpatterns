using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    public class Client
    {
        private AbstractFactory abstractFactory;

        public AbstractFactory AbstractFactory
        {
            get => default(AbstractFactory);
            set
            {
            }
        }

        public AbstractProductA AbstractProductA
        {
            get => default(AbstractProductA);
            set
            {
            }
        }

        public AbstractProductB AbstractProductB
        {
            get => default(AbstractProductB);
            set
            {
            }
        }

        public void Exec()
        {
            //...
            abstractFactory = new ConcreteFactoryA();
            abstractFactory.CreateProductA().Write();
            abstractFactory.CreateProductB().Write();

            //...
            abstractFactory = new ConcreteFactoryB();
            abstractFactory.CreateProductA().Write();
            abstractFactory.CreateProductB().Write();
        }
    }
}
