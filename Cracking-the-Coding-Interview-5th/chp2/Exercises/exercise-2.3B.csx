/**
* Problem: Imeplement an algorithm to delete a node in the middle of a single linked list, given only access to the head. 
*   Example: 
*     Input: the node c from the from the linked list a->b->c->d->e 
*     Result: nothing is returned but the new linked list look like a->b->d->e 
*/

class Node {
    public int Data;

    public Node Next;

    public Node(int data) {
        Data = data;
    }
}


class Exercise23 {
    public void DeleteMiddleNode(Node head) {
        Node prev = null;
        Node singleStep = head;
        Node doubleStep = head;
        while(doubleStep != null) {
            if (doubleStep.Next?.Next == null) {
                prev.Next  = singleStep.Next;
                break;         
            }
            prev = singleStep;
            singleStep = singleStep.Next;
            doubleStep = doubleStep.Next.Next;
        }
    }

    public Node MakeSingleLinkedList(int[] numbers) {
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

    public bool LinkedListsAreEqual(Node head1, Node head2) {
        Node current1 = head1;
        Node current2 = head2;
        while(current1 != null || current2 != null) {
            if (current1 == null) {
                return false;
            }
            if (current2 == null) {
                return false;
            }

            if (current1.Data != current2.Data) {
                return false;
            }
            current1 = current1.Next;
            current2 = current2.Next;
        }
        return true;
    }

    public int[] LinkListToArray(Node head) {
        List<int> list = new List<int>();
        Node current = head;
        while (current != null) {
            list.Add(current.Data);
            current = current.Next;
        }
        return list.ToArray();
    }

    public void Test(Dictionary<int[], int[]> testCases) {
       foreach(KeyValuePair<int[], int[]> item in testCases) {
           Node head1 = MakeSingleLinkedList(item.Key);
           DeleteMiddleNode(head1);
           Node head2 = MakeSingleLinkedList(item.Value);
           if (LinkedListsAreEqual(head1, head2)) {
              Console.WriteLine("Pass!");
           } else {
              int[] arrayResult = LinkListToArray(head1);
              Console.WriteLine($"Failed: expecting {string.Join(" ", item.Value)} got {string.Join(" ", arrayResult)}");
           }
       }
    }
}

Exercise23 exercise = new Exercise23();
Dictionary<int[], int[]> testCases = new Dictionary<int[], int[]> {
     {new int[] {1, 11, 3}, new int[] {1, 3}},
    {new int[] {1, 2, 3, 4, 5}, new int[] {1, 2, 4, 5}},
    {new int[] {1, 5, 6, 2, 1, 4, 11}, new int[] {1, 5, 6, 1, 4, 11}}
};
exercise.Test(testCases);