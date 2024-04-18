using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Bycycle : IDrivable
    {
        public void drive()
        {
            Console.WriteLine("Driving a bycycle");  
        }

        public void start()
        {
            Console.WriteLine("started a bycycle");
        }

        public void stop()
        {
            Console.WriteLine("stopped a bycycle");
        }
    }
}
