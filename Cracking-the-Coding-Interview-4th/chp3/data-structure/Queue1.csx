/* Queue implementation based on an array */

class Queue1
{
    int Front;

    int Rear; 

    int[] Elemenets;

    int Max;

    public Queue1(int size)
    {
        Elemenets = new int[size];
        Front = 0;
        Rear = -1;
        Max = size;
    }

    public void Enqueue(int x)
    {
        if (Rear == Max - 1)
        {            
            throw new Exception("Queue overflow!");
        }
        Elemenets[++Rear] = x;
    }
 
    public int Dequeue()
    {
        if (Front == Rear + 1)
        {
            throw new Exception("Queue is empty");
        }
        int removed = Elemenets[Front++];
        Console.WriteLine("Dequeue: attending to {0}", removed);
        return removed;
    }

    public  void PrintQueue()
    {
        if (Front == Rear + 1)
        {
            Console.WriteLine("The Queue is empty!");
            return;
        }
        for(int i = 0; i <= Rear; i++)
        {
            Console.Write("{0} ", Elemenets[i]);
        }
        Console.WriteLine("\n");
    }
}

Queue1 queue = new Queue1(5);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.PrintQueue(); // 1 2 3 4 5

queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
// queue.Enqueue(6); // Will throw an overflow error even though I have dequeued 3 elements. 
queue.PrintQueue(); // 1 2 3 4 5

/**
 The solution is not working as a queue should 
 
 PROS: 
 Easy to implement 
 CONS: 
 1. The Queue size is fixed 
 2. This solution will not work well for large queue because the property Rear will run out of bound of the Array . 
*/