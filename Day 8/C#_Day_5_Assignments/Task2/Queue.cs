

namespace Task2
{
    internal class Queue
    {
        static int[] arr = new int[10];
        static int front = -1;
        static int rear = -1;
        public  int enqueue(int num)
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
        public  int dequeue()
        {
            return arr[front++];
        }
        public int peek()
        {
            return arr[front];
        }
        public bool isEmpty()
        {
            if(front == rear && front < 0)
            {
                return true;
            }
            return false;
        }
        public  void getElements()
        {
            if(front >= arr.Length)
            {
                Console.WriteLine("Queue is Empty");
            }
            for(int i = front; i<=rear; i++) 
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
