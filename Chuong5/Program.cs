using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            st.Push(10);
            st.Push(20);
            st.Push(30);

            Console.WriteLine("Stack hien tai");
            st.Display();


        }
    }
}
