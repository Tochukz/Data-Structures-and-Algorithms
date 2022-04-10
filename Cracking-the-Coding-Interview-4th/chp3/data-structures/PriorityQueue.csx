/* Implementation of a priority queue using linked list */

class Node 
{
    public int Data;

    public int Priority;

    public Node Next;

    public Node(int data, int priority)
    {
       Priority = priority;
       Data = data;
    }
}

class PriorityQueue
{
    Node Head;

    public PriorityQueue(Node head)
    {
        Head = head;
    }

    public void Enqueue(int data, int priority)
    {
        Node newNode = new Node(data, priority);
        if (Head == null)
        {
            Head = newNode;
            return;
        }
        
        if (newNode.Priority > Head.Priority)
        {
            newNode.Next = Head;
            Head = newNode;
            return;
        }
    
        Node prev = null;
        Node current = Head;
        while(current != null)
        {
            if (newNode.Priority > current.Priority)
            {
                if (prev != null)
                {
                   prev.Next = newNode;
                   newNode.Next = current;
                }
                return;
            } 
            prev = current;
            current = current.Next;
        }

        prev.Next = newNode;
    }

    public int Dequeue()
    {
        if (Head == null)
        {
            throw new Exception("The queue is empty");
        }
        Node topMost = Head;
        Head = Head.Next;
        return topMost.Data;
    }

    public int Peek()
    {
        if (Head == null)
        {
            throw new Exception("The queue is empty");
        }
        return Head.Data;
    }

    public void PrintQueue()
    {
        Node current = Head;
        while(current != null)
        {
            Console.Write($"{current.Data} ");
            current = current.Next;
        }
        Console.Write("\n");
    }
}

PriorityQueue pQueue = new PriorityQueue(new Node(80, 5));
pQueue.Enqueue(60, 4);
pQueue.Enqueue(50, 5);
pQueue.Enqueue(65, 2);
pQueue.Enqueue(90, 7);
pQueue.Enqueue(75, 5);
pQueue.PrintQueue(); 

int top1 = pQueue.Dequeue();
int top2 = pQueue.Dequeue();
Console.WriteLine("Top1 = {0}, Top2 = {1}", top1, top2);
pQueue.PrintQueue();

/**
Output: 
  90 80 50 75 60 65 
  Top1 = 90, Top2 = 80
  50 75 60 65

 Priority Queue is an abstract data type, which is similar to a queue, however, in the priority queue, every element has some priority. 
 A Priority Queue has the following properties:  
 1. Every item has a priority associated with it.
 2. An element with high priority is dequeued before an element with low priority.
 3. If two elements have the same priority, they are served according to their order in the queue.

Method   | Time Complexity | Space Complexity 
Enqueue  |     O(n)        |    
Dequeue  |     O(1)        |  
Peek     |     O(1)        | 

 Online Resource: 
   https://www.geeksforgeeks.org/priority-queue-set-1-introduction/
*/
