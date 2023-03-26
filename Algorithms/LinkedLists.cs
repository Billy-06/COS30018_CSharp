namespace COS30018.Algorithms;

public class LinkedLists
{
    public Node Head { get; set; }
    public Node Tail { get; set; }

    public void Add(int value)
    {
        Node node = new Node { Value = value };

        if (Head == null)
        {
            Head = node;
            Tail = node;
        }
        else
        {
            Tail.Next = node;
            Tail = node;
        }
    }

    public void Remove(int value)
    {
        Node current = Head;
        Node previous = null;

        while (current != null)
        {
            if (current.Value == value)
            {
                if (previous != null)
                {
                    previous.Next = current.Next;

                    if (current.Next == null)
                    {
                        Tail = previous;
                    }
                }
                else
                {
                    Head = Head.Next;

                    if (Head == null)
                    {
                        Tail = null;
                    }
                }
            }

            previous = current;
            current = current.Next;
        }
    }

    public void Print()
    {
        Node current = Head;

        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }

    public void Reverse()
    {
        Node previous = null;
        Node current = Head;
        Node next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }

        Tail = Head;
        Head = previous;
    }
}

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
}