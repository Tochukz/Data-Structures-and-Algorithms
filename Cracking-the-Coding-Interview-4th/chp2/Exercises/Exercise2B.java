/**
 Problem:  Add two numbers represented by linked lists
   Given two numbers represented by two linked lists of size N and M. The task is to return a sum list. 
   The sum list is a linked list representation of the addition of two input numbers from the last.
 */

public class Exercise2B 
{
    static Node addTwoLists(Node first, Node second) 
    {
        Node firstHead = reverseList(first);
        Node secondHead = reverseList(second);
        Node head = null;
        Node current = null;
        int data;
        int x1; 
        int x2;
        int carryOver = 0;
        while(firstHead != null || secondHead != null)
        {
            x1 = 0;
            x2 = 0;
            if (firstHead != null)
            {
                x1 =  firstHead.data;
                firstHead = firstHead.next;
            }
            if (secondHead != null)
            {
                x2 =  secondHead.data;
                secondHead = secondHead.next;
            }
            
            data = x1 + x2 + carryOver;
            if (data >= 10)
            {
                carryOver = data / 10;
                data = data % 10;
            }
            else
            {
                carryOver = 0;
            }
            
            if (head == null)
            {
                head = new Node(data);
                current = head;
            }
            else
            {
                Node node = new Node(data);
                current.next = node;
                current = node;
            }
        }

        if (carryOver > 0)
        {
            Node node = new Node(carryOver);
            current.next = node;
        }
        
        Node thirdHead = reverseList(head);
        return thirdHead;
    }
    
    static Node reverseList(Node head)
    {
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
  https://www.geeksforgeeks.org/add-two-numbers-represented-by-linked-lists/
  https://practice.geeksforgeeks.org/problems/add-two-numbers-represented-by-linked-lists/1
*/