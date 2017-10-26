using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Command
{
    public class Client
    {
        private void Exec()
        {
            //...
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            //...
            invoker.Execute(new ConcreteCommandA(receiver));
            //...
            invoker.Execute(new ConcreteCommandB(receiver));
            //...		
        }
    }
}
