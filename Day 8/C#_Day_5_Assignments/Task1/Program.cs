namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LinkedList linkedList = new LinkedList();
            linkedList.insertFirst(2);
            linkedList.getElements();
            linkedList.insertLast(3);
            linkedList.getElements();
            linkedList.insertFirst(1);
            linkedList.getElements();
            linkedList.insertLast(5);
            linkedList.getElements();
            linkedList.insertAt(3,4);
            linkedList.getElements();
            linkedList.update(3,6);
            linkedList.getElements();
            linkedList.delete(6);
            linkedList.delete(5);
            linkedList.getElements();
        }
    }
}
