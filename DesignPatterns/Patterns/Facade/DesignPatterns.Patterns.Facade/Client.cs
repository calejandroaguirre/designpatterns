using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Facade
{
    public class Client
    {
        public void Exec()
        {
            Subsystem.SubsystemFacade subsystemFacade = new Subsystem.SubsystemFacade();
            subsystemFacade.M1_2();
            subsystemFacade.M3_4();
            subsystemFacade.M5();
            subsystemFacade.M6();
            //...
            X x = new X();
            x.M7();
            //...
            Y y = new Y();
            y.M8();
        }
        
    }
}
