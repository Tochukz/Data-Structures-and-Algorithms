/**
* Problem: Implement a function to check if a linked list is a palindrome.
* Definition:
*   Now, palindrome means any word or sequence that reads the same forwards as backward.
*   A palindrome linked list is a type of linked list where the elements of the list read the same forwards and backward.
* Example:
*   Original linked list: 1 -> 2 -> 3 -> 2 -> 1
*   If you reverse the linked list, it remains the same: 1 -> 2 -> 3 -> 2 -> 1
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

class Practice27 {
  public bool IsPalindrome(Node head) {
    // Write your solution here
    return false;
  }

  public void PrintList(Node node) {
    Node current = node; 
    while(current != null) {
        Console.Write($"{current.Data} ");
        current = current.Next;
    }
    Console.WriteLine(" ");
  }

  public void Test(Dictionary<Node, bool> testCases) {
    foreach(KeyValuePair<Node, bool> item in testCases) {
      Node head = item.Key;
      bool expectedResult = item.Value;
      bool result = IsPalindrome(head);
      if (result == expectedResult) {
        Console.WriteLine("Passed!");
      } else {
        Console.WriteLine("Failed!");
        Console.WriteLine($" Expected: {expectedResult}");
        Console.WriteLine($" Got: {result}");
        Console.WriteLine("Test List: ");
        PrintList(head);
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

Practice27 practice = new Practice27();
Node list1 = practice.GenerateLinkedList(new int[]{1, 2, 3, 2, 1});
Node list2 = practice.GenerateLinkedList(new int[]{4, 1, 5, 5, 1, 4});
Node list3 = practice.GenerateLinkedList(new int[]{4, 1, 5, 2, 1, 4});
Node list4 = practice.GenerateLinkedList(new int[]{2, 1, 5, 5, 1});

Dictionary<Node, bool> testCases = new Dictionary<Node, bool> {
  {list1, true},
  {list2, true},
  {list3, false},
  {list4, false},
};
practice.Test(testCases);