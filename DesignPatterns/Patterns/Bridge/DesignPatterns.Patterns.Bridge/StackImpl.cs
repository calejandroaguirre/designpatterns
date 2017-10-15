using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Bridge
{
    public abstract class StackImpl
    {
        public abstract void Push(int i);
        public abstract int Pop();
        public abstract int Top();
        public abstract bool IsEmpty();
        public abstract bool IsFull();
    }
}
