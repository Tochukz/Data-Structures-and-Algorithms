/**
 Problem: Detect Loop in linked list 
   Given a linked list of N nodes. The task is to check if the linked list has a loop. 
   Linked list can contain self loop.
 */

class ExerciseC 
{
    //Function to check if the linked list has a loop.
    public static boolean detectLoop(Node head)
    {
        Node slowNode = head;
        Node fastNode = head;
        
        while(slowNode != null && fastNode != null && fastNode.next != null)
        {
            slowNode = slowNode.next;
            fastNode = fastNode.next.next;
            if (slowNode == fastNode)
            {
                return true;
            }        
        }
        return false;
    }
}

/**
 
Online Resource: 
  https://www.geeksforgeeks.org/detect-loop-in-a-linked-list/
  https://practice.geeksforgeeks.org/problems/detect-loop-in-linked-list/1#
*/