using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.State
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    abstract class State
    {
        public abstract void Handle(Context context);
    }
}
