/**
Problem: You have two numbers represented by a linked list, where each node contains a single digit. 
    The digits are stored in reverse order, such that the 1’s digit is at the head of the list.
    Write a function that adds the two numbers and returns the sum as a linked list.
    EXAMPLE
    Input: (3 -> 1 -> 5) + (5 -> 9 -> 2)
    Output: 8 -> 0 -> 8
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
  public Node AddLists(Node head1, Node head2) {
    // Write your solution here
    return GenerateLinkedList(new int[]{0, 0, 0});
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

  public void Test(Dictionary<Node[], Node> testCases) {
    foreach(KeyValuePair<Node[], Node> item in testCases) {
      Node[] heads = item.Key;
      Node head1 = heads[0];
      Node head2 = heads[1];
      Node sum = AddLists(head1, head2);
      if (AreEqual(sum, item.Value)) {
        Console.WriteLine("Passed!");
      } else {
        Console.WriteLine("Failed!");
        Console.WriteLine(" Expected: ");
        PrintList(item.Value);
        Console.WriteLine(" Got: ");
        PrintList(sum);
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

Node list1 = practice.GenerateLinkedList(new int[]{3, 1, 5});
Node list2 = practice.GenerateLinkedList(new int[]{5, 9, 2});
Node sumA = practice.GenerateLinkedList(new int[]{8, 0, 8});

Node list3 = practice.GenerateLinkedList(new int[]{6, 6, 7});
Node list4 = practice.GenerateLinkedList(new int[]{1, 9, 2});
Node sumB = practice.GenerateLinkedList(new int[]{7, 5, 0, 1});

Node list5 = practice.GenerateLinkedList(new int[]{0, 6, 7});
Node list6 = practice.GenerateLinkedList(new int[]{1, 3, 2});
Node sumC = practice.GenerateLinkedList(new int[]{1, 9, 9});

Dictionary<Node[], Node> testCases = new Dictionary<Node[], Node> {
  {new Node[]{list1, list2}, sumA},
  {new Node[]{list3, list4}, sumB},
  {new Node[]{list5, list6}, sumC},
};
practice.Test(testCases);