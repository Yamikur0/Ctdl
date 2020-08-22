using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    class Node
    {
        private MonHoc monHoc;
        private Node next;

        internal MonHoc MonHoc
        {
            get
            {
                return monHoc;
            }

            set
            {
                monHoc = value;
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

        public Node(MonHoc monHoc)
        {
            this.monHoc = monHoc;
            this.next = null;
        }
    }
}
