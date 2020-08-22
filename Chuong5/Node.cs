
using System;

class Node
    
{
    private int data;
    private Node next;

    internal int Data
    {
        get
        {
            return data;
        }

        set
        {
            data = value;
        }
    }

    internal Node Next
    {
        get
        {
            return next;
        }

        set
        {
            next = value;
        }
    }

    public Node(int value)
    {
        data = value;
        next = null;
    }
}

