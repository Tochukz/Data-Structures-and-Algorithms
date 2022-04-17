/**
Problem: 
  Given a circular linked list, implement an algorithm which returns node at the beginning of the loop.
*/

class Node 
{
    public int Data;

    public Node Next;

    public Node(int data)
    {
        Data = data;
    }
}

class SingleLinkedList
{
    public Node Head;

    public bool ContainsLoop()
    {
        HashSet<Node> set = new HashSet<Node>();
        Node current = Head;
        while (current != null)
        {
            if (set.Contains(current))
            {
                Console.WriteLine("The list contains a loop");
                return true;
            }
            set.Add(current);
            current = current.Next;
        }

        Console.WriteLine("The list does NOT contain a loop");
        return false;
    }

    /** Floyd’s Cycle-Finding Algorithm - The fastest method  */
    public bool ContainsLoop2()
    {
        Node slowNode = Head;
        Node fastNode = Head;
        while(fastNode != null && fastNode.Next != null)
        {
            slowNode = slowNode.Next;
            fastNode = fastNode.Next.Next;
            if (slowNode == fastNode)
            {
                Console.WriteLine("The linked list contains a loop");
                return true;
            }
        }
     
        Console.WriteLine("The liked list does NOT contains a loop");
        return false;
    }

    
    /* Another problem: Finding the node at the beginning of the loop */
    public Node FindNodeAtLoopBegining()
    {
        if (Head == null)
        {
            return null;
        } 
        Node slowNode = Head;
        Node fastNode = Head;

        while(slowNode != null && fastNode != null && fastNode.Next != null)
        {
            slowNode = slowNode.Next;
            fastNode = fastNode.Next.Next;
            if(slowNode == fastNode)
            {   // Loop found!
                break;
            }
        }

        if (slowNode != fastNode)
        {
            Console.WriteLine("No loop found");
            return null;
        }

        slowNode = Head;
        while (slowNode != fastNode)
        {
            slowNode = slowNode.Next;
            fastNode = fastNode.Next;
        }

        return slowNode;
    }

    public void PrintList()
    {
        if (Head == null)
        {
            Console.WriteLine("The linked list is empty!");
            return;
        }
        Node current = Head;
        while(current != null) 
        {
            Console.Write($"{current.Data} ");
            current = current.Next;
        }
        Console.Write("\n");
    }
}

SingleLinkedList list = new SingleLinkedList();
Node[] nodes = new Node[10];
Random random  = new Random();
for(int i = 0; i < nodes.Length; i++)
{
    int data = random.Next(1, 10);
    Node node = new Node(data);
    nodes[i] = node;
    if (i > 0)
    {
        nodes[i-1].Next = node;
    }
}
list.Head = nodes[0];
list.PrintList();

list.ContainsLoop(); // The list does NOT contain a loop

nodes[9].Next = nodes[2];
list.ContainsLoop(); // The list contains a loop


nodes[9].Next = null;
list.ContainsLoop2(); // The liked list does NOT contains a loop

nodes[8].Next = nodes[4];
bool loopExist = list.ContainsLoop2(); // The linked list contains a loop 


nodes[8].Next = nodes[9];
Node loopStartNode = list.FindNodeAtLoopBegining(); // No loop found
nodes[7].Next = nodes[3];
Node loopBeginNode = list.FindNodeAtLoopBegining(); 
if (loopBeginNode != null)
{
    Console.WriteLine($"Loop Beigin node data is {loopBeginNode.Data} ");
    Console.WriteLine($"{loopBeginNode.Data == nodes[3].Data} "); // True
}

/**
  Method       | Time Complexity | Space Complexity 
ContainsLoop   |    O(n)         |    O(n)
ContainsLoop2  |    O(n)         |    1(n)

Online Resource: 
  https://www.geeksforgeeks.org/detect-loop-in-a-linked-list/  
  https://www.geeksforgeeks.org/find-first-node-of-loop-in-a-linked-list/
*/

