using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Interpreter
{
    public class Client
    {
        static void Main()
        {
            var context = new Context();

            // Usually a tree
            var list = new List<AbstractExpression>
            {
                // Populate 'abstract syntax tree'
                new TerminalExpression(),
                new NonterminalExpression(),
                new TerminalExpression(),
                new TerminalExpression()
            };

            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
        }
    }
}
