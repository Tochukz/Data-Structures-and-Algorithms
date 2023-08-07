class Node {
    int Data;

    Next Node;

    public Node(int data) {
        Data = data;
    }

    public AppendAtTail(int data) {
        Node current = this;
        while(current.Next != null) {
            current = current.Next;
        }
        current.Next = new Node(data);
    }

    public Node DeleteNode(Node head, int data) {
        Node current = head;
        if (current.Data == data) {
            return head.Next;
        }

        while(current.Next != null) {
            if (current.Data == data) {
                current.Next = current.Next.Next;
                return head;
            }
            current = current.Next;
        }
        return head;
    }
}