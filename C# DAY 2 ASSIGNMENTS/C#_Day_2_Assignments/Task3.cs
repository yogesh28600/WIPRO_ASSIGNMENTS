namespace C__Day_2_Assignments
{
    internal class Task3
    {
        //Write a C# application that uses nested if-else statements to classify a number as positive, negative,
        //or zero, and then iterates from that number to zero using a for loop, printing each number to the console.
        static void Main(string[] args)
        {
            nest(-5);
        }

        static void nest(int num)
        {
            if(num == 0)
            {
                Console.WriteLine("The number is Zero");
                Console.WriteLine(num);
            }else if(num > 0) 
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
