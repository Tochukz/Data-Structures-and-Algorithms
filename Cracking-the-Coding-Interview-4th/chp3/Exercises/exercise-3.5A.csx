/**
Problem: 
  Implement a MyQueue class which implements a queue using two stacks.
*/

using System.Collections.Generic;

class QueueFromStacksA
{
    Stack<int> MainStack = new Stack<int>();

    Stack<int> AuxStack = new Stack<int>();
    
    public void Enqueue(int value)
    {
        while(MainStack.Count > 0)
        {
            AuxStack.Push(MainStack.Pop());
        }
        
        MainStack.Push(value);

        while(AuxStack.Count > 0)
        {
            MainStack.Push(AuxStack.Pop());
        }
    }

    public int Dequeue()
    {
        if (MainStack.Count == 0)
        {
            throw new Exception("Queue is empty!");
        }
        return MainStack.Pop();
    }
}

QueueFromStacksA queue = new QueueFromStacksA();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

int a = queue.Dequeue();
int b = queue.Dequeue();
int c= queue.Dequeue();
Console.WriteLine("a = {0}", a); // a = 1
Console.WriteLine("b = {0}", b); // b = 2
Console.WriteLine("c = {0}", c); // c = 3

queue.Enqueue(6);
queue.Enqueue(7);
queue.Enqueue(8);

int d = queue.Dequeue();
int e = queue.Dequeue();
int f = queue.Dequeue();
Console.WriteLine("d = {0}", d); // d = 4
Console.WriteLine("e = {0}", e); // e = 5
Console.WriteLine("f = {0}", f); // f = 6

/**
This solution makes Enqueue more expensive over Dequeue

 Method | Time Complexity | Space Complexity 
Enqueue |     O(n)        |    
Dequeue |     O(1)        |    

Auxilary Space: O(n)
Online Resource:  
  https://www.geeksforgeeks.org/queue-using-stacks/
*/