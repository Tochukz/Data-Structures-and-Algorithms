
/**
Problem: Copy linked list with arbitrary pointer
  You are given a linked list where the node has two pointers. The first is the regular next pointer. 
  The second pointer is called arbitrary_pointer and it can point to any node in the linked list. Your job is to write code to make a deep copy of the given linked list. Here, deep copy means that any operations on the original list should not affect the copied list.

Constraint: 
  Runtime Complexity: Linear, O(n)
  Memory Complexity: Linear, O(n)
*/

using System.Collections.Generic;

class Node
{
    public int Data;

    public Node Next;

    public Node Arbitrary;

    public Node(int data)
    {
        Data  = data;
    }
}

class Excerise4
{
   public static Node Copy(Node head)
   {
      Dictionary<Node, Node> dict = new Dictionary<Node, Node>();

      Node copyHead = null;
      Node copyPrev = null;

      Node current = head;
      while(current != null)
      {
          Node newNode = new Node(current.Data);
          newNode.Arbitrary = current.Arbitrary;
          dict.Add(current, newNode);

          if (copyPrev == null)
          {
              copyHead = newNode;
              copyPrev = newNode;
          }
          else
          {
              copyPrev.Next = newNode;
              copyPrev = newNode;
          }
       
          current = current.Next;
      }

      current = copyHead;
      while(current != null)
      {
          if (current.Arbitrary != null)
          {
              current.Arbitrary = dict[current.Arbitrary];
          }
          current = current.Next;
      }
      return copyHead;
   }

   public static void PrintList(Node head)
   {
      while(head != null)
      {
          Console.Write($"{head.Data}");
          if (head.Arbitrary != null)
          {
              Console.Write($"({head.Arbitrary.Data}) ");
          }
          else 
          {
               Console.Write("(Null) ");
          }
          head = head.Next;
      }
      Console.Write("\n");
   }
}

Node head1 = new Node(7);
Node node2 = new Node(14);
Node node3 = new Node(21);

head1.Next = node2;
node2.Next = node3;

head1.Arbitrary = node3;
node3.Arbitrary = head1;

Node head2 = Excerise4.Copy(head1);

Excerise4.PrintList(head1);
Excerise4.PrintList(head2);

head2.Arbitrary = null;
head2.Next.Data = 5;

Console.WriteLine();

Excerise4.PrintList(head1);
Excerise4.PrintList(head2);


/**
Output: 
  7(21) 14(Null) 21(7) 
  7(21) 14(Null) 21(7)

  7(21) 14(Null) 21(7)
  7(Null) 5(Null) 21(7)

Online Exercise: 
  https://www.educative.io/m/copy-linked-list-with-arbitrary-pointer
*/