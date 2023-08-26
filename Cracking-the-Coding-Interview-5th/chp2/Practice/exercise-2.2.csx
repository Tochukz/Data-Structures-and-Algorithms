/**
* Problem: Impelement an algorithm to find the kth to last element of a singly linked list.
*/

using System.Collections.Generic;

class Node {
    public int Data;

    public Node Next;

    public Node(int data) {
        Data = data;
    }
}

class Exercise22 {
    public int FindKthLastElement(Node head, int k) {
      // Write your solution here.
    }

    public Node MakeSingleLinkedList(int[] numbers) {
        Node head = null;
        Node current = null;
        for (int i = 0;  i < numbers.Length; i++) {
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

    public void Test(Dictionary<int[], int[]> testCases) {
        foreach(KeyValuePair<int[], int[]> item in testCases) {
            if (item.Value.Length != 2) {
                throw new Exception("Item value must be number array of 2 elements");
            }
           int[] numbers = item.Key;
           int kth = item.Value[0];
           int expectedResult = item.Value[1];
           Node head = MakeSingleLinkedList(numbers);
           int result = FindKthLastElement(head, kth);
           if (result == expectedResult) {
              Console.WriteLine("Pass!");
           } else {
              Console.WriteLine($"Failed: expected {expectedResult} got {result}");
           }
        }        
    }
}

Exercise22 exercise = new Exercise22();
Dictionary<int[], int[]> testCases = new Dictionary<int[], int[]> {
  {new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, new int[] { 2, 9 }},
  {new int[] {1, 2, 3, 4, 5, 6, 7}, new int[] {3, 5}},
  {new int[] {1, 2, 1, 7, 5, 6, 17, 11}, new int[] {5, 7}}
};
exercise.Test(testCases);
