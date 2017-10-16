using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Facade.Subsystem
{
    class D
    {
        public void M6(D d)
        {
            Debug.WriteLine("M6 of D");
        }
    }
}
