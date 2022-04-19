/**
 Problem: Tree: Height of a Binary Tree  
   The height of a binary tree is the number of edges between the tree's root and its furthest leaf.  
   Complete the getHeight or height function in the editor. It must return the height of a binary tree as an integer.
   
   Note -The Height of binary tree with single node is taken as zero.
 */

public class TreeHeight
{
    public static int height(Node root) {
        return calcHeight(root);
    }
  
    private static int calcHeight(Node root) {
        if (root == null)
        {
            return -1;
        }
        
        return 1 + Math.max(height(root.left), height(root.right));
    }

    public static void main(String[] args)
    {
        Node root = new Node(3);
        root.left = new Node(2);
        root.right = new Node(5);
        root.left.right = new Node(1);
        root.right.left = new Node(4);
        root.right.right = new Node(6);
        root.right.right.right = new Node(7);
    
        int height = TreeHeight.height(root);
        System.out.printf("Height = %d \n", height);
    }
} 

class Node 
{
    public int data;

    public Node left;

    public Node right;

    public Node(int d)
    {
        data = d;
    }
}
/**
       3
    2     5
  1     4    5
               7

*/



/**

Output:  
  Height = 3 
  
Online Resource:  
  https://www.hackerrank.com/challenges/tree-height-of-a-binary-tree/problem
*/