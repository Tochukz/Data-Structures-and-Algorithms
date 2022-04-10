import java.util.*;

class exercise43
{
    public Node arrayToBST(int[] nums, int start, int end)
    {
        if (start > end) {
            return null;
        }
        int mid = (start + end) / 2;
        Node node = new Node(nums[mid]);
        node.left = arrayToBST(nums, start, mid - 1);
        node.right = arrayToBST(nums, mid + 1, end);
        
        return node;
    }
    
    public int[] sortedArrayToBST(int[] nums)
    {
        Node root = arrayToBST(nums, 0, nums.length - 1);
        ArrayList<Integer> preOrderList = new ArrayList<Integer>();
        makePreOrder(root, preOrderList);
        int[] preOrderArry = new int[preOrderList.size()];
        for (int i = 0; i < preOrderList.size(); i++)
        {
            preOrderArry[i] = preOrderList.get(i);
        }
        return preOrderArry;
    }
    
    public void makePreOrder(Node root,  ArrayList<Integer> preorder)
    {
        if (root == null)
        {
            return;
        }
        preorder.add(root.data);
        makePreOrder(root.left, preorder);
        makePreOrder(root.right, preorder);
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
 Online Resource: 
   https://www.geeksforgeeks.org/sorted-array-to-balanced-bst/
 Online Practice: 
   https://practice.geeksforgeeks.org/problems/array-to-bst4443/1/ 
*/