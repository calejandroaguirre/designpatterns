using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Bridge_2
{
    public class RefinedAbstraction : Abstraction
    {
        private Implementor implementer;
        public RefinedAbstraction(Implementor implementer)
        {
            this.implementer = implementer;
        }
        public override void Operation()
        {
            implementer.OperationImp();
        }
    }
}
