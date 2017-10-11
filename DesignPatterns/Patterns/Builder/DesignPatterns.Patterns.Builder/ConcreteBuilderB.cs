using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Builder
{
    public class ConcreteBuilderB : Builder
    {
        public override void BuildPartA()
        {
            Product product = new ProductBA();
            if(this.product == null)
            {
                this.product = product;
            }
            else
            {
                Product actual = this.product;
                while (actual.GetNextProduct() != null)
                {
                    actual = actual.GetNextProduct();
                }
                actual.Link(this.product);
            }
        }

        public override void BuildPartB()
        {
            Product product = new ProductBB();
            if (this.product == null)
            {
                this.product = product;
            }
            else
            {
                Product actual = this.product;
                while (actual.GetNextProduct() != null)
                {
                    actual = actual.GetNextProduct();
                }
                actual.Link(this.product);
            }
        }
    }
}
