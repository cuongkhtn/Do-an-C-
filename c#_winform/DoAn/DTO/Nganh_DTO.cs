using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Nganh_DTO
    {
        private int manganh;

        public int Manganh
        {
            get { return manganh; }
            set { manganh = value; }
        }
        private String tennganh;

        public String Tennganh
        {
            get { return tennganh; }
            set { tennganh = value; }
        }
        private int tongsinhvien;

        public int Tongsinhvien
        {
            get { return tongsinhvien; }
            set { tongsinhvien = value; }
        }
        private int soluongchuyende;

        public int Soluongchuyende
        {
            get { return soluongchuyende; }
            set { soluongchuyende = value; }
        }
    }
}
