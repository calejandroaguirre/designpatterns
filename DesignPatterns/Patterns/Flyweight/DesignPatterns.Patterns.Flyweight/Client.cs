using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Flyweight
{
    public class Client
    {
        public void Exec()
        {
            //...
            Context context = new Context();
            FlyweightFactory flyweightFactory = new FlyweightFactory();
            flyweightFactory.GetAFlyweight().M(context);
            flyweightFactory.GetBFlyweight().M(context);
            flyweightFactory.GetAFlyweight().M(context);
            flyweightFactory.GetBFlyweight().M(context);
            flyweightFactory.GetAFlyweight().M(context);
            flyweightFactory.GetBFlyweight().M(context);
            flyweightFactory.GetAFlyweight().M(context);
            flyweightFactory.GetBFlyweight().M(context);
        }
    }
}
