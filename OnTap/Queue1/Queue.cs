using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class Queue
    {
        private Node front;
        private Node rear;
        private int count;

        internal Node Front
        {
            get
            {
                return front;
            }
        }

        internal Node Rear
        {
            get
            {
                return rear;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public Queue()
        {
            front = null;
            rear = null;
            count = 0;
        }
        //EnQueue(MonHoc)
        public Node EnQueue(MonHoc mh)
        {
            Node p = new Node(mh);
            if (p == null)
            {
                throw new Exception("Khong the them vao Queue");
            }
            if (front == null)
            {
                front = p;
            }
            else
            {
                p.Next = front;
                front = p;
            }
            count++;
            return p;
        }
        //EnQueue
        public Node EnQueue(string maMH, string tenMH, int soTC, long hocPhi)
        {
            Node p = new Node(new MonHoc(maMH, tenMH, soTC, hocPhi));
            if (p == null)
            {
                throw new Exception("Khong the them vao Queue");
            }
            if (front == null)
            {
                front = p;
            }
            else
            {
                p.Next = front;
                front = p;
            }
            count++;
            return p;
        }
        //DeQueue
        public void DeQueue()
        {
            if (count >= 1)
            {
                front = front.Next;
                count--;
            }
        }
        //Peek
        public string Peek()
        {
            if (front == null)
            {
                throw new Exception("Queue rong");
            }
            return front.Monhoc.toString();
        }
        //FindNode
        public Node FindNode(string maMH)
        {
            for (Node p = front; p != null; p = p.Next)
            {
                if (maMH == p.Monhoc.MaMH)
                {
                    return p;
                }
            }
            return null;
        }
        //FindPreviousNode
        public Node FindPreviousNode(Node p)
        {
            Node pre = front;
            while (pre.Next != p)
            {
                pre = pre.Next;
            }
            return pre;
        }
        //Display
        public void Display()
        {
            if (front == null)
            {
                throw new Exception("Queue rong");
            }
            else
            {
                for (Node p = front; p != null; p = p.Next)
                {
                    Console.WriteLine(p.Monhoc.toString());
                }
            }
        }
    }
}
