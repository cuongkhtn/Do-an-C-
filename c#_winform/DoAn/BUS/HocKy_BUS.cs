using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class HocKy_BUS
    {
        public HocKy_BUS()
        { }
        public static List<string> loadNamHoc()
        {
            return HocKy_DAO.loadNamHoc();
        }
        public static int layMaHK(string namhoc, int hocky)
        {
            return HocKy_DAO.layMaHK(namhoc, hocky);
        }
    }
}
