/**
Problem:  Determine if a binary tree is a binary search tree
  Given a Binary Tree, figure out whether it’s a Binary Search Tree. 
  In a binary search tree, each node’s key value is smaller than the key value of all nodes in the right subtree, 
  and is greater than the key values of all nodes in the left subtree. 

Constraint:  
  Runtime Complexity: Linear, O(n) 
  Memory Complexity: Linear, O(n)
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

class Exercise6
{
    private static bool IsBST(Node root, int minVal, int maxVal)
    {
        if (root == null)
        {
            return true;
        }

        if (root.Data < minVal || root.Data > maxVal)
        {
            return false;
        }
        return IsBST(root.Left, minVal, root.Data) && IsBST(root.Right, root.Data, maxVal);
    }
    public static bool IsBinarySearchTree(Node root)
    {
        return IsBST(root, int.MinValue, int.MaxValue);
    } 
}

/**
        50
    45        55
 40    50   50   60 
*/
Node root1 = new Node(50);
root1.Left = new Node(45);
root1.Right = new Node(55);
root1.Left.Left = new Node(40);
root1.Left.Right = new Node(50);
root1.Right.Left = new Node(50);
root1.Right.Right = new Node(60);

bool root1Is =Exercise6.IsBinarySearchTree(root1);
if (root1Is)
{
   Console.WriteLine("root1 is a binary search tree");
}
else
{
  Console.WriteLine("root1 is NOT a binary search tree");
}

/**  
         50
    45        55
 30    50   55   30 
*/
Node root2 = new Node(50);
root2.Left = new Node(45);
root2.Right = new Node(55);
root2.Left.Left = new Node(30);
root2.Left.Right = new Node(50);
root2.Right.Left = new Node(55);
root2.Right.Right = new Node(30);

bool root2Is =Exercise6.IsBinarySearchTree(root2);
if (root2Is)
{
   Console.WriteLine("root2 is a binary search tree");
}
else
{
  Console.WriteLine("root2 is NOT a binary search tree");
}


/**
Output: 
  root1 is a binary search tree
  root2 is NOT a binary search tree

Online Exercise: 
  https://www.educative.io/m/is-binary-tree-a-binary-search-tree
*/