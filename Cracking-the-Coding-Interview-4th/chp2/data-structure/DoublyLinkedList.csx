class Node 
{
    public int Data;

    public Node Prev;

    public Node Next;

    public Node(int data)
    {
        Data = data;       
    }
}

class DoublyLinkedList
{
    public Node Head = null;

    public DoublyLinkedList(int[] numbers = null)
    {
        if (numbers == null) 
        {
            return;
        }
        Node previous = null;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0) 
            {
                previous = new Node(numbers[i]);
                Head = previous;
            } else {
                Node current = new Node(numbers[i]);
                previous.Next = current;
                current.Prev = previous;
                previous = current;
            }              
        }
    }

    public void PrintList()
    {
        Node current = Head;
        while(current != null)
        {
            Console.Write($"{current.Data} ");
            current = current.Next;
        }
        Console.WriteLine("\n");
    }

    public Node InsertAtBegining(int data)
    {
        if (Head == null)
        {
            Head = new Node(data);
            return Head;
        }
        Node newNode = new Node(data);
        Head.Prev = newNode;
        newNode.Next = Head;
        Head = newNode;
        return newNode;
    }

    public Node InsertAtEnd(int data)
    {
        if (Head == null)
        {
            Head = new Node(data);
            return Head;
        }
        Node current = Head;
        while(current.Next != null)
        {
            current = current.Next;
        }
        Node newNode = new Node(data);
        current.Next = newNode;
        newNode.Prev = current;
        return newNode;
    }
    public Node InsertBefore(Node targetNode, int data)
    {
        if (targetNode == null)
        {
            throw new Exception("Target node should not be null");
        }
        Node newNode = new Node(data);
        if (targetNode.Prev != null)
        {
            targetNode.Prev.Next = newNode;
        }
        targetNode.Prev = newNode;
        newNode.Next = targetNode;
        newNode.Prev = targetNode.Prev;
        if (targetNode == Head)
        {
            Head = newNode;
        }
        return newNode;
    }

    public Node InsertAfter(Node targetNode, int data)
    {
        if (targetNode == null)
        {
            throw new Exception("The target node should not be null");
        }
        Node newNode = new Node(data);
        if (targetNode.Next != null)
        {
            targetNode.Next.Prev = newNode;
        }        
        newNode.Prev = targetNode;
        newNode.Next = targetNode.Next;
        targetNode.Next = newNode;
        return newNode;
    }

    public void DeleteNode(Node targetNode)
    {
        if (targetNode == null)
        {
            throw new Exception("Target node should not be null");
        }

        if (targetNode == Head)
        {
            Head = targetNode.Next;
            if (targetNode.Next != null)
            {
                targetNode.Next.Prev = null;
            }    
            return;    
        }

        if (targetNode.Next != null)
        {
            targetNode.Next.Prev = targetNode.Prev;
        }
        if (targetNode.Prev != null)
        {
            targetNode.Prev.Next = targetNode.Next;
        } 
    }

    public void DeleteNodeX(int x)
    {
        if (Head == null)
        {
            throw new Exception("The linked list is empty");
        }
        if (x < 1)
        {
            throw new Exception("The DeleteNodeX implementation is NOT for 0 bases index linked list");
        }
        else if (x == 1) 
        {
            Head = Head.Next;
            if (Head != null)
            {
                Head.Prev = null;
            }
            return;
        }
        int i = 1;
        Node current = Head;
        while(current != null)
        {
            if (i == x) 
            {
                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                if (current.Prev != null)
                {
                    current.Prev.Next = current.Next;
                }
                break;
            }
            current = current.Next;
            i++;
        }
    }
}

DoublyLinkedList linkedList = new DoublyLinkedList(new int[]{5, 7, 9});

/* Insertion Operation */
linkedList.PrintList(); //  5 7 9 
linkedList.InsertAtBegining(3);
linkedList.InsertAtBegining(1);
linkedList.PrintList(); // 1 3 5 7 9

Node node3 = linkedList.Head.Next;
linkedList.InsertAfter(node3, 4);
linkedList.PrintList(); // 1 3 4 5 7 9

Node node10 = linkedList.InsertAtEnd(10);
linkedList.PrintList(); // 1 3 4 5 7 9 10


linkedList.InsertBefore(node3, 2);
linkedList.InsertBefore(linkedList.Head, 0);
linkedList.PrintList(); // 0 1 2 3 4 5 7 9 10

/* Deletion operation */
linkedList.DeleteNode(linkedList.Head);
linkedList.DeleteNode(node3);
linkedList.DeleteNode(node10);
linkedList.PrintList(); // 1 2 4 5 7 9

linkedList.DeleteNodeX(1);
linkedList.DeleteNodeX(3); 
linkedList.DeleteNodeX(4);
linkedList.PrintList(); // 2 4 7

/**
 Method                                 | Time Complexity | Space Complexity | Desciption
 DoublyLinkedList.DeleteNode()          | O(1)            | O(1)             | it's time and space complexity are both contant 
 DoublyLinkedList.DeleteNodeX()         | O(n)            | O(1)             | Where n is the numbr of nodes in the linked list
 */