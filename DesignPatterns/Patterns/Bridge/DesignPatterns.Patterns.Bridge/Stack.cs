using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Bridge
{
    public class Stack
    {
        private StackImpl _impl;

        public Stack(string s)
        {
            if (s.Equals("array"))
            {
                _impl = new StackArray();
            }else if (s.Equals("list"))
            {
                _impl = new StackList();
            }
            else
            {
                Debug.WriteLine("Stack: unknown parameter");
            }
        }

        public Stack(): this("array") { }


        public virtual void Push(int i)
        {
            _impl.Push(i);
        }

        public virtual int Pop()
        {
            return _impl.Pop();
        }

        public int Top()
        {
            return _impl.Top();
        }

        public bool IsEmpty()
        {
            return _impl.IsEmpty();
        }

        public bool IsFull()
        {
            return _impl.IsFull();
        }
    }
}
