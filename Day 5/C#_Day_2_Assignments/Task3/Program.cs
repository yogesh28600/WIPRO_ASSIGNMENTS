using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void nest(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("The number is Zero");
                Console.WriteLine(num);
            }
            else if (num > 0)
            {
                Console.WriteLine("The number is Positive");

                for (int i = num; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("The number is negative");

                for (int i = num; i <= 0; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
