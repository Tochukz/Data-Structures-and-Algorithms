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

    public Node FindNthToLast(int x)
    {
        if (Head == null)
        {
            throw new Exception("The linked list is empty");
        }
        int listLength = 0;
        Node current = Head;
        while(current != null)
        {
            listLength++;
            current = current.Next;
        }
        // Console.WriteLine($"List length: {listLength}");

        if (x > listLength)
        {
            throw new Exception($"x is greater then list length {listLength}");
        }
        
        current = Head;
        int xth = listLength - x;
        for(int i = 0;  i < xth; i++)
        {
          current = current.Next;
        }
        return current;
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
Node thirstLast = linkedList.FindNthToLast(3); 
Console.WriteLine(thirstLast.Data); // 5