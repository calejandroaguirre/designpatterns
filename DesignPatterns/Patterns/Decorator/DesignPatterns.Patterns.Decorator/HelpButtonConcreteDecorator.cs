using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Decorator
{
    public class HelpButtonConcreteDecorator : WindowDecorator
    {
        public HelpButtonConcreteDecorator(WindowComponent windowComponent) : base(windowComponent)
        {
        }

        public override void Draw()
        {
            _WindowComponent.Draw();
            Debug.WriteLine("[Help button]");
        }
    }
}
