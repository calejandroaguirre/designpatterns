using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    public class ConcreteProductAB : AbstractProductA
    {

        public override string Write()
        {
            return "From ProductAB";
        }
    }
}
