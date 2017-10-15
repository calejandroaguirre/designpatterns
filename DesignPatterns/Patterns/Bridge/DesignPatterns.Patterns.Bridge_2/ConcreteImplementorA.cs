using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Bridge_2
{
    public class ConcreteImplementorA : Implementor
    {
        public override void OperationImp()
        {
            Debug.WriteLine("Implementation from A");
        }
    }
}
