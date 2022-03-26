/**
Problem: 
  Imagine a (literal) stack of plates. If the stack gets too high, it might topple. Therefore, in real life, we would likely start a new stack when the previous stack exceeds some threshold. Implement a data structure SetOfStacks that mimics this. SetOfStacks should be composed of several stacks, and should create a new stack once the previous one exceeds capacity. SetOfStacks.push() and SetOfStacks.pop() should behave identically to a single stack (that is, pop() should return the same values as it would if there were just a single stack).
  FOLLOW UP
  Implement a function popAt(int index) which performs a pop operation on a specific sub-stack.
*/

using System.Collections.Generic;

class SetOfStacks
{
    List<Stack<int>> StackList;

    int Max;

    public SetOfStacks(int max)
    {
        StackList = new List<Stack<int>>();
        Max = max;
    }

    public void Push(int value)
    {
        if (StackList.Count == 0)
        {
            Stack<int> newStack = new Stack<int>();
            newStack.Push(value);
            StackList.Add(newStack);          
        }
        else 
        {
            Stack<int> lastStack = StackList[StackList.Count - 1];
            if (lastStack.Count == Max)
            {
                lastStack = new Stack<int>();
                StackList.Add(lastStack);
            }
            lastStack.Push(value);
        }
    }

    public int Pop()
    {
        if (StackList.Count == 0)
        {
            throw new Exception("Nothing to pop, stack is empty!");
        }
        Stack<int> lastStack = StackList[StackList.Count -1];
        if (lastStack.Count == 1)
        {
            StackList.Remove(lastStack);
        }
        return lastStack.Pop();
    }

    public int Peek()
    {
        if (StackList.Count == 0)
        {
            throw new Exception("Nothing to peek, stack is empty!");
        }
        Stack<int> lastStack = StackList[StackList.Count - 1];
        return lastStack.Peek();
    }

    public int PopAt(int index)
    {
        if (StackList.Count == 0)
        {
            throw new Exception("Nothing to pop-at, stack is empty!");
        }
        if (index >= StackList.Count)
        {
           throw new Exception($"index {index} out of bound!");
        }
        Stack<int> targetStack = StackList[index];       
        if (targetStack.Count == 1)
        {
            StackList.Remove(targetStack);
        }
        return targetStack.Pop();
    }
}  

SetOfStacks stackSet1 = new SetOfStacks(5);
for (int i = 0 ; i < 33; i++)
{
    stackSet1.Push(i+1);
}
for (int i = 0; i < 33; i++)
{
    Console.Write($"{stackSet1.Pop()} ");
}
Console.Write("\n");


SetOfStacks stackSet2 = new SetOfStacks(5);
for (int i = 0 ; i < 33; i++)
{
    stackSet2.Push(i+1);
}
int a = stackSet2.PopAt(0);
int b = stackSet2.PopAt(3);

int c = stackSet2.PopAt(3);
int d = stackSet2.PopAt(3);
int e = stackSet2.PopAt(3);
int f = stackSet2.PopAt(3);
int x =  stackSet2.PopAt(3);
int g = stackSet2.PopAt(5);  
Console.WriteLine("a = {0}", a); // a = 5
Console.WriteLine("b = {0}", b); // b = 20
Console.WriteLine("c = {0}", c); // c = 19
Console.WriteLine("d = {0}", d); // d = 18
Console.WriteLine("e = {0}", e); // e = 17
Console.WriteLine("f = {0}", f); // f = 16
Console.WriteLine("x = {0}", x); // x = 25
Console.WriteLine("g = {0}", g); // g = 33

// int h = stackSet2.PopAt(7); // System.Exception: Stack 7 not found!

for (int i = 0; i < 25; i++)
{
    Console.Write($"{stackSet2.Pop()} ");
}

/**
  Output: 
    33 32 31 30 29 28 27 26 25 24 23 22 21 20 19 18 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1 
    a = 5
    b = 20
    c = 19
    d = 18
    e = 17
    f = 16
    x = 25
    g = 33
    32 31 30 29 28 27 26 24 23 22 21 15 14 13 12 11 10 9 8 7 6 4 3 2 1
*/