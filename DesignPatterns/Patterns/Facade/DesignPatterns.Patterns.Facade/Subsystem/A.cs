using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Facade.Subsystem
{
    public class A
    {
        public void M1()
        {
            Debug.WriteLine("M1 of A");
        }

        public void M2()
        {
            Debug.WriteLine("M2 of A");
        }
    }
}
