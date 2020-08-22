using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            //b: Tao Queue
            Queue q = new Queue();
            //q.EnQueue("1ab", "abc", 2, 23000);

            //e: Them mat hang vao kho
            q = NhapDanhSach();
            q.EnQueue("1cd", "efg", 3, 24000);
            //q.EnQueue("1ef", "hik", 4, 25000);

            //c: Xem tat ca hang hoa trong kho
            Console.WriteLine("\nDanh sach cac mat hang");
            q.Display();

            //d: Xem mat hang sap duoc xuat kho
            Console.WriteLine("\nMat hang dau kho:\n{0}", q.Peek());

            //f: Xuat mat hang ra khoi kho
            Console.WriteLine("\nDanh sach sau khi xuat mat hang dau kho:");
            q.DeQueue();
            q.Display();
        }

        public static Queue NhapDanhSach()
        {
            Queue ql = new Queue();
            //So luong danh sach can nhap
            int iN = 0;
            Console.Write("Nhap so luong danh sach: ");
            int.TryParse(Console.ReadLine(), out iN);
            //Nhap
            string maHH = "";
            string tenHang = "";
            int soLuong = 0;
            int donGia = 0;
            for (int i = 0; i < iN; i++)
            {
                Console.WriteLine("\n=====Mat hang thu {0}=====", i);
                Console.Write("Nhap ma hang hoa: ");
                maHH = Console.ReadLine();
                Console.Write("Nhap ten hang hoa: ");
                tenHang = Console.ReadLine();
                Console.Write("Nhap so luong: ");
                int.TryParse(Console.ReadLine(), out soLuong);
                Console.Write("Nhap don gia: ");
                int.TryParse(Console.ReadLine(), out donGia);

                ql.EnQueue(maHH, tenHang, soLuong, donGia);
            }
            return ql;
        }
    }
}
