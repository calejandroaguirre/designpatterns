using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Flyweight
{
    public class FlyweightFactory
    {
        private ConcreteFlyweightA concreteFlyweightA;

        private ConcreteFlyweightB concreteFlyweightB;

        public Flyweight GetAFlyweight()
        {
            if (concreteFlyweightA == null)
            {
                concreteFlyweightA = new ConcreteFlyweightA();
            }
            return concreteFlyweightA;
        }

        public Flyweight GetBFlyweight()
        {
            if (concreteFlyweightB == null)
            {
                concreteFlyweightB = new ConcreteFlyweightB();
            }
            return concreteFlyweightB;
        }
    }
}
