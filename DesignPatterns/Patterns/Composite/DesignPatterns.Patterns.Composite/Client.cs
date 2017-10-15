using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Composite
{
    public class Client
    {
        public void Main()
        {
            //...
            Leaf leaf1 = new Leaf();
            Leaf leaf2 = new Leaf();
            Composite composite1 = new Composite();
            composite1.Add(leaf1);
            composite1.Add(leaf2);

            Leaf leaf3 = new Leaf();
            Composite composite2 = new Composite();
            composite2.Add(leaf3);
            composite2.Add(composite1);
            //...
            Component component;
            //...
            component = leaf2;
            component.Operation();
            //...
            component = composite2;
            component.Operation();
            //...
        }
    }
}
