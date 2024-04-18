using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Day_2_Assignments
{
    //Task 5: Advanced Array Operations
//a)  Implement a C# method SliceArray that takes an array, a starting index, and an end index, then returns a new array containing
//    the elements from the start to the end index.
//b) Create a recursive function in C# to find the nth element of a Fibonacci sequence and store the first n elements in an array.
    internal class Task5
    {
        public static int[] SliceArray(int[] array,int start,int end)
        {
            int[] result = new int[end-start];
            int j = 0;
            for (int i = start; i < end;i++)
            {
                result[j++] = array[i];
            }
            return result;
        }
        public static int fib(int[] array, int n)
        {
            for(int i = 0; i < n; i++)
            {
                array[i] = helper(i);
            }
            return array[n-1];
        }
        private static int helper(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return helper( n - 1) + helper( n - 2);
        }
    }
}
