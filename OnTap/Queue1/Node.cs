using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class Node
    {
        private MonHoc monhoc;
        private Node next;

        internal MonHoc Monhoc
        {
            get
            {
                return monhoc;
            }

            set
            {
                monhoc = value;
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

        public Node(MonHoc mh)
        {
            monhoc = mh;
            next = null;
        }
    }
}
