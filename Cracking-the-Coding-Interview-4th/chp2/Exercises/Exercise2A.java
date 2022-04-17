/**
Problem: Reverse a linked list 
   Given a linked list of N nodes. The task is to reverse this list.  

Expected Time Complexity: O(N).
Expected Auxiliary Space: O(1).
 */

public class Exercise2A
{
    Node reverseList(Node head)
    {
        // code here
        if (head == null || head.next == null)
        {
            return head;
        }
        
        Node rest = reverseList(head.next);
        head.next.next = head;
        
        head.next = null;
        return rest;
    }
}

/**
Online Resource: 
  https://www.geeksforgeeks.org/reverse-a-linked-list/
  https://practice.geeksforgeeks.org/problems/reverse-a-linked-list/1/
    
*/