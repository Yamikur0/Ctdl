using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lk = new LinkedList();
            lk.AddFirst(new MonHoc("123", "abc", 1, 3000));
            lk.AddLast(new MonHoc("234", "bcd", 2, 2000));
            lk.AddFirst("345", "cde", 3, 3000);
            lk.AddAfter(lk.FindNode(new MonHoc("123", "abc", 1, 3000)), "456", "def", 4, 4000);
            //Console.WriteLine(lk.FindNode(new MonHoc("123", "abc", 1, 3000)).MonHoc.toString());
            //lk.RemoveAfter(lk.FindNode(new MonHoc("123", "abc", 1, 1000)));
            //lk.RemoveAfter(new MonHoc("123", "abc", 1, 1000));
            //lk.Remove(lk.FindNode("234"));
            lk.Print();
            Console.WriteLine("\nHoc phi lon nhat: " + lk.FindMax());
            Console.WriteLine("Hoc phi nho nhat: " + lk.FindMin());
            Console.WriteLine("Tinh TBC hoc phi: " + lk.GetAverage());
            Console.WriteLine("So mon hoc co cung tinh chi: " + lk.CountNode(2));
            //lk.InterchangSort();
            //lk.BubbleSort();
            lk.SelectionSort();
            //lk.Print();
            for (Node i = lk.First; i != null; i = i.Next)
            {
                Console.WriteLine(i.MonHoc.toString());
            }
        }
    }
}
