using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Builder
{
    public class Client
    {
        public string Exec()
        {
            //...
            Director director = new Director();
            //...
            director.Set(new ConcreteBuilderA());
            director.Construct().Write();
            //...
            director.Set(new ConcreteBuilderB());
            return director.Construct().Write();
            //...
        }
    }
}
