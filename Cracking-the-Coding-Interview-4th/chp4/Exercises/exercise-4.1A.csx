/**  
  Problem: Implement a function to check if a tree is balanced. 
    For the purposes of this question, a balanced tree is defined to be a tree such that no two leaf nodes 
    differ in distance from the root by more than one.
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
    public Node Root;

    public bool IsBalanced(Node root)
    {
        if (root == null)
        {
            return true;
        }
        int leftHeight = Height(root.Left) ;
        int rightHeight = Height(root.Right);
        if (Math.Abs(leftHeight - rightHeight ) <= 1 && IsBalanced(root.Left) && IsBalanced(root.Right))
        {
            return true;
        }

        return false;
    }

    public int Height(Node node)
    {
        if (node  == null)
        {
            return 0;
        }

        return 1 + Math.Max(Height(node.Left), Height(node.Right));
    }
}

BinaryTree tree = new BinaryTree();
Node root = new Node(1);
tree.Root = root;
root.Left = new Node(2);
root.Right = new Node(3);
root.Left.Left = new Node(4);
root.Left.Right = new Node(5);
root.Left.Left.Left = new Node(8);

bool isBalanced1 = tree.IsBalanced(tree.Root);
string str = isBalanced1 ? "Tree is balanced!" : "Tree is NOT balanced!";
Console.WriteLine(str); // Tree is NOT balanced!

/**
 Method    | Time Complexity | Space Complexity 
IsBalanced | O(n^2)          |   O(1)

 Online Resource 
   https://www.geeksforgeeks.org/how-to-determine-if-a-binary-tree-is-balanced/
*/