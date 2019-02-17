using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class KetQua_BUS
    {
        public KetQua_BUS()
        { }
         public static List<KetQua_DTO> loadKetQua(int masinhvien,int machuyende,int mahocky)
        {
            return KetQua_DAO.loadKetQua(masinhvien, machuyende, mahocky);
        }
         public static List<KetQua_DTO> loadKetQuaAll( int machuyende, int mahocky)
         {
             return KetQua_DAO.loadKetQuaAll(machuyende, mahocky);
         }
    }
}
