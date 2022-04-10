class BinaryTreeNode
{
    public int data;
    
    public BinaryTreeNode left;

    public BinaryTreeNode right;
}

class exercise6 {

    static boolean isBst(BinaryTreeNode root, int minVal, int maxVal)
    {
        if (root == null)
        {
            return true;
        }
        if (root.data < minVal || root.data > maxVal)
        {
            return false;
        }
        return isBst(root.left, minVal, root.data) && isBst(root.right, root.data, maxVal);
    }
  
    public static boolean is_bst(
        BinaryTreeNode root) {
      return isBst(root, Integer.MIN_VALUE, Integer.MAX_VALUE);
    }
  }