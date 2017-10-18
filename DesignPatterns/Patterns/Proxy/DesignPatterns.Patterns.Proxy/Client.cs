using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Proxy
{
    public class Client
    {
        public void Exec()
        {
            ICar car = new ProxyCar(new Driver(16));
            car.DriveCar();

            car = new ProxyCar(new Driver(25));
            car.DriveCar();
        }
    }
}
