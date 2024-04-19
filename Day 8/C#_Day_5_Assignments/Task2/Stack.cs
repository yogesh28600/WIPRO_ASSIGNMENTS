
namespace Task2
{
    public class Stack
    {
        static int[] arr = new int[10];
        static int top = -1;
        public  int push(int num)
        {
            if (top >= arr.Length)
            {
                Console.WriteLine("Index Overflow");
                return -1;
            }
            arr[++top] = num;
            return top;
        }
        public  int pop()
        {
            return arr[top--];
        }
        public int peek()
        {
            return arr[top];
        }
        public bool isEmpty()
        {
            bool flag = (top == -1) ?  true :  false;
            return flag;
        }
        public void getElements()
        {
            for(int i = top; i>=0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
