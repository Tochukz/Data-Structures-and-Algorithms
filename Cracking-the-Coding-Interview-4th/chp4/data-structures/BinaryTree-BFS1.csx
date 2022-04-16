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

class BinaryTreeBFS1
{
    public Node Root;

    public BinaryTreeBFS1()
    {

    }

    public BinaryTreeBFS1(int data)
    {
        Root = new Node(data);
    }
    
    /* Breath-First Traversal aka Level Order Traversal*/
    public void TraverseLevelOrder()
    {
       int height = Height(Root);
       for(int i = 1; i <= height; i++)
       {
           PrintLevel(Root, i);
       }
    }

    private int Height(Node root)
    {
        if (root == null)
        {
            return 0;
        }
        return 1 + Math.Max(Height(root.Left), Height(root.Right));
    }
    
    public void PrintLevel(Node root, int level)
    {
        if (root == null)
        {
            return;
        }

        if (level == 1)
        {
            Console.Write($"{root.Data} ");
        }
        else if(level > 1)
        {
            PrintLevel(root.Left, level - 1);
            PrintLevel(root.Right, level - 1);
        }
    }
}

/**
      1 
   2    3
 4  5  6  7
*/
BinaryTreeBFS1 tree = new BinaryTreeBFS1(1);
tree.Root.Left = new Node(2);
tree.Root.Right = new Node(3);

tree.Root.Left.Left = new Node(4);
tree.Root.Left.Right = new Node(5);

tree.Root.Right.Left = new Node(6);
tree.Root.Right.Right = new Node(7);

tree.TraverseLevelOrder();

/** 
 Method             |  Time Complexity | Space Complexity   
TraverseLevelOrder |     O(n^2)       |    O(n)  for skewed tree, O(Log n) for balanced tree 
PrintLevel          |      O(n)        |    O(n)  for skewed tree, O(Log n) for balanced tree 

Here I implement the Breadth-first(level-order) traversal for a binary tree using recusive function call. 
This is not the best approach. Using a Queue is much better. See BinaryTree-BFS.csx
 
 Output: 
   1 2 3 4 5 6 7 

 Online Resource: 
   https://www.geeksforgeeks.org/level-order-tree-traversal/
*/
