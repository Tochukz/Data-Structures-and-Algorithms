/*
Problem: Given as input a list of tasks and their dependencies, 
write a function that will give as output a list of tasks in the order they need to execute
in such a way that no task executes before all its dependencies.

Example input:
a -> [b]
b -> [c, d]

Output:
[d, c, b, a]
*/

class Node 
{
    public char data;
    
    public Node next;
    
    public List<Node> dependencies;

    public Node(char c)
    {
        data = c;
    }
}

class ExecuteDependencies
{
    public static void Execute(Node head)
    {
        List<char> dependencies = new List<char>();
        
        Node current = head;
        dependencies.Add(current.data);
        
        while(current != null) 
        {
            foreach(Node node in current.dependencies)
            {
                dependencies.Add(node.data);                
            }
            current = current.next;
        }
        
        int start = 0;
        int end = dependencies.Count - 1;
        while(start < end)
        {
            char temp = dependencies[start];
            dependencies[start] = dependencies[end];
            dependencies[end] = temp;

            start++;
            end--;
        }
        
        foreach(char x in dependencies)
        {
            Console.Write(x + " ");
        }
        Console.Write("\n");
    }

    public static void Execute2(Node head)
    {
        Stack<char> dependencies = new Stack<char>();

        Node current = head;
        dependencies.Push(current.data);
        
        while(current != null) 
        {
            foreach(Node node in current.dependencies)
            {
                dependencies.Push(node.data);                
            }
            current = current.next;
        }
    
        while(dependencies.Count > 0)
        {
            Console.Write(dependencies.Pop() + " ");
        }
        Console.Write("\n");
    }
}

Node head = new Node('a');
Node nodeB = new Node('b');
head.dependencies = new List<Node> {nodeB};

head.next = nodeB;
nodeB.dependencies = new List<Node>{new Node('c'), new Node('d')};

ExecuteDependencies.Execute(head);
ExecuteDependencies.Execute2(head);