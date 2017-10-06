using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Patterns.Singleton.Config
{
    public class Client
    {
        public void Exec()
        {
            Singleton.Instance().DoSomething();
        }
    }
}