/**
Problem: Reverse a linked list  
   Given pointer to the head node of a linked list, the task is to reverse the linked list. 
   We need to reverse the list by changing the links between nodes.
*/

class Node 
{
    public int Data; 

    public Node Next;

    public Node(int data)
    {
        Data = data;
    }
}

class ExerciseA
{
    public Node MakeLinkedList(int[] numbers)
    {
        Node head = new Node(numbers[0]);
        Node current = head;
        Node node;
        for(int i = 1; i < numbers.Length; i++)
        {
            node = new Node(numbers[i]);
            current.Next = node;
            current = node;
        }
        return head;
    }
     
    /* Using recusive method to reverse the linkes lists */
    public Node Reverse(Node head)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }

        Node rest = Reverse(head.Next);
        head.Next.Next = head;

        head.Next = null;
        return rest;
    }
    
    
    /* Using Stack to revese the linked list */
    public void Reverse2(Node head)
    {
        Stack<int> stack  = new Stack<int>();
        Node current = head;
        while(current != null)
        {
            stack.Push(current.Data);
            current = current.Next;
        }

        int data;
        current = head;
        while(stack.Count > 0)
        {
            data = stack.Pop();
            current.Data = data;
            current = current.Next;
        }
    }

    public void PrintList(Node head)
    {
        Node current = head;
        while(current != null)
        {
            Console.Write($"{current.Data} ");
            current = current.Next;
        }
        Console.Write("\n");
    }
}

int[] list1 = {1, 2,  3, 4, 5, 6, 7, 8, 9, 10};
int[] list2 = {20, 19, 18, 17, 16, 15, 14, 13, 12, 11};

ExerciseA exer = new ExerciseA();
Node head1 = exer.MakeLinkedList(list1);
Node head2 = exer.MakeLinkedList(list2);

exer.PrintList(head1);
head1 = exer.Reverse(head1);
exer.PrintList(head1);

exer.PrintList(head2);
exer.Reverse2(head2);
exer.PrintList(head2);

/**

  Method  | Time Complexity | Space Complexity  
Reverse   |      O(n)       |   O(1)
Reverse2  |      O(n)       |   O(n)

Online Resource: 
  https://www.geeksforgeeks.org/reverse-a-linked-list/
  https://practice.geeksforgeeks.org/problems/reverse-a-linked-list/1/
*/