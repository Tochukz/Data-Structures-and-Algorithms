/**
 Problem: Implement a MyStack class which implements a queue using two queue.

 This problem is opposite to the one described in exercise-3.5A and exercise-3.5B
*/

using System.Collections.Generic;

class StackFromQueues
{
    Queue<int> MainQueue  =new Queue<int>();

    Queue<int> AuxQueue = new Queue<int>();

    public void Push(int value)
    {
        AuxQueue.Enqueue(value);

        while(MainQueue.Count != 0)
        {
            AuxQueue.Enqueue(MainQueue.Dequeue());
        }
        Queue<int> copyOfMain = MainQueue;
        MainQueue = AuxQueue;
        AuxQueue = copyOfMain;
    }

    public int Pop()
    {
        if (MainQueue.Count == 0)
        {
            throw new Exception("Stack is empty!");
        }
        return MainQueue.Dequeue();
    }
}

StackFromQueues stack = new StackFromQueues();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

int a = stack.Pop();
int b = stack.Pop();
int c = stack.Pop();

Console.WriteLine("a = {0}", a);
Console.WriteLine("b = {0}", b);
Console.WriteLine("c = {0}", c);

stack.Push(6);
stack.Push(7);

int d = stack.Pop();
int e = stack.Pop();
Console.WriteLine("d = {0}", d);
Console.WriteLine("e = {0}", e);

/**

Online Resource:  
  https://www.geeksforgeeks.org/implement-stack-using-queue/
*/