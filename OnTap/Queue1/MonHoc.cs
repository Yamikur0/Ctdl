using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class MonHoc
    {
        private string maMH;
        private string tenMH;
        private int soTC;
        private long hocPhi;

        public string MaMH
        {
            get
            {
                return maMH;
            }

            set
            {
                maMH = value;
            }
        }

        public string TenMH
        {
            get
            {
                return tenMH;
            }

            set
            {
                tenMH = value;
            }
        }

        public int SoTC
        {
            get
            {
                return soTC;
            }

            set
            {
                soTC = value;
            }
        }

        public long HocPhi
        {
            get
            {
                return hocPhi;
            }

            set
            {
                hocPhi = value;
            }
        }

        public MonHoc() { }

        public MonHoc(string maMH, string tenMH, int soTC, long hocPhi)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.soTC = soTC;
            this.hocPhi = hocPhi;
        }

        public string toString()
        {
            string s = $"\n Ma mon hoc: {this.MaMH}\n Ten mon hoc: {this.TenMH}\n So tin chi: {this.SoTC}\n Hoc phi: {this.HocPhi}";
            return s;
        }
    }
}
