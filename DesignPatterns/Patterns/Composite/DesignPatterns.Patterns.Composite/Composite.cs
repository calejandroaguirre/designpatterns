using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Composite
{
    public class Composite : Component
    {
        private List<Component> componentList;
        public Composite()
        {
            componentList = new List<Component>();
        }
        public override void Operation()
        {
            Debug.WriteLine("operation by composite");
            foreach (var item in componentList)
            {
                item.Operation();
            }
        }

        public void Add(Component component)
        {
            componentList.Add(component);
        }

        public void Remove(Component component)
        {
            componentList.Remove(component);
        }
    }
}
