using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FactoryMethod
{
    public class Client
    {
        private Creator Creator;

        public void Exec()
        {
            //...
            this.Creator = new ConcreteCreatorA();
            this.Creator.Operation();
            //...
            this.Creator = new ConcreteCreatorB();
            this.Creator.Operation();
            //...
        }
    }
}
