using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Proxy
{
    public class ProxyCar : ICar
    {
        private Driver driver;
        private ICar realCar;

        public ProxyCar(Driver driver)
        {
            this.driver = driver;
            this.realCar = new Car();
        }
        public void DriveCar()
        {
            if (driver.Age <= 16)
                Debug.WriteLine("Sorry, the driver is too young to drive.");
            else
                this.realCar.DriveCar();

        }
    }
}
