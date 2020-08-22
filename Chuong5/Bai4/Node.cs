using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Node
    {
        //Field
        private HangHoa data;
        private Node next;
        //Properties
        internal HangHoa HangHoa
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
        //Methods
        public Node(HangHoa hh)
        {
            data = hh;
            next = null;
        }

        public Node(string maHH, string tenHang, int soLuong, int donGia)
        {
            HangHoa hh = new HangHoa(maHH, tenHang, soLuong, donGia);
            data = hh;
            next = null;
        }

        public string toString()
        {
            string s = data.toString();
            return s;
        }
    }
}
