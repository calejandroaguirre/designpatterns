using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.ChainOfResponsab
{
    public class ConcreteHandlerA : Handler
    {
        public ConcreteHandlerA(Handler nextHandler) : base(nextHandler){ }
        public override void HandlerRequest()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            if (random.Next(10) <= 7)
            {
                Debug.WriteLine("Decide ConcreteHandlerA");
            }
            else
            {
                NextHandler.HandlerRequest();
            }
        }
    }
}
