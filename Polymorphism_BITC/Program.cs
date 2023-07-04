using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_BITC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car sportCar = new SportCar();
            sportCar.Drive();

            Console.WriteLine();

            Car car = new Car();
            car.Drive();
        }
    }
}
