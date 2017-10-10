using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Patterns.Prototype
{
    public class ConcretePrototypeA : Prototype
    {
        public override Prototype Clone()
        {
            throw new NotImplementedException();
        }
    }
}