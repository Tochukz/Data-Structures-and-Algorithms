/**
* Problem: Implement an algorithm to find the nth to last element of a singly linked list.
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

class Practice22 {
  public int FindNthToLast(Node head, int n) {
    // Write your solution here
    return 0;
  }

  public void Test(Dictionary<Node, int[]> testCases) {
    foreach(KeyValuePair<Node, int[]> item in testCases) {
      int[] values = item.Value;
      int nth = values[0];
      int expectedVal = values[1]; 
      int nthLast = FindNthToLast(item.Key, nth);
      
      if (expectedVal == nthLast) {
        Console.WriteLine("Passed!");
      } else {
        Console.WriteLine("Failed!");
        Console.WriteLine($"Expected {expectedVal} got {nthLast} ");        
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

Practice22 practice = new Practice22();

Node list1 = practice.GenerateLinkedList(new int[]{1, 2, 3, 2, 7, 3, 9, 1, 1});
Node list2 = practice.GenerateLinkedList(new int[]{3, 7, 2, 2, 7, 1, 1, 5, 4, 3});
Node list3 = practice.GenerateLinkedList(new int[]{4, 3, 6, 7, 2, 11, 7, 5, 2, 5});

Dictionary<Node, int[]> testCases = new Dictionary<Node, int[]> {
  {list1, new int[]{2, 1}},
  {list2, new int[]{3, 5}},
  {list3, new int[]{4, 7}},
};
practice.Test(testCases);