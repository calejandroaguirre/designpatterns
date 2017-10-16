using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Facade.Subsystem
{
    class B
    {
        public void M3()
        {
            Debug.WriteLine("M3 of B");
        }

        public void M4(A a)
        {
            Debug.WriteLine("M4 of B");
        }
    }
}
