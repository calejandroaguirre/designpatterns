using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FactoryMethod
{
    public abstract class Creator
    {

        public void Operation()
        {
            this.FactoryMethod().Write();
        }

        protected abstract IProduct FactoryMethod();
    }
}
