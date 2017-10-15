using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Composite
{
    public class Leaf : Component
    {
        public override void Operation()
        {
            Debug.WriteLine("Operation by Leaf");
        }
    }
}
