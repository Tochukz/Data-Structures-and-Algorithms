/**
* Problem: Write code to remove duplicates from an unsorted linked list.
*    A temporal buffer is not allowed.  
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

class Exercise21A {
    public void RemoveDuplicates(Node head) {
       Node previous = null;
       Node current = head;
       while(previous != null) {          
          while(current != null) {
            current = current.Next;
          }
          previous = current;
          current = current.Next;
       }
    }

    public Node MakeSinglyLinkedList(int[] numbers) {
        Node head = null;    
        Node current = null;    
        for (int i = 0; i < numbers.Length; i++) {
            Node newNode = new Node(numbers[i]);
            if (i == 0) {
              head = newNode;
              current = newNode;
              continue;
            }
            current.Next = newNode;
            current = newNode;
        }
        return head;
    }

    public int[] LinkedListToArray(Node head) {       
        List<int> list = new List<int>();
        Node current = head;
        list.Add(current.Data);
        while (current.Next != null) {
            list.Add(current.Next.Data);
            current = current.Next;
        }
        return list.ToArray();
    }

    public void PrintLinkedList(Node head) {
        Node current = head;
        Console.Write("{0} ", current.Data);
        while(current.Next != null) {
           Console.Write("{0} ", current.Next.Data);
           current = current.Next;
        }
    }

    public bool ArrayAreEqual(int[] numbers1, int[] numbers2) {
        if (numbers1.Length != numbers2.Length) {
            return false;
        }
        for (int i = 0; i < numbers1.Length; i++) {
            if( numbers1[i] != numbers2[i]) {
                return false;
            }
        }
        return true;
    }

    public void Test(Dictionary<int[], int[]> testCases) {
        foreach(KeyValuePair<int[], int[]> item in testCases) {
            Node head = MakeSinglyLinkedList(item.Key);
            // PrintLinkedList(head);
            RemoveDuplicates(head);
            int[] numbers = LinkedListToArray(head);
            if (ArrayAreEqual(numbers, item.Value)) {
                Console.WriteLine("Pass!");
            } else {
                Console.WriteLine($"Failed: expected {string.Join(" ", item.Value)} got {string.Join(" ", numbers)}");
            }
        }
    }
}


Exercise21A exercise = new Exercise21A();
Dictionary<int[], int[]> testCases = new Dictionary<int[], int[]> {
  {new int[] { 2, 2, 3, 5, 1, 1, 7, 11, 9, 2}, new int[] {2, 3, 5, 1, 7, 11, 9}},
  {new int[] {7, 5, 5, 5, 8, 7, 6, 2, 1, 1}, new int[] {7, 5, 8, 6, 2, 1}},
  {new int[] {1, 7, 2, 3, 3, 5, 1, 7, 7}, new int[] {1, 7, 2, 3, 5}}
};
exercise.Test(testCases);

