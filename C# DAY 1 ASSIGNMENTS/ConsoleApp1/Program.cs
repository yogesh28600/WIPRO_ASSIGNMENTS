using System; // .Net Class Library
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // From the below code Convert class is derived from System namespace
            string num = Console.ReadLine(); // Takes input from user
            byte numByte = Convert.ToByte(num); // Converts num to byte
            double dec = Convert.ToDouble(num); // Converts num to double
            int num16 = Convert.ToInt16(num); // Converts num to int16   
            int num32 = Convert.ToInt32(num); // Converts num to int32
        }
    }
}
