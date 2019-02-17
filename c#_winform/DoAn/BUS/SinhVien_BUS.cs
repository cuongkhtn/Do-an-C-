using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class SinhVien_BUS
    {
        public static int layMaSV(string hoten)
        {
            return SinhVien_DAO.layMaSV(hoten);
        }
    }
}
