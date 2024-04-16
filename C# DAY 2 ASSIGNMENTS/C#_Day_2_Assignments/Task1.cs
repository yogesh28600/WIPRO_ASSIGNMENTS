using System.Transactions;

namespace C__Day_2_Assignments
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            conversion();
        }
        static void conversion()
        {
            Console.WriteLine("Enter  an integer and a double with space seperated");
            string str = Console.ReadLine();
            string[] str1 = str.Split(" ");
            int integer = int.Parse(str1[0]); //explicit conversion of string to int
            double decimalValue = Convert.ToDouble(str1[1]); //explicit conversion of string to double
            double dob = integer; //implicit conversion of double to int
            Console.WriteLine("explicit conversion of string to int");
            Console.WriteLine("Integer value: " + integer +"\n");
            Console.WriteLine("explicit conversion of string to double");
            Console.WriteLine("Double value: "+decimalValue + "\n");
            Console.WriteLine("implicit conversion of double to int");
            Console.WriteLine("Integer value :"+dob);
        }
    }
}
