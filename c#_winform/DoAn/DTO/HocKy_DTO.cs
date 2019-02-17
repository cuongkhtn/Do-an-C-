using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HocKy_DTO
    {
        private int mahocky;

        public int Mahocky
        {
            get { return mahocky; }
            set { mahocky = value; }
        }
        private int hocky;

        public int Hocky
        {
            get { return hocky; }
            set { hocky = value; }
        }
        private string namhoc;

        public string Namhoc
        {
            get { return namhoc; }
            set { namhoc = value; }
        }
    }
}
