using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Decorator
{
    //Concrete componet
    public class WindowConcreteComponent : WindowComponent
    {
        public override void Draw()
        {
            Debug.WriteLine(" Window ");
        }
    }
}
