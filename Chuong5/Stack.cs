using System;

class Stack
{
    private Node _top;
    private int _count;

    internal Node Top
    {
        get
        {
            return _top;
        }

        private set
        {
            _top = value;
        }
    }

    public int Count
    {
        get
        {
            return _count;
        }

        private set
        {
            _count = value;
        }
    }

    public Stack()
    {
        _top = null;
        _count = 0;
    }

    public void Push(int value)
    {
        Node pNew = new Node(value);
        if (pNew == null)
        {
            throw new Exception("Khong the them vao stack");
        }
        if (_top == null)
        {
            _top = pNew;
        }
        else
        {
            pNew.Next = _top;
            _top = pNew;
        }
        _count++;
    }

    public int Pop()
    {
        if (_top == null)
        {
            throw new Exception("Stack rong");
        }
        Node pTemp = _top;
        _top = pTemp.Next;
        int temp = pTemp.Data;
        _count--;
        pTemp = null;
        return temp;
    }

    public int Peek()
    {
        if (_top == null)
        {
            throw new Exception("Stack rong");
        }
        return _top.Data;
    }

    public bool IsEmpty()
    {
        return (_top == null);
    }

    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack rong");
        }
        else
        {
            Node p = _top;
            while (p != null)
            {
                Console.WriteLine(p.Data);
                p = p.Next;
            }
        }
    }

    public void Clear()
    {
        Node tempNode;
        while (_top!=null)
        {
            tempNode = _top;
            _top = tempNode.Next;
            tempNode = null;
        }
        _count = 0;
    }
}

