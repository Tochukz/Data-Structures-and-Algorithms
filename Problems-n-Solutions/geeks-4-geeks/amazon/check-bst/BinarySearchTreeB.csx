
/**
Problem: Given the root of a binary tree. Check whether it is a BST or not.
        Note: We are considering that BSTs can not contain duplicate Nodes.
        A BST is defined as follows:

        The left subtree of a node contains only nodes with keys less than the node's key.
        The right subtree of a node contains only nodes with keys greater than the node's key.
        Both the left and right subtrees must also be binary search trees.

Note: This solution is more efficient that BinarySearchC.csx but because it traverse each node only once. 
      But it uses an auxilary space in the form of an array to store each node data. 
      See BinarySearchTreeA.csx for an equally or more efficient solution without an auxilary space
*/
class  Node 
{
    public int data;

    public Node left;

    public Node right;

    public Node(int d) 
    {
        data = d;
    }
}

class BinarySearchTreeA
{
    public bool isBST(Node root) 
    {
        if (root == null)
        {
            return false;
        }
        List<int> dataList = new List<int>();
        inOrder(root, dataList);
        
        for(int i = 0; i < dataList.Count - 1; i++)
        {
            if (dataList[i+1] < dataList[i]) 
            {
                return false;
            }
        }
        return true;
    }
    
    public void inOrder(Node node, List<int> dataList)
    {
        if (node == null)
        {
            return;
        }
        inOrder(node.left, dataList);
        dataList.Add(node.data);
        inOrder(node.right, dataList);      
    }
}

BinarySearchTreeA bst = new BinarySearchTreeA();

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
  Do in-order traversal of the tree and store the result in an array. 
  Check if the array is sorted in ascending order, if it is, then the tree is BST.

Assumption:  
  It is assumed that there are not duplicate values in the tree

Output: 
  True
  False

Online Resources: 
  https://www.geeksforgeeks.org/a-program-to-check-if-a-binary-tree-is-bst-or-not/  
Online Practice: 
  https://practice.geeksforgeeks.org/problems/check-for-bst/1
*/