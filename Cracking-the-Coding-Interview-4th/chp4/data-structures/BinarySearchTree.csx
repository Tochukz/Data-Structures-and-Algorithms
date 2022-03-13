class Node 
{
    public Node Left;

    public Node Right;

    public int Key;

    public Node(int key)
    {
       Key = key;
    }
}

class BinarySearchTree
{
    Node Root;

    public Node Search(Node parent, int key)
    {
        if (parent == null || parent.Key == key)
        {
            return parent;
        }

        if (key < parent.Key)
        {
            return Search(parent.Left, key);
        }
        else 
        {
            return Search(parent.Right, key);
        }
    }

    public Node InsertKey(Node parent, int key)
    {
        if (parent == null)
        {
            parent = new Node(key);
            return parent;
        }

        if (key < parent.Key)
        {
            parent.Left = InsertKey(parent.Left, key);
        }
        else if (key > parent.Key)
        {
            parent.Right = InsertKey(parent.Right, key);
        }
        return parent;
    }
}