using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Bridge
{
    public class StackList : StackImpl
    {
        private Node _last;
        public override bool IsEmpty()
        {
            return _last == null;
        }

        public override bool IsFull()
        {
            return false;
        }

        public override int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            int ret = _last.value;
            _last = _last.prev;
            return ret;
        }

        public override void Push(int i)
        {
            if(_last == null)
            {
                _last = new Node(i);
            }
            else
            {
                _last.next = new Node(i);
                _last.next.prev = _last;
                _last = _last.next;
            }
        }

        public override int Top()
        {
            if (IsEmpty())
            {
                return -1;
            }
           return _last.value;
        }
    }
}
