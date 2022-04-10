import java.util.*;

class BinaryTreeNode
{
    public int data;
    
    public BinaryTreeNode left;

    public BinaryTreeNode right;
}
class exercise5 {
    
    private static void treeToHashMap(BinaryTreeNode root, HashMap<Integer, List<BinaryTreeNode>> map, int level)
    {
        if(root == null)
        {
           return;
        }
        if (!map.containsKey(level))
        {
            map.put(level, new ArrayList<BinaryTreeNode>());
        }
        map.get(level).add(root);
        treeToHashMap(root.left, map, level + 1);
        treeToHashMap(root.right, map, level + 1);
    }
    public static String level_order_traversal(BinaryTreeNode root) {
       HashMap<Integer, List<BinaryTreeNode>> map = new HashMap<Integer, List<BinaryTreeNode>>();
       treeToHashMap(root, map, 0);
       StringBuilder builder = new StringBuilder();
       for(Map.Entry<Integer, List<BinaryTreeNode>> item : map.entrySet())
       {
          for(BinaryTreeNode node : item.getValue())
          {
              builder.append(node.data + ",");
              System.out.printf(node.data + " ");
          }
          System.out.printf("\n");
       }
       return builder.toString();
    }
  } 