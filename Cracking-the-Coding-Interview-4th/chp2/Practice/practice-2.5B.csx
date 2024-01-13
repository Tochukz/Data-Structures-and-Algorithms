/**
Problem: 
  Given a circular linked list, implement an algorithm which returns node at the beginning of the loop.
  If the list is not a circular list, return null. 
Definition:
  Circular linked list: A (corrupt) linked list in which a node’s next pointer points to an earlier node, so as to make a loop in the linked list.
Example:
  input: A -> B -> C -> D -> E -> C [the same C as earlier]
  output: C
  
*/
using System;
using System.Collections.Generic;

class Node {
  public int Data;

  public Node Next;

  public Node(int data) {
    Data = data;
  }
}

class Practice25B {
  public Node FindNodeAtLoopBegining(Node head) {
    // Write your solution here
    return new Node(0);
  }

  public void Test(Dictionary<Node, Node> testCases, int[] listCounts) {
    int i = 0;
    foreach(KeyValuePair<Node, Node> item in testCases) {
      Node head = item.Key;
      Node expectNode = item.Value;
      Node result = FindNodeAtLoopBegining(head);
      if (expectNode == result) {
        Console.WriteLine("Passed!");
      } else {
        Console.WriteLine("Failed!");
        if (expectNode == null) {
          Console.WriteLine($" Expected: null");
        } else {
          Console.WriteLine($" Expected: Node({expectNode.Data})");
        }
        Console.WriteLine($" Got: Node({result.Data})");
        Console.WriteLine("Test List: ");
        PrintCircularList(head, listCounts[i]);
      }
      i++;
    }
  }

  public Node GenerateLinkedList(int[] numbers) {
    Node head = null;
    Node current = null;
    for (int i = 0; i < numbers.Length; i++) {
      Node newNode = new Node(numbers[i]);
      if (i == 0) {
        head = newNode;
        current = head;
      } else {
         current.Next = newNode;
         current = newNode;
      }
    }
    return head;
  }

  public void PrintCircularList(Node head, int len) {
    Node current = head;
    for(int i  = 0; i < len; i++) {
      Console.Write($"{current.Data} ");
      current = current.Next;
    }
    Console.WriteLine("");
  }

  public Node MakeListCicular(Node head, int repeatIndex) {
    Node current = head;
    Node repeatNode = null;
    while(current != null) {
      if (current.Next == null) {
        switch(repeatIndex) {
          case 2: 
            current.Next = head.Next.Next;
            break;
          case 4: 
            current.Next = head.Next.Next.Next.Next;
            break;
          case 6: 
            current.Next = head.Next.Next.Next.Next.Next.Next;
            break;
          default: 
            Console.WriteLine($"Invalid data: RepeatIndex {repeatIndex} not yet implemented!");
            System.Environment.Exit(1);
            break;
        }
        repeatNode = current.Next;
        Console.WriteLine($"Repeat Node is {repeatNode.Data}");
        break;
      }
      current = current.Next;
    }
    return repeatNode;
  }
}

Practice25B practice = new Practice25B();

int[] numbers1 = new int[]{1, 2, 3, 4, 5};
Node list1 = practice.GenerateLinkedList(numbers1);
Node repeatNode1 = practice.MakeListCicular(list1, 2);

int[] numbers2 = new int[]{6, 7, 8, 9, 10, 11, 12};
Node list2 = practice.GenerateLinkedList(numbers2);
Node repeatNode2 = practice.MakeListCicular(list2, 4);

int[] numbers3 = new int[]{3, 4, 5, 6, 7, 8};
Node list3 = practice.GenerateLinkedList(numbers3);

int[] numbers4 = new int[]{4, 5, 7, 8, 9, 10, 11, 12, 13, 14};
Node list4 = practice.GenerateLinkedList(numbers4);
Node repeatNode4 = practice.MakeListCicular(list4, 6);

// practice.PrintCircularList(list1, 6);
Dictionary<Node, Node> testCases = new Dictionary<Node, Node> {
  {list1, repeatNode1},
  {list2, repeatNode2},
  {list3, null},
  {list4, repeatNode4},
};
int[] listCounts = new int[] {
  numbers1.Length + 1,
  numbers2.Length + 1,
  numbers3.Length,
  numbers4.Length + 1,
};
practice.Test(testCases, listCounts);