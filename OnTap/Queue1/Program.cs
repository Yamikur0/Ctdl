using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue nq = new Queue();
            nq.EnQueue(new MonHoc("123", "abc", 1, 1000));
            nq.EnQueue("234", "bcd", 2, 2000);
            //nq.DeQueue();
            
            nq.Display();
            Console.WriteLine(nq.Peek());
            Console.WriteLine(nq.FindNode("123").Monhoc.toString());
            Console.WriteLine(nq.FindPreviousNode(nq.FindNode("123")).Monhoc.toString());
        }
    }
}
