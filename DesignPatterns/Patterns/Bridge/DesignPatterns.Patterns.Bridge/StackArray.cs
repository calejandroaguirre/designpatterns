using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Bridge
{
    public class StackArray : StackImpl
    {
        private int[] _items;
        private int _total;

        public StackArray()
        {
            this._items = new int[12];
        }

        public StackArray(int cells)
        {
            this._items = new int[cells];
        }

        public override bool IsEmpty()
        {
            return _total == -1;
        }

        public override bool IsFull()
        {
            return _total == _items.Length - 1;
        }

        public override int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return _items[_total--];
        }

        public override void Push(int i)
        {
            if (!IsFull())
            {
                _items[++_total] = i;
            }
        }

        public override int Top()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return _items[_total];
        }
    }
}
