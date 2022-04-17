/** 
Problem:  Given an unsorted linked list of N nodes. The task is to remove duplicate elements from 
    this unsorted Linked List. 
    When a value appears in multiple nodes, the node which appeared first should be kept, all others duplicates are 
    to be removed.

Expected Time Complexity: O(N)
Expected Auxiliary Space: O(N)
*/

class Exercise21
{
    public Node removeDuplicates(Node head) 
    {
         HashSet<Integer> set = new HashSet<Integer>();
         Node prev = null;
         Node current = head;
         while(current != null)
         {
             if (set.contains(current.data))
             {
                 prev.next = current.next;
             }
             else
             {
                 set.add(current.data);
                 prev = current;
             }
             current = current.next;
         }
         return head;
    }

    public static void main(String[] args)
    {
        // int value[] = {5,2,2,4};
        // Output: 5 2 4
    }
}

/**
Online Resources: 
 https://practice.geeksforgeeks.org/problems/remove-duplicates-from-an-unsorted-linked-list/1/# 
*/