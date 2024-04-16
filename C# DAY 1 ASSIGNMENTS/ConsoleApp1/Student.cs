using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RollNumber { get; set; }
        public string Address { get; set; }
        public Student(int id, string name,int roll,string address)
        {
            this.Id = id;
            this.Name = name;
            this.RollNumber = roll;
            this.Address = address;
        }
        override
        public string ToString()
        {
            return "Id: " + this.Id + " Name: " + this.Name + " Roll Number: " + this.RollNumber + " Address: " + this.Address; 
        }
    }
}
