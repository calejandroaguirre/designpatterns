using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.ChainOfResponsab
{
    public class ConcreteHandlerB : Handler
    {
        public ConcreteHandlerB() : base(null) { }
        public override void HandlerRequest()
        {
            Debug.WriteLine("Decide ConcreteHandlerA");
        }
    }
}
