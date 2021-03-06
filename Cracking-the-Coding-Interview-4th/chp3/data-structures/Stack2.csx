/* Stack implementation using linked list as storage */


class Node 
{
    public int Data;

    public Node Next;

    public Node(int data)
    {
        Data = data;
    }
}

class Stack2
{
    Node Head;


    public void Push(int data)
    {
        Node newNode = new Node(data);
        if (Head == null)
        {
            Head = newNode;
            return;
        }
        
        Node currentHead = Head;
        Head = newNode;
        Head.Next = currentHead;
    }

    public int Pop()
    {
        if (Head == null)
        {
            throw new Exception("The Stack is empty!");
        }
        int data = Head.Data;
        Head = Head.Next;
        return data;
    }

    public int Peek()
    {
        if (Head == null)
        {
            throw new Exception("The Stack is empty!");
        }
        return Head.Data;
    }

    public void PrintStack()
    {
        Node current = Head;
        while(current != null)
        {
            Console.Write("{0} ", current.Data);
            current = current.Next;
        }
        Console.WriteLine("\n");
    }
}

Stack2 stack = new Stack2();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
stack.PrintStack(); // 5 4 3 2 1

int x = stack.Pop();
int y = stack.Pop();
int z = stack.Peek();
Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z); // x = 5, y = 4, z = 3
stack.PrintStack(); // 3 2 1

/**
 PROS: 
 In this implemetation the stack is dynamic and can grow and shrink according to the need at run time
 CONS:
 In this implementation a pointer is used which requires extra memory
*/