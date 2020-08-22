using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class HangHoa
    {
        //Field
        private string maHH;
        private string tenHang;
        private int soLuong;
        private int donGia;
        //Properties
        public string MaHH
        {
            get
            {
                return maHH;
            }

            set
            {
                maHH = value;
            }
        }

        public string TenHang
        {
            get
            {
                return tenHang;
            }

            set
            {
                tenHang = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public int DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }
        //Methods
        public HangHoa() { }

        public HangHoa(string maHH, string tenHang, int soLuong, int donGia)
        {
            this.maHH = maHH;
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }
        public string toString()
        {
            string s = $"{MaHH}-{TenHang}-{SoLuong}-{DonGia}";
            return s;
        }
    }
}
