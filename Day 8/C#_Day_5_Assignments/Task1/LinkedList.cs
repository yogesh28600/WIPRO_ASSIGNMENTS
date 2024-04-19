

namespace Task1
{
    public  class LinkedList
    {
        Node head = null;
        Node tail=null;
        class Node
        {
            public int value;
            public Node next;

        }
        public void insertFirst(int value)
        {
            Node node = new Node();
            node.value = value;
            if(head == null)
            {
                head = node;
                tail = node;
            }else
            {
                node.next = head;
                head = node;

            }
        }
        public void insertLast(int value)
        {
            Node node = new Node();
            node.value = value;
            if(tail == null)
            {
                insertFirst(value);
            }
            else
            {
                tail.next = node;
                tail = node;
            }
           
        }
        public void insertAt(int index,int value)
        {
            Node node = new Node();
            node.value = value;
            Node temp = head;
            for(int i = 0; i < index-1; i++)
            {
                temp= temp.next;
            }
            Node node1 = temp.next;
            temp.next = node;
            node.next = node1;
        }
        public void delete(int value)
        {
            Node temp = head;
            while(temp != null && temp.next.value != value)
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;
        }
        public void update(int index,int value)
        {
            Node temp = head;
            for(int i = 0;i< index; i++)
            {
                temp = temp.next;
            }
            temp.value = value;
        }
        public void getElements()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.Write(temp.value + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
