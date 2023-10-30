public class LinkedList
{
    private Node head;

    public void Add(string item)
    {
        Node newNode = new Node(item);

        if (head == null || string.Compare(item, head.Data, StringComparison.OrdinalIgnoreCase) < 0)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null && string.Compare(item, current.Next.Data, StringComparison.OrdinalIgnoreCase) > 0)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }
    }

    public bool Contains(string item)
    {
        Node current = head;
        while (current != null)
        {
            if (string.Equals(current.Data, item, StringComparison.OrdinalIgnoreCase))
                return true;
            current = current.Next;
        }
        return false;
    }

    public bool Remove(string item)
    {
        if (head == null) return false;

        if (string.Equals(head.Data, item, StringComparison.OrdinalIgnoreCase))
        {
            head = head.Next;
            return true;
        }

        Node current = head;
        while (current.Next != null && !string.Equals(current.Next.Data, item, StringComparison.OrdinalIgnoreCase))
        {
            current = current.Next;
        }

        if (current.Next == null) return false;

        current.Next = current.Next.Next;
        return true;
    }

    public void PrintAllNodes()
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }
}
