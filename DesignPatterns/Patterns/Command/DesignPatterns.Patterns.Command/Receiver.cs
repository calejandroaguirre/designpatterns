using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Command
{
    public class Receiver
    {
        public void Action1()
        {
            Debug.WriteLine("Action1");
        }

        public void Action2()
        {
            Debug.WriteLine("Action2");
        }
    }
}
