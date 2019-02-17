using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class GiaoVien_DTO
    {
        private int magv;

        public int Magv
        {
            get { return magv; }
            set { magv = value; }
        }
        private String tengv;

        public String Tengv
        {
            get { return tengv; }
            set { tengv = value; }
        }
        private String taikhoan;

        public String Taikhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }

    }
}
