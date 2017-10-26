using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.ChainOfResponsab
{
    public abstract class Handler
    {
        protected Handler NextHandler;

        protected Handler(Handler nextHandler)
        {
            this.NextHandler = nextHandler;
        }
        public abstract void HandlerRequest();
    }
}
