using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.ChainOfResponsab
{
    public class Client
    {
        private void Exec()
        {
            //...
            Handler handler = new ConcreteHandlerA(
                    new ConcreteHandlerA(
                    new ConcreteHandlerB()));
            //...
            handler.HandlerRequest();
        }
    }
}
