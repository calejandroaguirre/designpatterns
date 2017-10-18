using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Flyweight
{
    public class ConcreteFlyweightB : Flyweight
    {
        public override void M(Context context)
        {
            Debug.WriteLine("m of ConcreteFlyweightB with context: " + this);
        }
    }
}
