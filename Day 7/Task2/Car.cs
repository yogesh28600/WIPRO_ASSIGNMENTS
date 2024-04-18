using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Car : IDrivable
    {
        public void drive()
        {
            Console.WriteLine("Driving a car");
        }

        public void start()
        {
            Console.WriteLine("Started a car");
        }

        public void stop()
        {
            Console.WriteLine("Stopped a car");
        }
    }
}
