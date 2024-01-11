/**
* Problem: Implement an algorithm to delete a node in the middle of a single linked list, given only access to that node.
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
  public void DeleteNode(Node head) {
    // Write your solution here
  }

  public bool NodeExist(Node head, Node node) {
    Node current = head;
    while(current != null) {
      if (current.Data == node.Data) {
        return true;
      }
      current = current.Next;
    }
    return false;
  }

  public void Test(Dictionary<Node, Node> testCases) {
    foreach(KeyValuePair<Node, Node> item in testCases) {
      DeleteNode(item.Key);
      if (!NodeExist(item.Key, item.Value)) {
        Console.WriteLine("Passed!");
      } else {
        Console.WriteLine("Failed!");
        Console.WriteLine($"Node {item.Value.Data} was found in list");        
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

Practice23 practice = new Practice23();

Node list1 = practice.GenerateLinkedList(new int[]{1, 2, 3, 7, 9, 1});
Node list2 = practice.GenerateLinkedList(new int[]{3, 7, 2, 1, 5, 4});
Node list3 = practice.GenerateLinkedList(new int[]{4, 3, 6, 7, 2, 11, 5});

Dictionary<Node, Node> testCases = new Dictionary<Node, Node> {
  {list1, new Node(3)},
  {list2, new Node(5)},
  {list3, new Node(11)},
};
practice.Test(testCases);