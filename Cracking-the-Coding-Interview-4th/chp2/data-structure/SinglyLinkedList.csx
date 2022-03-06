
 public class Node 
{
    public int Data;

    public Node Next;

    public Node (int data) 
    {
        Data = data;         
    }
}

public class SinglyLinkedList 
{
    public Node Head = null;

    public void PrintList()
    {
       Node current = Head;
       while(current != null)
       {
           Console.Write(current.Data + " ");           
           current = current.Next;
       }
       Console.WriteLine("\n");
    }

    public void InsertAtBeginning(int data)
    {
        if (Head == null)
        {
          Head = new Node(data);
          return;
        }
        Node newHead = new Node(data);
        newHead.Next = Head;
        Head = newHead;
    }

    public void InsertAfter(Node targetNode, int data)
    {
        if (targetNode == null)
        {
            throw new Exception("Target Node cannot be null");
        }
        Node newNode = new Node(data);
        newNode.Next = targetNode.Next;
        targetNode.Next = newNode;
    }

    public void InsertAtEnd(int data)
    {
        if (Head == null)
        {
          Head = new Node(data);
          return;
        }
        Node current = Head;
        while(current.Next != null)
        {
            current = current.Next;
        }
        current.Next = new Node(data);
    }

    /**
    * Deletes the first occurance of the Node with the given data as key
    */
    public void DeleteNode(int data)
    { 
        if (Head == null)
        {
            throw new Exception("The linked list is empty.");
        }

        Node previous = null;
        Node current = Head;
        if (current.Data == data)
        {
            Head = current.Next;
            return;
        }

        while(current != null) 
        {
            if (current.Data == data && previous !=  null) 
            {
                previous.Next = current.Next;
                break;
            }
            previous = current;
            current = current.Next;
        }
        
    }

    /**
    * Delete first occurance of the Node with the given data using recursive method
    */
    public void DeleteByRecursion(int data, Node previous = null)
    {
        if (Head == null)
        {
            throw new Exception("The linked list is empty.");
        }
        if (Head.Data == data)
        {
            Head = Head.Next;
        }

        if (previous == null)
        {
            previous = Head;
        }
        Node current = previous.Next;
        if (current != null && current.Data == data)
        {
            previous.Next = current.Next;
        }
        else if (previous.Next != null)
        {
            DeleteByRecursion(data, previous.Next);
        }
    }

    public void DeleteNodeX(int x)
    {
        if (Head == null)
        {
            throw new Exception("The lined list is empty");
        }

        if(x == 0)
        {
            Head = Head.Next;
            return;
        }

        Node previous = null;
        Node current = Head;
        int i = 0;
        while(current.Next != null)
        {
            if (i == x && previous != null)
            {
                previous.Next = current.Next;
                break;
            }
            previous = current;
            current = current.Next;
            i++;
        }
    }
}

SinglyLinkedList linkedList = new SinglyLinkedList();

Node first = new Node(1);
Node third = new Node(3);
Node fifth = new Node(5);

linkedList.Head = first;
first.Next = third;
third.Next = fifth;

linkedList.PrintList(); // 1 3 5 

/* Insertion Operations */
linkedList.InsertAtBeginning(0);
linkedList.InsertAfter(first, 2);
linkedList.InsertAfter(third, 4);
linkedList.InsertAtEnd(6);
linkedList.InsertAtEnd(7);
linkedList.InsertAtEnd(8);
linkedList.PrintList(); // 0 1 2 3 4 5 6 7 8

/* Deletion Operation */
linkedList.DeleteNode(0);
linkedList.PrintList(); // 1 2 3 4 5 6 7 8
linkedList.DeleteNode(5); 
linkedList.PrintList(); // 1 2 3 4 6 7 8

/* Delete Operation using Recusive method */
linkedList.DeleteByRecursion(1);
linkedList.PrintList(); // 2 3 4 6 7 8
linkedList.DeleteByRecursion(4);
linkedList.PrintList(); // 2 3 6 7 8

/* Delete by Node position*/
linkedList.DeleteNodeX(2);
linkedList.PrintList(); // 2 3 7 8
linkedList.DeleteNodeX(0);
linkedList.PrintList(); // 3 7 8

/**
 Method                                 | Time Complexity 
 SinglyLinkedList.InsertAtBeginning()   | O(1)
 SinglyLinkedList.InsertAfter()         | O(1)
 SinglyLinkedList.InsertAtEnd()         | O(n) where n is number of Nodes in the lined list

Complexity of O(1) means it does a constant amount of work. Or the time complexity is constant

The SinglyLinkedList.InsertAtEnd() can also be optimized to work in O(1) by keeping an extra pointer to the tail of the linked list.
*/