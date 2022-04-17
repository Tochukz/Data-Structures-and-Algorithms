/**
 Problem: Given a linked list consisting of L nodes and given a number N. 
   The task is to find the Nth node from the end of the linked list.

Expected Time Complexity: O(N).
Expected Auxiliary Space: O(1).
*/

public class Exercise22 {
    int getNthFromLast(Node head, int n)
    { 
        int len = 0;
        Node current = head;
        while(current != null)
        {   len++;
            current = current.next;
        }

        int x = len - n;
        if (x < 0)
        {
            return -1;
        }
        current = head;
        while(x > 0)
        {
            current = current.next;
            x--;
        }
        return current.data;	
    }

    public static void main(String[] args)
    {
       // Input:
       // N = 2
       //LinkedList: 1->2->3->4->5->6->7->8->9
       //Output: 8
    }
}


/**
 Online Resource:  
   https://practice.geeksforgeeks.org/problems/nth-node-from-end-of-linked-list/1/ 
*/