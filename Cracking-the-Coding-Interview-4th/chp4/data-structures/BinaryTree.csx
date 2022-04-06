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
    public Node Root;

    public BinaryTree()
    {
        Root = null;
    }

    public BinaryTree(int data)
    {
        Root = new Node(data);
    }

    public void TraversePreOrder(Node parent)
    {
        if (parent == null)
        {
            return;
        }
        Console.Write("{0} ", parent.Data);
        TraversePreOrder(parent.Left);
        TraversePreOrder(parent.Right);
    }

    public void TraverseInOrder(Node parent)
    {
        if (parent == null)
        {
            return;
        }
        TraverseInOrder(parent.Left);
        Console.Write("{0} ", parent.Data);
        TraverseInOrder(parent.Right);
    }

    public void TraversePostOrder(Node parent)
    {
        if (parent == null)
        {
            return;
        }
        TraversePostOrder(parent.Left);
        TraversePostOrder(parent.Right);
        Console.Write($"{parent.Data} ");
    }

    /**
    * Traverse without recursion
    */
    public void TraverseInOrder2()
    {
      //Todo: 
      // https://www.geeksforgeeks.org/inorder-tree-traversal-without-recursion/?ref=lbp
    }

    /**
    * Traverse without recurion and without stack
    */
    public void TraverseInOrder3()
    {
        //Todo: 
        // https://www.geeksforgeeks.org/inorder-tree-traversal-without-recursion-and-without-stack/?ref=lbp
    }
}

/**
      1 
   2    3
 4  5
*/

BinaryTree tree = new BinaryTree(1);
tree.Root.Left = new Node(2);
tree.Root.Right = new Node(3);

tree.Root.Left.Left = new Node(4);
tree.Root.Left.Right = new Node(5);


tree.TraversePreOrder(tree.Root);  // 1 2 4 5 3 
Console.WriteLine("\n"); //
tree.TraverseInOrder(tree.Root); // 4 2 5 1 3 
Console.WriteLine("\n");
tree.TraversePostOrder(tree.Root); // 4 5 2 3 1