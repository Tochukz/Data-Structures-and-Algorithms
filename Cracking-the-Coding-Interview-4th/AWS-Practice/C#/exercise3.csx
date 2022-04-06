/**
Problem: Merge two sorted linked lists
  Given two sorted linked lists, merge them so that the resulting linked list is also sorted. 

Constraint: 
 Runtime Complexity: Linear, O(m + n)
   where m and n are lengths of both linked lists
 Memory Complexity: Constant, O(1)
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

class LinkedList
{
    public static Node Merge(Node head1, Node head2)
    {
        if (head1 == null || head2 == null)
        {
            return null;
        }
        Node head = null;
        Node previous = null;
        Node current = null;
        while(head1 != null || head2 != null)
        {
            if (previous == null)
            {
               if (head1.Data < head2.Data)
               {                 
                  head = head1;
                  previous = head;
                  head1 = head1.Next;
               }
               else
               {                  
                   head = head2;
                   previous = head;
                   head2 = head2.Next;
               }
            }
            else if (head1 != null && head2 != null)
            {
               if (head1.Data < head2.Data)
               {
                  previous.Next = head1;
                  current = head1;
                  head1 = head1.Next;
               }
               else
               {
                  previous.Next = head2;
                  current = head2;
                  head2 = head2.Next;
               }
               
            }
            else if (head2 == null)
            {
               previous.Next = head1;
               current = head1;
               head1 = head1.Next;
            }
            else if (head1 == null)
            {
              previous.Next = head2;
              current = head2;
              head2 = head2.Next;
            }

            
            if (current != null)
            {
                previous = current;
            }
        }

        return head;
    }

    public static void PrintList(Node head)
    {
        while(head != null)
        {
            Console.Write($"{head.Data} ");
            head = head.Next;
        }
        Console.Write("\n");
    }
}

Node head1 = new Node(4);
head1.Next = new Node(8);
head1.Next.Next = new Node(15);
head1.Next.Next.Next = new Node(19);
LinkedList.PrintList(head1);

Node head2 = new Node(7);
head2.Next = new Node(9);
head2.Next.Next = new Node(10);
head2.Next.Next.Next = new Node(16);
LinkedList.PrintList(head2);

Node merged = LinkedList.Merge(head1, head2);
LinkedList.PrintList(merged);

/**
 Output: 
  4 8 15 19 
  7 9 10 16
  4 7 8 9 10 15 16 19

Online Exercise: 
  https://www.educative.io/m/merge-two-sorted-linked-lists
*/