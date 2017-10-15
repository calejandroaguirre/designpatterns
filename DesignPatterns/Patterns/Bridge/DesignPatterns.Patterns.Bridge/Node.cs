using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Bridge
{
    public class Node
    {
        public int value;
        public Node prev, next;

        public Node(int i)
        {
            value = i;
        }
    }
}
