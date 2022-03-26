/**
  Problem:  
    How would you design a stack which, in addition to push and pop, also has a function min which returns the minimum element? Push, pop and min should all operate in O(1) time
*/

using System.Collections.Generic;

class Exercise32A 
{
    Stack<int> Elements;

    Stack<int> MinElements; 

    public Exercise32A()
    {
        Elements = new Stack<int>();
        MinElements = new Stack<int>();
    }

    public void Push(int value)
    {
       if(value < MinValue)
       {
           MinElements.Push(value);
       }
       Elements.Push(value);
    }

    public int Pop()
    {
        if (Elements.Count == 0)
        {
            throw new Exception("The main stack is empty!");
        }
        int value = Elements.Pop();
        if (value == MinValue)
        {
            MinElements.Pop();
        }
        return value;
    }

    public int MinValue
    {
        get {
            if (MinElements.Count == 0)
            {
                return int.MaxValue;
            }
            return MinElements.Peek();
        }
    }
    public int Min()
    {
        if (MinElements.Count == 0)
        {
            throw new Exception("The stack is empty!");
        }
        return MinElements.Peek();
    }
}

Exercise32A stack = new Exercise32A();
stack.Push(20);
stack.Push(30);
stack.Push(10);
Console.WriteLine($"Min = {stack.Min()}"); // Min = 10

stack.Push(5);
stack.Push(7);
stack.Push(11);
Console.WriteLine($"Min = {stack.Min()}"); // Min = 5

stack.Pop();
stack.Pop();
Console.WriteLine($"Min = {stack.Min()}"); // Min = 5

stack.Pop();
Console.WriteLine($"Min = {stack.Min()}"); // Min = 10

/**
Method   | Time Complexity | Space Complexity 
 Push    |    O(1)         |   
 Pop     |    O(1)         |   O(1)
 Min     |    O(1)         |   

This solution uses O(n) auxiliary/extra space

Here I haved used C# native Stack implementation. This can be replaced by my own custom impementation of stack 

Online Resource: 
  
*/
