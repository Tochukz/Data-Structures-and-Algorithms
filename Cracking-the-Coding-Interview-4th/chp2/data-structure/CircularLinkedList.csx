class Node 
{
    public int Data;

    public Node Next;

    public Node(int data)
    {
        Data = data;
    }
}

class CircularLinkedList 
{
    public Node Head;

    public Node Tail;

    public void AddNode(int data)
    {
        Node newNode = new Node(data);
        if (Head == null)
        { 
            Head = newNode;
            Tail = newNode;
            Tail.Next = Head;
        }
        else 
        {
            Tail.Next = newNode;            
            Tail = newNode;
            Tail.Next = Head;
        }
    }

    public void PrintList()
    {
        if (Head == null)
        {
            Console.WriteLine("The linked list is empty");
        }
        Node current = Head;
        do 
        {
            Console.Write($"{current.Data} ");
            current = current.Next;
        } while(current != Head);
    }
}

CircularLinkedList linkedList = new CircularLinkedList();
linkedList.AddNode(1);
linkedList.AddNode(2);
linkedList.AddNode(3);
linkedList.AddNode(4);
linkedList.AddNode(5);
linkedList.PrintList(); // 1 2 3 4 5