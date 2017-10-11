using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Builder
{
    public abstract class Builder
    {
        protected Product product;
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public Product GetResult()
        {
            return product;
        }
    }
}
