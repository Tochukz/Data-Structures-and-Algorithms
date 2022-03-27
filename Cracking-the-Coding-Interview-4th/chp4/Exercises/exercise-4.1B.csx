class Node 
{
    public int Data;

    public Node Next;

    public Node(int data)
    {
        Data = data;
    }
}

class BinaryTree
{
    public Node Root;
}

/**
  exercise-4.1A can be optimized by calculating the height in the same recursion rather than calling height function separately  

Online Resource:  
  https://www.geeksforgeeks.org/how-to-determine-if-a-binary-tree-is-balanced/
*/