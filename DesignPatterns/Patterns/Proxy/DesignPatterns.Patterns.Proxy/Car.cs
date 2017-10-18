using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Proxy
{
    //Real Object
    public class Car : ICar
    {
        public void DriveCar()
        {
            Debug.WriteLine("Car has been driven!");
        }
    }
}
