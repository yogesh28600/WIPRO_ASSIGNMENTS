
namespace Task2
{
    public class Stack
    {
        static int[] arr = new int[10];
        static int top = -1;
        public static int push(int num)
        {
            if (top >= arr.Length)
            {
                Console.WriteLine("Index Overflow");
                return -1;
            }
            arr[++top] = num;
            return top;
        }
        public static int pop()
        {
            return arr[top--];
        }
        public static void print()
        {
            for(int i = top; i>=0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
