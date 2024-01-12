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

class Practice25 {
  public Node FindNodeAtLoopBegining(Node head) {
    // Write your solution here
    return new Node(0);
  }

  public void Test(Dictionary<Node, Node> testCases) {
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
      }
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
          default: 
            current.Next = head.Next;
            break;
        }
        repeatNode = current.Next;
        Console.WriteLine($"Repeat Node1 is {repeatNode.Data}");
        break;
      }
      current = current.Next;
    }
    return repeatNode;
  }
}

Practice25 practice = new Practice25();

Node list1 = practice.GenerateLinkedList(new int[]{1, 2, 3, 4, 5});
Node repeatNode1 = practice.MakeListCicular(list1, 2);

Node list2 = practice.GenerateLinkedList(new int[]{6, 7, 8, 9, 10, 11, 12});
Node repeatNode2 = practice.MakeListCicular(list2, 4);

Node list3 = practice.GenerateLinkedList(new int[]{3, 4, 5, 6, 7, 8});

Dictionary<Node, Node> testCases = new Dictionary<Node, Node> {
  {list1, repeatNode1},
  {list2, repeatNode2},
  {list3, null},
};
practice.Test(testCases);