using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Decorator
{
    public class BorderConcreteDecorator : WindowDecorator
    {
        public BorderConcreteDecorator(WindowComponent windowComponent) : base(windowComponent)
        {
        }

        public override void Draw()
        {
            Debug.WriteLine("|");
            _WindowComponent.Draw();
            Debug.WriteLine("|");
        }
    }
}
