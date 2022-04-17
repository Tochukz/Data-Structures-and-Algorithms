/**
Problem: You have two numbers represented by a linked list, where each node contains a single digit. 
    The digits are stored in reverse order, such that the 1’s digit is at the head of the list. Write a function that adds the two numbers and returns the sum as a linked list.
    EXAMPLE
    Input: (3 -> 1 -> 5) + (5 -> 9 -> 2)
    Output: 8 -> 0 -> 8
*/

class Node 
{
    public int Data;

    public Node Next;

    public Node(int data)
    {
        Data = data;
    }
}

class Exercise24
{
   public static Node AddLists(Node head1, Node head2)
   {
       Node current1 = head1;
       Node current2 = head2;
       Node head = null; 
       Node current = null;
       int x1;
       int x2;
       int x;
       int carryOver = 0;
       while(current1 != null || current2 != null)
       {
           x1 = 0;
           x2 = 0;
           if (current1 != null)
           {
              x1 = current1.Data;
              current1 = current1.Next;
           }
           if (current2 != null)
           {
              x2 = current2.Data; 
              current2 = current2.Next;
           }

           x = x1 + x2 + carryOver;
           if (x >= 10)
           {
               carryOver = x / 10;
               x = x % 10;
           }
           else
           {
               carryOver = 0;
           }

           if (head == null)
           {
               head = new Node(x);
               current = head;
           }
           else 
           {
               Node node = new Node(x);
               current.Next = node;
               current = node;
           }
       }

       if (carryOver > 0)
       {
           Node node = new Node(carryOver);
           current.Next = node;
       }
       return head;
    }

    public static void PrintList(Node head)
    {
        Node current = head;
        while(current != null)
        {
            Console.Write($"{current.Data}");
            current = current.Next;
        }
        Console.Write(" ");
    }
}

Node head1 = new Node(3);
head1.Next = new Node(1);
head1.Next.Next = new Node(5);

Node head2 = new Node(5);
head2.Next = new Node(9);
head2.Next.Next = new Node(2);

Node head = Exercise24.AddLists(head1, head2);

Exercise24.PrintList(head1);
Console.Write(" + ");
Exercise24.PrintList(head2);
Console.Write(" = ");
Exercise24.PrintList(head);

/**
This problem is similar to the one in ExerciseB.java. 
The only difference is that the other requires thats the addition starts from the end of the lists and not the start. 
In that case a reversal of the list may be needed. 

Output:  
  315  + 592  = 808 
*/