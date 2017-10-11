using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Builder
{
    public class ConcreteBuilderA : Builder
    {
        public override void BuildPartA()
        {
            Product product = new ProductAA();
            product.Link(this.product);
            this.product = product;
        }

        public override void BuildPartB()
        {
            Product product = new ProductAB();
            product.Link(this.product);
            this.product = product;
        }
    }
}
