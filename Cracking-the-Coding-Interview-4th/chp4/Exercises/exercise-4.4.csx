
/**
 Problem:  
   Given a binary search tree, design an algorithm which creates a linked list of all the nodes at each depth (i.e., if you have a tree with depth D, you’ll have D linked lists).
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
    private void LevelOrderTraversal(Node root, Dictionary<int, LinkedList<int>> dict, int level)
    {
        if (root == null)
        {
            return;
        }
        if (!dict.ContainsKey(level))   
        {
            dict.Add(level, new LinkedList<int>());
        }
        dict[level].AddLast(root.Data);
        LevelOrderTraversal(root.Left, dict, level+1);
        LevelOrderTraversal(root.Right, dict, level+1);

    }
    public List<LinkedList<int>> TreeToLinkedList(Node root)
    {
        Dictionary<int, LinkedList<int>> dict = new Dictionary<int, LinkedList<int>>();
        LevelOrderTraversal(root, dict, 0);
        return dict.Values.ToList();
    }     

    public void PrintListOfLinkedList(List<LinkedList<int>> listOfList)
    {
        foreach(LinkedList<int> list in listOfList)
        {
            foreach(int x in list)
            {
                Console.Write($"{x} ");
            }
            Console.Write("\n");
        }
    }
}

/**
             1
         2            3
    4        5     6     7
 8    9  10 
*/

Node root = new Node(1);
root.Left = new Node(2);
root.Right = new Node(3);

root.Left.Left = new Node(4);
root.Left.Right = new Node(5);
root.Right.Left = new Node(6);
root.Right.Right = new Node(7);

root.Left.Left.Left = new Node(8);
root.Left.Left.Right = new Node(9);
root.Left.Right.Left = new Node(10);

BinaryTree tree = new BinaryTree();
List<LinkedList<int>> listOfLkList = tree.TreeToLinkedList(root);
tree.PrintListOfLinkedList(listOfLkList);


/**
Output: 
  1 
  2 3
  4 5 6 7
  8 9 10
*/