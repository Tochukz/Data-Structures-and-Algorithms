/**
 Implementing Two stack using a single array as storage. 
 This implementation stores the elements of the first stack starting from index 0 and the second stack starting from index n -1. 
 This is a space efficient implementation of Two Stacks in a single array.
*/

class TwoStacks2
{
    int Top1; 

    int Top2;

    int Max;

    int[] Elements;

    public TwoStacks2(int size)
    {
        Top1 = -1;
        Top2 = size;
        Max = size;
        Elements = new int[size];
    }

    public void Push1(int data)
    {
        if (Top1 < Top2 - 1)
        {
            Elements[++Top1] = data;
            return;
        }
        
        throw new Exception("Stack overflow!");
    }

    public void Push2(int data)
    {
        if (Top1 < Top2 - 1)
        {
            Elements[--Top2] = data;
            return;
        }
        throw new Exception("Stack overflow!");
    }

    public int Pop1()
    {
        if (Top1 >= 0)
        {
            return Elements[Top1--];
        }
        throw new Exception("Stack underflow!");
    }

    public int Pop2()
    {
        if (Top2 < Max)
        {
            return Elements[Top2++];
        }
        throw new Exception("Stack undeflow");
    }

    public void PrintStack(int stackN)
    {
        if (stackN == 1)
        {            
            for (int i = 0; i <= Top1; i++)
            {
                Console.Write($"{Elements[i]} ");
            }            
        }
        else if (stackN == 2)
        {            
            for(int i = Max - 1; i >= Top2; i--)
            {
                Console.Write($"{Elements[i]} ");
            }
        }    
        else 
        {
            Console.WriteLine("Invalid stack number");
        }
        Console.Write("\n");
    }
}

TwoStacks2 stacks = new TwoStacks2(7);
stacks.Push1(3);
stacks.Push1(4);
stacks.Push1(5);
stacks.Push1(6);

stacks.Push2(9);
stacks.Push2(8);
stacks.Push2(7);

stacks.PrintStack(1); // 3 4 5 6 
stacks.PrintStack(2); // 9 8 7

// stacks.Push1(7); // System.Exception: Stack overflow!
// stacks.Push2(6); // System.Exception: Stack overflow!

stacks.Pop1();
stacks.PrintStack(1); // 3 4 5

stacks.Pop2();
stacks.PrintStack(2); // 9 8
stacks.Push2(12);
stacks.PrintStack(2); // 9 8 12

stacks.Pop2();
stacks.Pop2();
stacks.Pop2();
stacks.PrintStack(2); // Empty
// stacks.Pop2(); // System.Exception: Stack underflow!
stacks.PrintStack(1);  // 3 4 5

/**
Method | Time Complexity | Space Complexity 
 Push    |    O(1)         |  O(n)
 Pop     |    O(1)         |  O(n)
  Online Resource: 
    https://www.geeksforgeeks.org/implement-two-stacks-in-an-array/
*/