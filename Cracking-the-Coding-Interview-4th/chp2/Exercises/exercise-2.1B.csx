/* Write code to remove duplicates from an unsorted linked list without using a temporary buffer */

class Node 
{
    public int Data;

    public Node Next;

    public Node(int data)
    {
        Data = data;
    }
}

class SinglyLinkedList 
{
    public Node Head;

    public SinglyLinkedList(int[] numbers)
    {       
        Node prev = null;
        for(int i = 0; i < numbers.Length; i++)
        {
            Node newNode = new Node(numbers[i]);
            if (i == 0)
            {
               prev = newNode;
               Head = newNode;
            }
            else
            {
                prev.Next = newNode;
                prev = newNode;
            }                        
        }
    }

    public void PrintList()
    {
        if (Head == null)
        {
            throw new Exception("The linked list is empty");
        }
        Node current = Head;
        while(current != null)
        {
            Console.Write($"{current.Data} ");
            current = current.Next;
        }
        Console.WriteLine("\n");
    }

    public void RemoveDuplicate()
    {
        if (Head == null)
        {
            throw new Exception("The linked list is empty");
        }
        Node runningNode = Head;
        while (runningNode != null)
        {   
            Node prevNode = null;
            Node currentNode = runningNode.Next;
            while (currentNode != null)
            {
                if (runningNode.Data == currentNode.Data)
                {
                    if (prevNode == null)
                    {
                        runningNode.Next = currentNode.Next;
                    }
                    else 
                    {
                        prevNode.Next = currentNode.Next;
                    }
                }
                else 
                {
                    prevNode = currentNode;                    
                }
                currentNode = currentNode.Next;
            }
            runningNode = runningNode.Next;
        }
    }
}

SinglyLinkedList linkedList = new SinglyLinkedList(new int[]{ 1, 7, 2, 3, 3, 5, 1, 7, 7});
linkedList.PrintList(); // 1 7 2 3 3 5 1 7 7
linkedList.RemoveDuplicate();
linkedList.PrintList(); // 1 7 2 3 5
