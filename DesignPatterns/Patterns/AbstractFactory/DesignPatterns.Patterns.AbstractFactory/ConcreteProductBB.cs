using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    public class ConcreteProductBB : AbstractProductB
    {
        public override string Write()
        {
            return "From ProductBB";
        }
    }
}
