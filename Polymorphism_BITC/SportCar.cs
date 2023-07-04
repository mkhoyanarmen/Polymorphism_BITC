using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_BITC
{
    internal class SportCar : Car
    {
        public override sealed void Drive()
        {
            StartEngine();
            Console.WriteLine("The SportCar is driven");
        }
    }
}
