/**
Problem: You are given a pointer/ reference to the node which is to be deleted from the linked list of N nodes. 
  The task is to delete the node. Pointer/ reference to head node is not given. 
  Note: No head reference is given to you. It is guaranteed that the node to be deleted is not a tail node in the linked list.

Expected Time Complexity : O(1)
Expected Auxilliary Space : O(1)
*/

public class Exercise23 {
    void deleteNode(Node node)
    {
         Node nextNode = node.next;
         node.data = nextNode.data;
         node.next = nextNode.next;
    }
}

/**
 * 
Online Resource:  
  https://practice.geeksforgeeks.org/problems/delete-without-head-pointer/1/
*/
