/**
  Implementing Two stack using a single array as storage. 
  This implementation splits the array into two equal halves for each stack.
  The problem with this method is inefficient use of array space. 
  For example, a stack push operation may result in stack overflow even if there is space available in array
*/

class TwoStacks1
{
    int[] Elements;

    int Top1;

    int Top2;

    int Max;

    public TwoStacks1(int size)
    {
        Elements = new int[size];
        Top1 = size / 2 + 1;
        Top2 = size / 2;
        Max = size;
    }

    public void Push1(int data)
    {
        if (Top1 == 0)
        {
            throw new Exception("Stack overlow");
        }

        Elements[--Top1] = data;
    }

    public void Push2(int data)
    {
        if (Top2 == Max - 1)
        {
            throw new Exception("Stack overflow!");
        }
        Elements[++Top2] = data;
    }

    public int Pop1()
    {
        if (Top1 == (Max / 2 + 1))
        {
            throw new Exception("Stack underflow!");
        }
        return Elements[Top1++];
    }

    public int Pop2()
    {
        if (Top2 < (Max / 2))
        {
           throw new Exception("Stack underflow!");
        }
        return Elements[Top2--];
    }

    public void PrintStack(int stackN)
    {
        if (stackN == 1)
        {
            int len =  (Max/ 2 + 1);
            for (int i = len -1; i >= Top1; i--)
            {
                Console.Write($"{Elements[i]} ");
            }            
        }
        else if (stackN == 2)
        {
            int start = Max / 2 + 1;
            for(int i = start; i <= Top2; i++)
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


TwoStacks1 stacks = new TwoStacks1(7);
stacks.Push1(3);
stacks.Push1(4);
stacks.Push1(5);
stacks.Push1(6); 
// stacks.Push1(7); // System.Exception: Stack overlow 
stacks.Push2(9);
stacks.Push2(8);
stacks.Push2(7);
// stacks.Push2(6); // System.Exception: Stack overflow!

stacks.PrintStack(1); // 3 4 5 6 
stacks.PrintStack(2); // 9 8 7

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
stacks.Pop2();
stacks.PrintStack(1);  // 3 4 5
// stacks.Pop2(); // System.Exception: Stack underflow!

/**
  Method | Time Complexity | Space Complexity 
 Push    |    O(1)         |  O(n)
 Pop     |    O(1)         |  O(n)
  Online Resource: 
    https://www.geeksforgeeks.org/implement-two-stacks-in-an-array/
*/