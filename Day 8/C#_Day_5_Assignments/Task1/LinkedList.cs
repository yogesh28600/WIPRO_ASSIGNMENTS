

namespace Task1
{
    public  class LinkedList
    {
        Node head = null;
        Node tail=null;
        class Node
        {
            private int value;
            public Node next;
            public Node(int value)
            {
                this.value = value;
            }
        }
        public void insertFirst(int value)
        {
            Node node = new Node(value);
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
            Node node = new Node(value);
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
    }
}
