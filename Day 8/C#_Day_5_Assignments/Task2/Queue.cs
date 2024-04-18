

namespace Task2
{
    internal class Queue
    {
        static int[] arr = new int[10];
        static int front = -1;
        static int rear = -1;
        public static int Push(int num)
        {
            if(front == rear && front < 0)
            {
                front = 0; rear = 0;
                arr[front] = num;
            }
            else if(rear >= arr.Length)
            {
                Console.WriteLine("Index Overflow");
            }
            else
            {
                arr[++rear] = num;
            }
            return rear;
        }
        public static int Pop()
        {
            return arr[front++];
        }
        public static void Print()
        {
            if(front >= arr.Length)
            {
                Console.WriteLine("Queue is Empty");
            }
            for(int i = 0; i<=rear; i++) 
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
