using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Builder
{
    public abstract class Product
    {
        protected Product NextProduct;
        public Product()
        {
            NextProduct = null;
        }

        public void Link(Product product)
        {
            this.NextProduct = product;
        }

        public Product GetNextProduct()
        {
            return NextProduct;
        }

        public abstract string Write();
    }
}
