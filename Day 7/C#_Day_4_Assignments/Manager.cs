using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Manager : Employee
    {
        double bonus;
        public void calculateBonus()
        {
            if(rating >=3 && rating < 4)
            {
                bonus = 5000;
            }else if(rating >=4 && rating < 4)
            {
                bonus = 10000;
            }else if (rating == 5)
            {
                bonus = 15000;
            }
        }
        public override void displayEmployee()
        {
            base.displayEmployee();
            Console.WriteLine("Bonus: " + bonus);
            
        }
    }
}
