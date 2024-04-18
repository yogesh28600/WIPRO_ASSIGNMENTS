using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Employee
    {
        public string name { get; set; }
        public string title { get; set; }
        public double salary { get; set; }
        public double rating {  get; set; }
        public Employee()
        {
            
        }
        public Employee(string name,string title,double salary, double rating) 
        { 
            this.name = name;
            this.title = title;
            this.salary = salary;
            this.rating = rating;
        }
        public virtual void displayEmployee()
        {
            Console.Write($" Name:{this.name} Title:{title} Salary:{salary}");
        }
    }
}
