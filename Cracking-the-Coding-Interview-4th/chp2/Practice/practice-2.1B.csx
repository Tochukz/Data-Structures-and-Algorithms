/**
* Problem: Write code to remove duplicates from an unsorted linked list without using a temporary buffer
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

class Practice21B {
  public void RemoveDuplicate(Node head) {
    // Write your solution here
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

  public void PrintList(Node node) {
    Node current = node; 
    while(current != null) {
        Console.Write($"{current.Data} ");
        current = current.Next;
    }
    Console.WriteLine(" ");
  }

  public void Test(Dictionary<Node, Node> testCases) {
    foreach(KeyValuePair<Node, Node> item in testCases) {
      RemoveDuplicate(item.Key);
      if (AreEqual(item.Key, item.Value)) {
        Console.WriteLine("Passed!");
      } else {
        Console.WriteLine("Failed!");
        Console.WriteLine(" Expected: ");
        PrintList(item.Value);
        Console.WriteLine(" Got: ");
        PrintList(item.Key);
        Console.WriteLine(" ");
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

Practice21B practice = new Practice21B();

Node list1 = practice.GenerateLinkedList(new int[]{1, 2, 3, 2, 7, 3, 9, 1, 1});
Node listA = practice.GenerateLinkedList(new int[]{1, 2, 3, 7, 9});

Node list2 = practice.GenerateLinkedList(new int[]{3, 7, 2, 2, 7, 1, 1, 5, 4, 3});
Node listB = practice.GenerateLinkedList(new int[]{3, 7, 2, 1, 5, 4});

Node list3 = practice.GenerateLinkedList(new int[]{4, 3, 6, 7, 2, 11, 7, 5, 2, 5});
Node listC = practice.GenerateLinkedList(new int[]{4, 3, 6, 7, 2, 11, 5});

Node list4 = practice.GenerateLinkedList(new int[]{3, 3});
Node listD = practice.GenerateLinkedList(new int[]{3});
Dictionary<Node, Node> testCases = new Dictionary<Node, Node> {
  {list1, listA},
  {list2, listB},
  {list3, listC},
  {list4, listD},
};
practice.Test(testCases);