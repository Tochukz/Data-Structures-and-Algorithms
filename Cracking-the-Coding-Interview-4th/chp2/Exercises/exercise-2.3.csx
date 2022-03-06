/* Implement an algorithm to delete a node in the middle of a single linked list, given only access to that node */

class Node 
{
    public int Data;

    public Node Next;

    public Node(int data)
    {
        Data = data;
    }
}

class SinglyLinkedList 
{
    public Node Head;

    public SinglyLinkedList(int[] numbers)
    {
        Node prev = null;
        for(int i = 0; i < numbers.Length; i++)
        {
            Node newNode = new Node(numbers[i]);
            if( i == 0)
            {
                Head = newNode;
                prev = newNode;
            }
            else 
            {
                prev.Next = newNode;
                prev = newNode;
            }
        }
    }

    /**
    * Deletes the target node without references to the LinkedList or Head 
    * This target node is in bewteen the begining and end of the list 
    */
    public void DeleteNode(Node targetNode)
    {
        if (targetNode.Next != null)
        {
            Console.WriteLine($"Deleting node {targetNode.Data}");
            Node next = targetNode.Next;
            targetNode.Data = next.Data;         
            targetNode.Next = next.Next;
        } 
        
    }

    public void PrintList()
    {
        if (Head == null)
        {
            Console.WriteLine("The list is empty!");
        }
        Node current = Head;
        while(current != null)
        {
            Console.Write($"{current.Data} ");
            current = current.Next;
        }
        Console.WriteLine("\n");
    }

}

SinglyLinkedList linkedList = new SinglyLinkedList(new int[]{1, 2, 3, 4, 5});
linkedList.PrintList(); // 1 2 3 4 5
Node node2 = linkedList.Head.Next;
Node node3 = node2.Next;
linkedList.DeleteNode(node2);
linkedList.DeleteNode(node3); 
linkedList.PrintList(); //  1 3 4 5

//Todo: The SinglyLinkedList.DeleteNode() implementation is not working as expected. 