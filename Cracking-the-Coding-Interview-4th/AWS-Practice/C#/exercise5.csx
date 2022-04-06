/**
Problem: Level Order Traversal of Binary Tree
  Given the root of a binary tree, display the node values at each level. 
  Node values for all levels should be displayed on separate lines.
 
Constraint: 
  Runtime Complexity: Linear, O(n)
  Memory Complexity: Linear, O(n)
*/

using System.Collections.Generic;

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
class Exercise5
{
    private static void TreeToDictionary(Node root, Dictionary<int, List<Node>> nodeLevels, int level)
    {
       if (root == null)
       {
           return;
       }
       if(!nodeLevels.ContainsKey(level)) 
       {
          nodeLevels.Add(level, new List<Node>());
       }
       nodeLevels[level].Add(root);

       TreeToDictionary(root.Left, nodeLevels, level + 1);
       TreeToDictionary(root.Right, nodeLevels, level + 1);
    }

    public static void PrintTree(Node root)
    {
        Dictionary<int, List<Node>> nodeLevels = new Dictionary<int, List<Node>>();
        TreeToDictionary(root, nodeLevels, 0);
        foreach(KeyValuePair<int, List<Node>> item in nodeLevels)
        {
            foreach(Node node in item.Value)
            {
                Console.Write("{0} ", node.Data);
            }
            Console.Write("\n");
        }
    }
}

/**
       100
    50     200
  25  75       300 
*/
Node head = new Node(100);
head.Left = new Node(50);
head.Right = new Node(200);
head.Left.Left = new Node(25);
head.Left.Right = new Node(75);
head.Right.Right = new Node(350);

Exercise5.PrintTree(head);

/**
Output: 
  100 
  50 200 
  25 75 350

Online Resource: 
  https://www.geeksforgeeks.org/print-binary-tree-2-dimensions/

Online Exercise: 
  https://www.educative.io/m/level-order-traversal-binary-tree
*/