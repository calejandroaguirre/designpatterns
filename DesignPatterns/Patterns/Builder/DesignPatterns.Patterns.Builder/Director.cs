using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Builder
{
    public class Director
    {
        private Builder builder;

        public void Set(Builder builder)
        {
            this.builder = builder;
        }

        public Product Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartB();
            builder.BuildPartA();
            builder.BuildPartB();
            return builder.GetResult();
        }
    }
}
