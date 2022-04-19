/**
 Problem: Tree: Level Order Traversal
    Given a pointer to the root of a binary tree, you need to print the level order traversal of this tree. 
    In level-order traversal, nodes are visited level by level from left to right. 
    Complete the function levelOrder and print the values in a single line separated by a space.
 */

import java.util.*;

public class TreeTraversal 
{
    public static void levelOrder(Node root) {
      
        Queue<Node> que = new LinkedList<Node>();
        que.add(root);
        while(!que.isEmpty())
        {
            Node node = que.poll();
            System.out.printf("%d ", node.data);
            
            if(node.left != null)
            {
                que.add(node.left);
            }
            
            if(node.right != null)
            {
                que.add(node.right);
            }
        }
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
    
        TreeTraversal.levelOrder(root);
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
  3 2 5 1 4 6 7
  
Online Resource:  
  https://www.hackerrank.com/challenges/tree-level-order-traversal/problem
*/