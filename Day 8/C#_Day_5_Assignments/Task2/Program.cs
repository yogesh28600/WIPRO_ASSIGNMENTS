namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            queue.getElements();
            queue.dequeue();
            queue.getElements();

            //Stack stack = new Stack();
            //stack.push(1);
            //stack.getElements();
            //stack.push(2);
            //stack.getElements();
            //stack.push(3);
            //stack.getElements();
            //stack.push(4);
            //stack.getElements();
            //stack.pop();
            //stack.getElements();
            //Console.WriteLine(stack.isEmpty());
        }
    }
}
