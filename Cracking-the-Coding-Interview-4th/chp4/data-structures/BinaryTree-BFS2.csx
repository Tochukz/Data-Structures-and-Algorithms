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

class BinaryTreeBFS2
{
    public Node Root;

    public BinaryTreeBFS2()
    {

    }

    public BinaryTreeBFS2(int data)
    {
        Root = new Node(data);
    }

    /* Breadth-First or LevelOrder Traversal */
    public void TraverseLevelOrder()
    {
        if (Root == null)
        {
            return;
        }

        Queue<Node> nodeQueue = new Queue<Node>();
        nodeQueue.Enqueue(Root);
        while(nodeQueue.Count > 0)
        {
            Node node = nodeQueue.Dequeue();
            Console.Write($"{node.Data} ");
             
            if (node.Left != null)
            {
                nodeQueue.Enqueue(node.Left);
            }
            if(node.Right != null)
            {
                nodeQueue.Enqueue(node.Right);
            }
            
        }
    }
}

/**
      1 
   2     3
 4  5   6  7
*/

BinaryTreeBFS2 tree  = new BinaryTreeBFS2(1);
tree.Root.Left = new Node(2);
tree.Root.Right = new Node(3);

tree.Root.Left.Left = new Node(4);
tree.Root.Left.Right = new Node(5);

tree.Root.Right.Left = new Node(6);
tree.Root.Right.Right = new Node(7);

tree.TraverseLevelOrder();

/**
 Method             | Time Complexity | Space Complexity  
TraverseLevelOrder  |     O(n)        |      O(n)
 
Here I implement the Breadth-first(level-order) traversal for a binary tree

 Output: 
   1 2 3 4 5 6 7

 Online Resource: 
   https://www.geeksforgeeks.org/level-order-tree-traversal/
*/