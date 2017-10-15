using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Bridge_2
{
    public class Client
    {
        public void Main()
        {
            Abstraction[] abstractions = new Abstraction[2];
            abstractions[0] = new RefinedAbstraction(new ConcreteImplementorA());
            abstractions[1] = new RefinedAbstraction(new ConcreteImplementorB());
            foreach (Abstraction item in abstractions)
            {
                item.Operation();
            }
        }
    }
}
