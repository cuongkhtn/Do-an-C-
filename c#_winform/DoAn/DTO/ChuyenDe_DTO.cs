using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuyenDe_DTO
    {
        
        private int machuyende;

        public int Machuyende
        {
            get { return machuyende; }
            set { machuyende = value; }
        }
        private String tenchuyende;

        public String Tenchuyende
        {
            get { return tenchuyende; }
            set { tenchuyende = value; }
        }
        private int soluongsinhvientoida;

        public int Soluongsinhvientoida
        {
            get { return soluongsinhvientoida; }
            set { soluongsinhvientoida = value; }
        }
        private DateTime deadline;

        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }
        private int sonhomtoida;

        public int Sonhomtoida
        {
            get { return sonhomtoida; }
            set { sonhomtoida = value; }
        }
        private int magv;

        public int Magv
        {
            get { return magv; }
            set { magv = value; }
        }
        public ChuyenDe_DTO()
        {

        }
        private String tinhtrang;

        public String Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
    }
}
