using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Bridge
{
    public class StackHanoi : Stack
    {
        private int _totalRejected = 0;
        public StackHanoi(): base("array") { }

        public StackHanoi(string s) : base(s) { }

        public int ReportRejected()
        {
            return _totalRejected;
        }

        public override void Push(int i)
        {
            if(!IsEmpty() && i > Top())
            {
                _totalRejected++;
            }
            else
            {
                base.Push(i);
            }
        }
    }
}
