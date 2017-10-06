using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Singleton.Config
{
    public class SingletonA : Singleton
    {
        public SingletonA() { }

        public override string DoSomething()
        {
            return "From SingletonA";
        }
    }
}
