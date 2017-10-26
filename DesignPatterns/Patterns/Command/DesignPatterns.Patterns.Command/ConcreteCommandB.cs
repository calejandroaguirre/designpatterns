using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Command
{
    public class ConcreteCommandB : Command
    {
        public ConcreteCommandB(Receiver receiver) : base(receiver) { }
        public override void Execute()
        {
            receiver.Action2();
        }
    }
}
