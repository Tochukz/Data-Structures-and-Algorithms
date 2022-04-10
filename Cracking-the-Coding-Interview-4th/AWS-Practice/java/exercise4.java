import java.util.*;

class LinkedListNode {
  public int data;
  public LinkedListNode next;
  public LinkedListNode arbitrary_pointer;
  LinkedListNode(int d)
  {
    data = d;
  }
}

class exercise4 {
    public static LinkedListNode deep_copy_arbitrary_pointer(LinkedListNode head) {
        HashMap<LinkedListNode, LinkedListNode> nodeMap = new HashMap<LinkedListNode, LinkedListNode>();
      
        LinkedListNode copyHead = null;
        LinkedListNode copyPrev = null;
        
        LinkedListNode current = head;
        while(current != null)
        {   
          LinkedListNode newNode = new LinkedListNode(current.data);
          newNode.arbitrary_pointer = current.arbitrary_pointer;
          if (copyPrev == null)
          {
              copyHead = newNode;
              copyPrev = newNode;
          }
          else
          {
              copyPrev.next = newNode;
              copyPrev = newNode;
          }
    
          nodeMap.put(current, newNode);
          current = current.next;
        }
    
        current = copyHead;
        while(current != null)
        {
          if (current.arbitrary_pointer != null)
          {
              current.arbitrary_pointer = nodeMap.get(current.arbitrary_pointer);
          }
          current = current.next;
        }
        return copyHead;
    }  
  }