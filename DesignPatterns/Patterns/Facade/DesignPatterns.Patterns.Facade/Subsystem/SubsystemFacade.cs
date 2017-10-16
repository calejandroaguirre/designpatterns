using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Facade.Subsystem
{
    class SubsystemFacade
    {
        private A a;
        private B b;
        private C c;
        private D d;

        public SubsystemFacade()
        {
            a = new A();
            b = new B();
            c = new C();
            d = new D();
        }

        public void M1_2()
        {
            a.M1();
            a.M2();
        }

        public void M3_4()
        {
            b.M3();
            b.M4(a);
        }

        public void M5()
        {
            c.M5();
        }

        public void M6()
        {
            d.M6(d);
        }
    }
}
