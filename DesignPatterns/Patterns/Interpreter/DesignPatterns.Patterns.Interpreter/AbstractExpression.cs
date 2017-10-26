using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Interpreter
{
    // "AbstractExpression"
    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}
