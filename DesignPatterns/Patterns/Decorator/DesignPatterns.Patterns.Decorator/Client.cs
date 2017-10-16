using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Decorator
{
    public class Client
    {
        public void Main()
        {
            HelpButtonConcreteDecorator windowWithHelpButton = new HelpButtonConcreteDecorator(new WindowConcreteComponent());
            BorderConcreteDecorator windowWithHelpButtonAndBorder = new BorderConcreteDecorator(windowWithHelpButton);
            windowWithHelpButtonAndBorder.Draw();
            Console.WriteLine();

            BorderConcreteDecorator windowWithBorder = new BorderConcreteDecorator(new WindowConcreteComponent());
            windowWithBorder.Draw();
            Console.WriteLine();

            BorderConcreteDecorator windowWithDoubleBorder = new BorderConcreteDecorator(windowWithBorder);
            windowWithDoubleBorder.Draw();
            Console.WriteLine();

            BorderConcreteDecorator ventanaConDobleBordeYBotonDeAyuda = new BorderConcreteDecorator(new BorderConcreteDecorator(windowWithHelpButton));
            ventanaConDobleBordeYBotonDeAyuda.Draw();
            Console.WriteLine();
            Console.Read();
        }
    }
}
