using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Singleton.Basic
{
    public class Singleton
    {
        private static Singleton _singleton;

        private Singleton() { }
        public static Singleton Instance()
        {
            if (_singleton == null)
                _singleton = new Singleton();

            return _singleton;
        }

        public string DoSomething()
        {
            return "I do something";
        }
    }
}
