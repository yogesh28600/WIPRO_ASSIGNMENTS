using System; // .Net Class Library
using System.Collections; // .Net Class Library

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var data = getData(); // call the getData function and assign the returned student ArrayList to data variable
            foreach (var student in data)  // Foreach loop is iterates through the arraylist 
            { 
                Console.WriteLine(student.ToString()); // Display the each student details on console for each iteration
            }

        }
        public static ArrayList getData()
        {
            //Initialising the Student class using constuctor
            Student s1 = new Student(1, "John", 100, "Hyderabad");
            Student s2 = new Student(2, "Adam", 101, "Bangolore");
            Student s3 = new Student(3, "Cody", 102, "Chennai");
            Student s4 = new Student(4, "Roman", 103, "Delhi");
            Student s5 = new Student(5, "William", 104, "Kolkata");
            //Declaring array of type ArrayList
            ArrayList array = new ArrayList();
            //Adding students to array
            array.Add(s1);
            array.Add(s2);
            array.Add(s3);
            array.Add(s4);
            array.Add(s5);
            return array; //return the array that contains students.

        }

    }
}
