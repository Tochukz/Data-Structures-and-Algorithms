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

class BinaryTreeDFS1
{
    public Node Root;

    public BinaryTreeDFS1()
    {
        
    }

    public BinaryTreeDFS1(int data)
    {
        Root = new Node(data);
    }

    /* PreOrder Traversal */
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

    /* InOrder Traversal */
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

     /*  PostOrder Traversal */
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

}

/**
      1 
   2    3
 4  5
*/

BinaryTreeDFS1 tree = new BinaryTreeDFS1(1);
tree.Root.Left = new Node(2);
tree.Root.Right = new Node(3);

tree.Root.Left.Left = new Node(4);
tree.Root.Left.Right = new Node(5);


tree.TraversePreOrder(tree.Root);  // 1 2 4 5 3 
Console.WriteLine("\n"); 
tree.TraverseInOrder(tree.Root); // 4 2 5 1 3 
Console.WriteLine("\n");
tree.TraversePostOrder(tree.Root); // 4 5 2 3 1

/**
Here I implement the 3 types of Depth-First Traverse for a Binary Tree using recursion

Online Resource:  
  https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder 
  https://www.geeksforgeeks.org/level-order-tree-traversal/
*/