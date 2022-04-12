/**
Problem: Write an algorithm to find the ‘next’ node (i.e., in-order successor) of a given node in a 
  binary search tree where each node has a link to its parent
*/

class Node 
{
    public int Data;

    public Node Left;

    public Node Right;

    public Node(int data)
    {
        Data = data;
    }
}

class BinaryTree
{
    public Node Insert(Node root, int data)
    {
        if(root == null)
        {
            return new Node(data);
        }
        else
        {
            if (data > root.Data)
            {
                Node node = Insert(root.Right, data);
                root.Right = node;
            }
            else
            {
                Node node = Insert(root.Left, data);
                root.Left = node;
            }
        }
        return root;
    }

    public Node InOrderSuccessor(Node root, Node node)
    {
        if (node.Right != null)
        {
            return MinNode(node.Right);
        }

        Node successor = null;
        while(root != null)
        {
            if (node.Data > root.Data)
            {
                root = root.Right;
            }
            else if (node.Data < root.Data)
            {
                successor = root; 
                root = root.Left;               
            }
            else 
            {
                break;
            }
        }
        return successor;
    }

    private Node MinNode(Node node)
    {
        Node current = node;
        while(current.Left != null)
        {
            current = current.Left;
        }
        return current;
    }

    private void ArrangeByLevel(Node node, Dictionary<int, List<Node>> dict, int level)
    {
        if (node == null)
        {
            return;
        }
  
        if (!dict.ContainsKey(level))
        {
            dict.Add(level, new List<Node>());
        }
        dict[level].Add(node);

        ArrangeByLevel(node.Left, dict, level + 1);
        ArrangeByLevel(node.Right, dict, level + 1);
    }

    public void PrintLevelOrder(Node root)
    {
        Dictionary<int, List<Node>> dict = new Dictionary<int, List<Node>>();
        ArrangeByLevel(root, dict, 0);

        foreach(KeyValuePair<int, List<Node>> pair in dict)
        {
           foreach(Node node in pair.Value)
           {
               Console.Write($"{node.Data} ");
           }
           Console.Write("\n");
        }
    }
}

BinaryTree tree = new BinaryTree();
Node root = tree.Insert(null, 20);
tree.Insert(root, 8);
tree.Insert(root, 22);
tree.Insert(root, 4);
tree.Insert(root, 12);
tree.Insert(root, 10);
tree.Insert(root, 14);

tree.PrintLevelOrder(root);

Node node = root.Left.Right.Right;
Node successor = tree.InOrderSuccessor(root, node);
if (successor == null)
{
    Console.WriteLine($"No inorder successor for {node.Data}");
}
else 
{
   Console.WriteLine($"The inorder successor for {node.Data} is {successor.Data}");
}

/**
 Method          | Time Complexity | Space Complexity 
InOrderSuccessor |     O(h)        |     O(1)
Where h = height of the tree 

This solution used does NOT use Parent pointer in the Node class. 
This solution seems to be easier to remeber!
Output: 
    20 
    8 22
    4 12
    10 14
The inorder successor for 14 is 20

Online Resource: 
  https://www.geeksforgeeks.org/inorder-successor-in-binary-search-tree/
*/