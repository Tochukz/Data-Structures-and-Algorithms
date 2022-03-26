/**
  Problem:  
    How would you design a stack which, in addition to push and pop, also has a function min which returns the minimum element? Push, pop and min should all operate in O(1) time
*/

using System.Collections.Generic;

class Exercise32B
{
    public Stack<int> Elements = new Stack<int>();

    private int MinElem;

    public void Push(int value)
    {
        if (Elements.Count == 0)
        {
            MinElem = value;
            Elements.Push(value);
            return;
        }

        if (value < MinElem)
        {
            Elements.Push(2 * value - MinElem);
            MinElem  = value;
        }
        else 
        {
            Elements.Push(value);
        }
    }

    public int Pop()
    {
        if (Elements.Count == 0)
        {
            throw new Exception("The base stack is empty!");
        }
        int value = Elements.Pop();
        if (value < MinElem)
        {
            MinElem = 2 * MinElem - value;
        } 
        return value;
    }
    
    public int Min()
    {       
        if (Elements.Count == 0)
        {
            throw new Exception("Stack is empty!");
        }
        return MinElem;
    }
}

Exercise32B stack = new Exercise32B();
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
This implementation is optimized to use O(1) extra space instead of O(n) extra space.

Method   | Time Complexity | Space Complexity 
 Push    |    O(1)         |   
 Pop     |    O(1)         |   O(1)
 Min     |    O(1)         |   

This solution uses O(1) auxiliary/extra space

 Online Resource
   https://www.geeksforgeeks.org/design-a-stack-that-supports-getmin-in-o1-time-and-o1-extra-space/
*/