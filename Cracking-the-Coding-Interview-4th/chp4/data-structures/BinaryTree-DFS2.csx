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

class BinaryTreeDFS2
{
    public Node Root;

    public BinaryTreeDFS2()
    {
        
    }

    public BinaryTreeDFS2(int data)
    {
        Root = new Node(data);
    }
    
    public void TraversePreOrder(Node root)
    {
        //Todo: 
    }

    /**
    * Inorder Traverse using a stack instead of recusion  
    */
    public void TraverseInOrder(Node root)
    {
        Stack<Node> stack = new Stack<Node>();
        Node current = root;

        while(current != null || stack.Count > 0)
        {
            while(current != null)
            {
                stack.Push(current);
                current = current.Left;
            }
            current = stack.Pop();
            Console.Write($"{current.Data} ");
            current = current.Right;
        }
    }

    /**
    * Traverse without recurion and without stack
    */
    public void TraverseInOrder2()
    {
        //Todo: 
        // https://www.geeksforgeeks.org/inorder-tree-traversal-without-recursion-and-without-stack/?ref=lbp
    }

    public void TraversePostOrder(Node parent)
    {
        //Todo: 
    }
}

/**
      1 
   2    3
 4  5
*/

BinaryTreeDFS2 tree = new BinaryTreeDFS2(1);
tree.Root.Left = new Node(2);
tree.Root.Right = new Node(3);

tree.Root.Left.Left = new Node(4);
tree.Root.Left.Right = new Node(5);


tree.TraversePreOrder(tree.Root);  // 1 2 4 5 3 
Console.WriteLine("\n"); 
tree.TraverseInOrder(tree.Root); // 4 2 5 1 3 
// Console.WriteLine("\n");
// tree.TraversePostOrder(tree.Root); // 4 5 2 3 1

/**
Here I implement the 3 types of Depth-First Traverse for a Binary Tree without recursion 

 Method              | Time Complexity | Depth Complexity 
TraverseInOrder      |       O(n)      | 
Online Resource:  
  https://www.geeksforgeeks.org/inorder-tree-traversal-without-recursion/?ref=lbp
  https://www.geeksforgeeks.org/inorder-tree-traversal-without-recursion-and-without-stack/?ref=lbp
*/