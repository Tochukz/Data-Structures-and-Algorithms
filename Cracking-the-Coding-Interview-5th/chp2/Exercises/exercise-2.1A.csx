/**
* Problem: Write code to remove duplicates from an unsorted linked list.
*/

using System;
using System.Collections.Generic;

class Node {
    int Data;

    Node next;

    public Node(int data) {
        Data = data;
    }
}

class Exercise21A {
    public void RemoveDuplicates(Node head) {
        HashSet<int> set = new HashSet<int>();
        Node current = head;
        while(current.Next != null) {
            int data = current.Next.Data;
            if (set.Contains(data)) {
               current.Next = current.Next.Next;
            } else {
                set.Add(data)
            }
            current = current.Next;
        }
        return head;
    }

    public Node MakeSinglyLinkedList(int[] numbers) {
        Node head;    
        Node current;    
        for (int i = 0; i < numbers.Length; i++) {
            Node newNode = new Node(numbers[i])
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
        list.Add(current.Data)
        while (current.Next ! = null) {
            list.Add(current.Next.Data);
            current = current.Next;
        }
        return list.ToArray();
    }

    public void Test(Dictionary<int>)
}


