/**
* Problem: Write code to partition a linked list around a value x, such that all nodes less than
*  x come before all nodes greater than or equal to x.
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

class Practice24 {
  public Node PartitionList(Node head, int partitionInt) {
    // Write your solution here
    return head;
  }

  public void PrintList(Node node) {
    Node current = node; 
    while(current != null) {
        Console.Write($"{current.Data} ");
        current = current.Next;
    }
    Console.WriteLine(" ");
  }

  public bool AreEqual(Node head1, Node head2) {
    Node current1 = head1; 
    Node current2 = head2;
    while(current1 != null) {
      if (current2 == null) {
        return false;
      }
      if (current1.Data != current2.Data) {
        return false;
      }
      current1 = current1.Next;
      current2 = current2.Next;
    }
    if (current2 != null) {
      return false;
    }
    return true;
  }

  public void Test(Dictionary<Node[], int> testCases) {
    foreach(KeyValuePair<Node[], int> item in testCases) {
      Node[] list = item.Key;
      Node head = list[0];
      Node expected = list[1];
      int partitionInt = item.Value;
      Node result = PartitionList(head, partitionInt);
      if (AreEqual(result, expected)) {
        Console.WriteLine("Passed!");
      } else {
        Console.WriteLine("Failed!");
        Console.WriteLine(" Expected: ");
        PrintList(expected);
        Console.WriteLine(" Got: ");
        PrintList(result);
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
}

Practice24 practice = new Practice24();

Node list1 = practice.GenerateLinkedList(new int[]{6, 1, 7, 8, 9, 2, 4});
Node listA = practice.GenerateLinkedList(new int[]{1, 2, 4, 6, 7, 8, 9});

Node list2 = practice.GenerateLinkedList(new int[]{4, 7, 1, 2, 5, 3, 1});
Node listB = practice.GenerateLinkedList(new int[]{1, 2, 3, 1, 4, 7, 5});

Node list3 = practice.GenerateLinkedList(new int[]{5, 8, 9, 12, 11, 13, 3, 10, 12});
Node listC = practice.GenerateLinkedList(new int[]{5, 8, 9, 3, 12, 11, 13, 10, 12});

Dictionary<Node[], int> testCases = new Dictionary<Node[], int> {
  {new Node[]{list1, listA}, 5},
  {new Node[]{list2, listB}, 4},
  {new Node[]{list3, listC}, 10},
};
practice.Test(testCases);