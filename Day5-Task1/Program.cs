namespace Day5_Task1
{
    class Node
    {
        public int Data;
        public Node next;
    }

    class CustomLinkedList
    {
        Node New, start = null, last, ptr, prev;
        public CustomLinkedList(int data)
        {
            Node New = new Node();
            New.Data = 0;
            New.next = null;

        }
        public  void InsertAtBeginning(int data)
        {
            if (start == null)
            {
                New = new Node();
                New.Data = data;
                start = last = New;
            }
            else
            {
                New = new Node();
                New.Data = data;
                New.next = start;
                start = New;
            }

        }
        public void InsertAtEnd(int data)
        {
            Node New = new Node();
            New.Data = data;
            for (prev = ptr = start; ptr.next != null; prev = ptr, ptr = ptr.next) ;
            prev.next = null;
            last = prev;
        }
         public void InsertAtPosition(int position, int data)
        {
            Node New = new Node();
            New.Data = data;
            int i;
            for (i = 0, prev = ptr = start;
                ptr.next != null; prev = ptr, ptr = ptr.next, i++)
            {
                if(i==position)
                {
                    prev.next = New;
                    New.next = ptr;
                    break;
                }
            }

        }
        public void DeleteNode(int position)
        {

        }
        public void UpdateNode(int data)
        {
        }
        public void DisplayAllNodes()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}