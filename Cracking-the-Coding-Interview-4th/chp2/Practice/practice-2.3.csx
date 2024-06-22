/**
* Problem: Implement an algorithm to delete a node in the middle of a single linked list, given only access to that node.
*          Input: the node ‘c’ from the linked list a->b->c->d->e
*          Result: nothing is returned, but the new linked list looks like a->b->d->e
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

class Practice23 {
  public void DeleteNode(Node node) {
    // Write your solution here
  }

  public bool NodeExist(Node head, int data) {
    Node current = head;
    while(current != null) {
      if (current.Data == data) {
        return true;
      }
      current = current.Next;
    }
    return false;
  }

  public void Test(Dictionary<Node[], int> testCases) {
    foreach(KeyValuePair<Node[], int> item in testCases) {
      Node[] nodes = item.Key;
      Node head = nodes[0];
      Node midNode = nodes[1];
      int valToBeDelete = item.Value;
      DeleteNode(midNode);
      if (!NodeExist(head, valToBeDelete)) {
        Console.WriteLine("Passed!");
      } else {
        Console.WriteLine("Failed!");
        Console.WriteLine($"Node {valToBeDelete} was found in list");
      }
    }
  }

  public Node[] GenerateLinkedListReturnNth(int[] numbers,  int nth) {
    Node toReturn = null;
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
      if (i + 1 == nth) {
        toReturn = newNode;
      }
    }
    return new Node[]{head, toReturn};
  }
}

Practice23 practice = new Practice23();

Node[] headAndMidNode1 = practice.GenerateLinkedListReturnNth(new int[]{1, 2, 3, 7, 9, 1}, 3);
Node[] headAndMidNode2 = practice.GenerateLinkedListReturnNth(new int[]{3, 7, 2, 1, 5, 4}, 5);
Node[] headAndMidNode3 = practice.GenerateLinkedListReturnNth(new int[]{4, 3, 6, 7, 2, 11, 5}, 6);

Dictionary<Node[], int> testCases = new Dictionary<Node[], int> {
  {headAndMidNode1, 3},
  {headAndMidNode2, 5},
  {headAndMidNode3, 11},
};
practice.Test(testCases);
