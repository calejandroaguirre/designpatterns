using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Decorator
{
    //Decorator Class
    public abstract class WindowDecorator : WindowComponent
    {
        protected WindowComponent _WindowComponent;
        public WindowDecorator(WindowComponent windowComponent)
        {
            _WindowComponent = windowComponent;
        }
    }
}
