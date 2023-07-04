using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_BITC
{
    internal class Car
    {
        protected void StartEngine()
        {
            Console.WriteLine("The Engine is started");
        }
        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("The Car is driven");
        }
    }
}
