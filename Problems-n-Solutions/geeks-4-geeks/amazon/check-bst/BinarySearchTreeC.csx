
/**
Problem: Given the root of a binary tree. Check whether it is a BST or not.
        Note: We are considering that BSTs can not contain duplicate Nodes.
        A BST is defined as follows:

        The left subtree of a node contains only nodes with keys less than the node's key.
        The right subtree of a node contains only nodes with keys greater than the node's key.
        Both the left and right subtrees must also be binary search trees.

Warning: This is an inefficent solution to the problem because it traverses over some parts of the tree many times. 
         See BinarySerachTreeA.csx for the efficient implementation
*/

class Node 
{
    public int data;
    public Node left;

    public Node right;

  public Node(int d) {
      data = d;
  } 
}

class BinarySearchTreeC
{
    
    public bool isBST(Node root) 
    {
        if (root == null) 
        {
            return true;    
        }
        Node left = root.left;
        if (left != null && maxValue(left) >= root.data)
        {
            return false;
        }
        
        Node right = root.right;
        if (right != null && minValue(right) <= root.data) 
        {
            return false;
        }
        
        if (!isBST(left) || !isBST(right)) 
        {
            return false;
        }
        
        return true;
    }
    
    public int maxValue(Node root)
    {
        int maxVal = int.MinValue;
        Queue<Node> que = new Queue<Node>();
        que.Enqueue(root);
        while(que.Count > 0)
        {
            Node node = que.Dequeue();
            maxVal = node.data > maxVal ? node.data : maxVal;
            
            Node left = node.left;
            Node right = node.right;
            if (left != null)
            {
                maxVal = left.data > maxVal ? left.data : maxVal; 
                que.Enqueue(left);
            }
            
            if (right != null) 
            {
                maxVal = right.data > maxVal ? right.data : maxVal;
                que.Enqueue(right);
            }
        }
        
        return maxVal;
    }
    
    public int minValue(Node root)
    {
        int minVal = int.MaxValue;
        Queue<Node> que = new Queue<Node>();
        que.Enqueue(root);
        while(que.Count > 0)
        {
            Node node = que.Dequeue();
            minVal = node.data < minVal ? node.data : minVal;
            
            Node left = node.left;
            Node right = node.right;
            if (left != null)
            {
                minVal = left.data < minVal ? left.data : minVal; 
                que.Enqueue(left);
            }
            
            if (right != null) 
            {
                minVal = right.data < minVal ? right.data : minVal;
                que.Enqueue(right);
            }
        }
        return minVal;
    }
}

BinarySearchTreeC bst = new BinarySearchTreeC();

/**
     4
  2    5
1   3
This is a BST
*/
Node tree1 = new Node(4);
tree1.left = new Node(2);
tree1.right = new Node(5);
tree1.left.left = new Node(1);
tree1.left.right = new Node(3);
bool tree1IsBSt = bst.isBST(tree1); // True
Console.WriteLine(tree1IsBSt); // true

/** 
     3 
  2    5
1   4
This is not a BST because 4 is in the left subtree of 3
*/
Node tree2 = new Node(3);
tree2.left = new Node(2);
tree2.right = new Node(5);
tree2.left.left = new Node(1);
tree2.left.right = new Node(4);
bool tree2IsBst = bst.isBST(tree2); // False
Console.WriteLine(tree2IsBst); // False


/**
Solution:  
  Fore each node, we check if the max value in the left subtree is smaller than the node 
  and min value in the right subtree is greater than the node.

Output: 
  True
  False

Online Resources: 
  https://www.geeksforgeeks.org/a-program-to-check-if-a-binary-tree-is-bst-or-not/  
Online Practice: 
  https://practice.geeksforgeeks.org/problems/check-for-bst/1
*/