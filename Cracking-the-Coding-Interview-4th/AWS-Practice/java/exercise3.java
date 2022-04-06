class LinkedListNode {
    public int data;
    public LinkedListNode next;
}

class exercise3{
    public static LinkedListNode merge_sorted(LinkedListNode head1, LinkedListNode head2) {    
        if (head1 == null || head2 == null)
        {
            return null;
        }
        LinkedListNode head = null;
        LinkedListNode previous = null;
        LinkedListNode current = null;
        while(head1 != null || head2 != null)
        {
            if (previous == null)
            {
                if (head1.data < head2.data)
                {                 
                    head = head1;
                    previous = head;
                    head1 = head1.next;
                }
                else
                {                  
                    head = head2;
                    previous = head;
                    head2 = head2.next;
                }
            }
            else if (head1 != null && head2 != null)
            {
                if (head1.data < head2.data)
                {
                    previous.next = head1;
                    current = head1;
                    head1 = head1.next;
                }
                else
                {
                    previous.next = head2;
                    current = head2;
                    head2 = head2.next;
                }
                
            }
            else if (head2 == null)
            {
                previous.next = head1;
                current = head1;
                head1 = head1.next;
            }
            else if (head1 == null)
            {
            previous.next = head2;
            current = head2;
            head2 = head2.next;
            }

            
            if (current != null)
            {
                previous = current;
            }
        }
  
        return head;
    }
  }