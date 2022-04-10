/**
  Problem:  Given a sorted (increasing order) array, write an algorithm to create a binary tree with minimal height.
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
    public Node ArrayToBST(int[] sortedN, int start, int end)
    {
        if (start > end)
        {
            return null;
        }
        int mid = (start + end) / 2;
        Node node = new Node(sortedN[mid]);
        node.Left =  ArrayToBST(sortedN, start, mid -1);
        node.Right = ArrayToBST(sortedN, mid + 1, end);

        return node;
    }

    public void PrintPreOrder(Node node)
    {
        if (node == null)
        {
            return;
        }
        Console.Write("{0} ", node.Data);
        PrintPreOrder(node.Left);        
        PrintPreOrder(node.Right);
    }

    public void PrintLevelOrder(Node root)
    {
        Queue<Node> que = new Queue<Node>();
        que.Enqueue(root);
        while(que.Count > 0)
        {
            Node node = que.Dequeue();
            Console.Write("{0} ", node.Data);

            if (node.Left != null)
            {
                que.Enqueue(node.Left);
            }
            if (node.Right != null)
            {
                que.Enqueue(node.Right);
            }
        }
        Console.Write("\n");
    }
}

BinaryTree tree = new BinaryTree();

int[] sortedN = new int[]{1, 2, 3, 4, 5, 6 ,7};
Node root = tree.ArrayToBST(sortedN, 0, sortedN.Length - 1);

Console.WriteLine("Traverse InOrder");
tree.PrintPreOrder(root);

Console.WriteLine("\nTraverse LevelOrder");
tree.PrintLevelOrder(root);

/**
 Method    | Time Complexity | Space Complexity 
ArrayToBST |     O(n)        |   

Online Resource: 
  https://www.geeksforgeeks.org/sorted-array-to-balanced-bst/

*/