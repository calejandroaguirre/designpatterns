using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FactoryMethod
{
    public class ProductB : IProduct
    {
        public string Write()
        {
            return "Message From ProductB";
        }
    }
}
