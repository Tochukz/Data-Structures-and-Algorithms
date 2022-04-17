/* Implement an algorithm to find the nth to last element of a singly linked list. */

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
            if( i == 0)
            {
                Head = newNode;
                prev = newNode;
            }
            else 
            {
                prev.Next = newNode;
                prev = newNode;
            }
        }
    }

    public int FindNthToLast(int n)
    {
        if (Head == null)
        {
            throw new Exception("The linked list is empty");
        }
        int listLen = 0;
        Node current = Head;
        while(current != null)
        {
            listLen++;
            current = current.Next;
        }

        if (n > listLen)
        {
            return -1;
        }
        
        current = Head;
        int xth = listLen - n;
        for(int i = 0;  i < xth; i++)
        {
          current = current.Next;
        }
        return current.Data;
    }

    public void PrintList()
    {
        if (Head == null)
        {
            Console.WriteLine("The list is empty!");
        }
        Node current = Head;
        while(current != null)
        {
            Console.Write($"{current.Data} ");
            current = current.Next;
        }
        Console.WriteLine("\n");
    }

}

SinglyLinkedList linkedList = new SinglyLinkedList(new int[]{1, 2, 3, 4, 5, 6, 7});
linkedList.PrintList(); // 1 2 3 4 5 6 7
int thirstLast = linkedList.FindNthToLast(3); 
Console.WriteLine(thirstLast); // 5

/**
  Method      | Time Complexity | Space Complexity 
FindNthToLast |     O(n)        |  

Online Resource:
  https://www.geeksforgeeks.org/nth-node-from-the-end-of-a-linked-list/
*/