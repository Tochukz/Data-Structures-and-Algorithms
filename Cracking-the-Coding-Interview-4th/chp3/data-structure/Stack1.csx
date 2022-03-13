/* Stack implementation using array as storage */

class Stack1
{
    int[] Elements;

    int Top;

    int Max;

    public Stack1(int size)
    {
        Elements = new int[size];
        Top = -1;
        Max = size;
    }

    public void Push(int item)
    {
        if (Top == Max - 1)
        {
            throw new Exception("Stack overflow!");
        }
        Elements[++Top] = item;
    }

    public int Pop()
    {
        if (Top == -1)
        {
            throw new Exception("Stack underflow! The stack is empty");
        }
        return Elements[Top--];
    }

    public int Peek()
    {
        if (Top == -1)
        {
            throw new Exception("Stack is empty!");
        }
        return Elements[Top];
    }

    public void PrintStack()
    {
        if (Top == -1)
        {
            Console.WriteLine("The stack is empty!");
            return;
        }
        
        for(int i = 0; i <= Top; i++)
        {
            Console.Write($"{Elements[i]} ");
        }
        Console.WriteLine("\n");
    }
}

Stack1 stack = new Stack1(5);
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
stack.PrintStack(); // 1 2 3 4 5

int lastElement = stack.Pop(); 
int secondLast = stack.Peek(); 
Console.WriteLine($"Last Element: {lastElement}"); // Last Element: 5
Console.WriteLine($"Second Last: {secondLast}"); // Second Last: 4
stack.PrintStack(); // 1 2 3 4

/**
 PROS:
 This implementation saves memory because no pointer is used
 CONS:
 In this implementation the stack is NOT dynamic and therefore cannot grow according to the need at run time.
*/