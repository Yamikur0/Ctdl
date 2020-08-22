using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Queue
    {
        //Field
        private Node front;
        private Node rear;
        private int count;
        //Properties
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
        //Methods
        public Queue()
        {
            front = null;
            rear = null;
            count = 0;
        }

        //EnQueue
        public void EnQueue(HangHoa hh)
        {
            Node newNode = new Node(hh);
            if (newNode == null)
            {
                throw new Exception("Khong the them vao Queue");
            }
            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
            count++;
        }
        
        public void EnQueue(string maHH, string tenHang, int soLuong, int donGia)
        {
            HangHoa hh = new HangHoa(maHH, tenHang, soLuong, donGia);
            EnQueue(hh);
        }

        //DeQueue
        public bool DeQueue()
        {
            bool isRemove = false;
            if (count >= 1)
            {
                front = front.Next;
                count--;
                isRemove = true;
            }
            return isRemove;
        }
        //Peek
        public string Peek()
        {
            if (front == null)
            {
                throw new Exception("Queue rong!");
                
            }
            return front.HangHoa.toString();
        }
        //Hien thi Queue
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue rong!");
            }
            else
            {
                for (Node p = front; p != null; p = p.Next)
                {
                    Console.WriteLine(p.HangHoa.toString());
                }
            }
        }
    }
}
