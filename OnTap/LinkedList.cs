using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    class LinkedList
    {
        private Node first;
        private Node last;
        private int count;

        internal Node First
        {
            get
            {
                return first;
            }
        }

        internal Node Last
        {
            get
            {
                return last;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public LinkedList()
        {
            first = null;
            last = null;
            count = 0;
        }
        //AddFirst(MonHoc)
        public Node AddFirst(MonHoc mh)
        {
            Node newnd = new Node(mh);
            if (count == 0)
            {
                first = newnd;
                last = newnd;
            }
            else
            {
                newnd.Next = first;
                first = newnd;
            }
            count++;
            return newnd;
        }
        //AddFirst(string maMH,string tenMH,int soTC,long hocPhi)
        public Node AddFirst(string maMH, string tenMH, int soTC, long hocPhi)
        {
            Node newnd = new Node(new MonHoc(maMH, tenMH, soTC, hocPhi));
            if (count == 0)
            {
                first = newnd;
                last = newnd;
            }
            else
            {
                newnd.Next = first;
                first = newnd;
            }
            count++;
            return newnd;
        }
        //AddLast(MonHoc)
        public Node AddLast(MonHoc mh)
        {
            Node newnd = new Node(mh);
            if (count == 0)
            {
                first = newnd;
                last = newnd;
            }
            else
            {
                last.Next = newnd;
                last = newnd;
            }
            count++;
            return newnd;
        }
        //FindNode(MonHoc)
        public Node FindNode(MonHoc mh)
        {
            for (Node p = first; p != last; p = p.Next)
            {
                if (p.MonHoc.Equals(mh))
                {
                    return p;
                }
            }
            return null;
        }
        //FindNode(string maMH)
        public Node FindNode(string maMH)
        {
            for (Node p = first; p != null; p = p.Next)
            {
                if (p.MonHoc.MaMH == maMH)
                {
                    return p;
                }
            }
            return null;
        }
        //FindPreviousNode(Node)
        public Node FindPreviousNode(Node p)
        {
            Node pre = first;
            while (pre.Next != p)
            {
                pre = pre.Next;
            }
            return pre;
        }
        //AddAfter(string maMH, string tenMH, int soTC, long hocPhi)
        public Node AddAfter(Node pre, string maMH, string tenMH, int soTC, long hocPhi)
        {
            Node newnd = new Node(new MonHoc(maMH, tenMH, soTC, hocPhi));
            if (pre != null)
            {
                newnd.Next = pre.Next;
                pre.Next = newnd;
                if (pre == last)
                {
                    last = newnd;
                }
                count++;
            }
            return newnd;
        }
        //RemoveFirst
        public Node RemoveFirst()
        {
            Node p = first;
            if (p != null)
            {
                first = p.Next;
                if (first == null)
                {
                    last = null;
                }
                count--;
            }
            return last;
        }
        //RemoveLast
        public Node RemoveLast()
        {
            if (first == last)
            {
                first = null;
                last = null;
                count = 0;
            }
            else
            {
                last = FindPreviousNode(last);

                count--;
            }
            return last;
        }
        //RemoveAfter(Node)
        public Node RemoveAfter(Node pre)
        {
            Node del;
            if (pre != null)
            {
                del = pre.Next;
                if (del != null)
                {
                    pre.Next = del.Next;
                    if (pre.Next != null)
                    {
                        last = pre;
                    }
                    count--;
                }
            }
            return last;
        }
        //RemoveAfter(MonHoc)
        public Node RemoveAfter(MonHoc mh)
        {
            Node newnd = new Node(mh);
            Node del;
            if (newnd != null)
            {
                del = newnd.Next;
                if (del != null)
                {
                    newnd.Next = del.Next;
                    if (newnd.Next != null)
                    {
                        last = newnd;
                    }
                    count--;
                }
            }
            return last;
        }
        //Remove(Node)
        public void Remove(Node value)
        {
            Node f = FindNode(value.MonHoc);
            Node fp = FindPreviousNode(value);
            if (f == first)
            {
                RemoveFirst();
            }
            
            else
            {
                RemoveAfter(fp);
            }

        }
        //FindMax
        public long FindMax()
        {
            long max = 0;
            for (Node p = first; p != null; p = p.Next)
            {
                if (p.MonHoc.HocPhi > max)
                {
                    max = p.MonHoc.HocPhi;
                }
            }
            return max;
        }
        //FindMin
        public long FindMin()
        {
            long min = FindMax();
            for (Node p = first; p != null; p = p.Next)
            {
                if (p.MonHoc.HocPhi < min)
                {
                    min = p.MonHoc.HocPhi;
                }
            }
            return min;
        }
        //GetAverage
        public double GetAverage()
        {
            double tbc = 0;
            double s = 0;
            for (Node p = first; p != null; p = p.Next)
            {
                s += p.MonHoc.HocPhi;
            }
            tbc = s / count;
            return tbc;
        }
        //CountNode(int soTC)
        public int CountNode(int soTC)
        {
            int dem = 0;
            for (Node p = first; p != null; p = p.Next)
            {
                if (soTC == p.MonHoc.SoTC)
                {
                    dem++;
                }
            }
            return dem;
        }
        //Swap
        public void Swap(Node a, Node b)
        {
            MonHoc tmp = a.MonHoc;
            a.MonHoc = b.MonHoc;
            b.MonHoc = tmp;
        }
        //InterchangeSort
        public void InterchangSort()
        {
            for (Node p = first; p != null; p = p.Next)
            {
                for (Node q = p.Next; q!=null; q = q.Next)
                {
                    if (p.MonHoc.MaMH.CompareTo(q.MonHoc.MaMH) == 1)
                    {
                        Swap(q, p);
                    }
                }
            }
        }
        //BubbleSort
        public void BubbleSort()
        {
            for (Node p = first; p != null; p = p.Next)
            {
                for (Node q = first; q != last; q = q.Next)
                {
                    if (p.MonHoc.MaMH.CompareTo(q.MonHoc.MaMH) == 1)
                    {
                        Swap(q, p);
                    }
                }
            }
        }
        //SelectionSort
        public void SelectionSort()
        {
            Node min;
            for (Node p = first; p != null; p = p.Next)
            {
                min = p;
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (q.MonHoc.MaMH.CompareTo(min.MonHoc.MaMH) == 1)
                    {
                        min = q;
                    }
                }
                Swap(min, p);
            }
        }
        public void Print()
        {
            Node p = first;
            while (p != null)
            {
                Console.WriteLine(p.MonHoc.toString());
                p = p.Next;
            }
        }
    }
}
