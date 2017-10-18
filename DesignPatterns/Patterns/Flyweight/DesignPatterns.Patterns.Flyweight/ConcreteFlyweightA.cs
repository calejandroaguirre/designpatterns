using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Flyweight
{
    public class ConcreteFlyweightA : Flyweight
    {
        public override void M(Context context)
        {
            Debug.WriteLine("m of ConcreteFlyweightA with context: " + this);
        }
    }
}
