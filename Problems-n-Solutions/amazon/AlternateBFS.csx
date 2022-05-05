/**
 Problem: Print out items of a Binary Tree in a zig-zag fashion 
 For example 
      1
    2     3
  4   5  6  7

  ->  1   3  2  4  5  6  7 
 Level 0 is printed from left to right, level 1 is printed right to left, level 2 is printed left to right etc 
 
 Note: You may not slant the container and n is at least 2
 */

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

class TreePrint
{
    public static void AddLevel(Node node, List<List<int>> listOfList, int level)
    {
        if (node == null)
        {
            return;
        }
        if (level >= listOfList.Count)
        {
            listOfList.Add(new List<int>());
        }
        listOfList[level].Add(node.data);

        AddLevel(node.left, listOfList, level + 1);
        AddLevel(node.right, listOfList, level + 1);
    }

    public static void PrintBFSAlternate(Node root)
    {
        if (root == null)
        {
            return;
        }
        
        List<List<int>> listOfList = new List<List<int>>();
        AddLevel(root, listOfList, 0);
       
        int i = 0;
        foreach(List<int> list in listOfList)
        {
            if (i % 2 == 0)
            {
                for(int j = 0; j < list.Count; j++)
                {
                    Console.Write(list[j] + " ");
                }
            }
            else 
            {
                for(int k = list.Count - 1; k >= 0; k--)
                {
                    Console.Write(list[k] + " ");
                }
            }
            i++;
        }
    }

    public static void PrintBFS(Node root)
    {
        if (root == null)
        {
            return;
        }

        Queue<Node> que = new Queue<Node>();
        Node current = root;
        que.Enqueue(root);

        while(que.Count > 0)
        {
            Node node = que.Dequeue();
            Console.Write(node.data + " ");
            if (node.left != null)
            {
                que.Enqueue(node.left);
            }
            if (node.right != null)
            {
                que.Enqueue(node.right);
            }
        }
        Console.Write("\n");
    }
}

/**
                 1
       2                  3
  4         5         6        7
8   9    10  11    12  13   14  15
*/

Node root = new Node(1);
root.left = new Node(2);
root.right = new Node(3);

root.left.left = new Node(4);
root.left.right = new Node(5);

root.right.left = new Node(6);
root.right.right = new Node(7);

root.left.left.left = new Node(8);
root.left.left.right = new Node(9);

root.left.right.left = new Node(10);
root.left.right.right = new Node(11);

root.right.left.left = new Node(12);
root.right.left.right = new Node(13);

root.right.right.left = new Node(14);
root.right.right.right = new Node(15);

TreePrint.PrintBFS(root);
TreePrint.PrintBFSAlternate(root);

/**
Output:  
  1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 
  1 3 2 4 5 6 7 15 14 13 12 11 10 9 8
*/



