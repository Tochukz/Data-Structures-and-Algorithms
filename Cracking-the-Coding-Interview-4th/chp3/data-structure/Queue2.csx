/* Queue implementation based on a linked list */

class Node 
{
    public int Data;

    public Node Next;

    public Node(int data)
    {
        Data = data;
    }
}

class Queue2
{
    Node Front;

    Node Rear;

    public void Enqueue(int data)
    {
        Node newNode = new Node(data);
        if (Front == null)
        {
            Front = newNode;
            Rear = newNode;
            return;
        }

        Rear.Next = newNode;
        Rear = newNode;
    }

    public int Dequeue()
    {
        if (Front == null)
        {
            throw new Exception("The queue is empty!");
        }
        Node top = Front;
        Front = Front.Next;
        if (Front == null)
        {
            Rear = null;
        }
        Console.WriteLine("Dequeue: Removing top {0}", top.Data);
        return top.Data;
    }

    public void PrintQueue()
    {
        Node current = Front;
        while(current != null)
        {
            Console.Write("{0} ", current.Data);
            current = current.Next;
        }
        Console.WriteLine("\n");
    }
}

Queue2 queue = new Queue2();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.PrintQueue(); // 1 2 3 4 5

queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
queue.Enqueue(6);
queue.PrintQueue(); // 4 5 6

