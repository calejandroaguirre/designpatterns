using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Patterns.Prototype
{
    public abstract class Prototype
    {
        /// <returns>Prototype</returns>
        public abstract Prototype Clone();

    }
}