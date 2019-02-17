using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ChuyenDe_BUS
    {
        public ChuyenDe_BUS()
        { }
         public static int laymacd(string tencd)
        {
            return ChuyenDe_DAO.laymacd(tencd);
        }
        public static List<ChuyenDe_DTO> loadChuyenDe()
        {
            return ChuyenDe_DAO.loadChuyenDe();
        }
        public static int layhk()
        {
            return ChuyenDe_DAO.kiemtraHK();
        }
        public static List<ChuyenDe_DTO> loadChuyenDe1()
        {
            return ChuyenDe_DAO.loadChuyenDe1(layhk());
        }
        public static List<ChuyenDe_DTO> loadChuyenDeXem(int hocky, string namhoc)
        {
            return ChuyenDe_DAO.loadChuyenDeXem(hocky,namhoc);
        }
        public static List<ChuyenDe_DTO> loadChuyenDe2(int magv, string namhoc, int hocky)
        {
            return ChuyenDe_DAO.loadChuyenDe2(magv,namhoc,hocky);
        }
        public static void insertCD(string tenchuyende, int sosinhvien, DateTime handangky)
        {
            ChuyenDe_DAO.insertCD(tenchuyende, sosinhvien, handangky);
        }
        public static void phutrachCD(int machuyende, int magv)
        {
            ChuyenDe_DAO.phutrachCD(machuyende, magv);
        }
        public static void updateCD(int machuyende, int soluongsinhvientoida, int sonhomtoida, DateTime deadline)
        {
            ChuyenDe_DAO.updateCD(machuyende, soluongsinhvientoida, sonhomtoida, deadline);
        }
         public static int layMaGV(string taikhoan)
        {
            return ChuyenDe_DAO.layMaGV(taikhoan);
        }
         public static int kiemtraMaGV(int machuyende)
         {
             return ChuyenDe_DAO.kiemtraMaGV(machuyende);
         }
         public static void updateCDM(int machuyende)
         {
             ChuyenDe_DAO.updateCDM(machuyende);
         }
         public static void updateCDĐ(int machuyende)
         {
             ChuyenDe_DAO.updateCDĐ(machuyende);
         }
         public static void updateCDUD(int machuyende,string tenchuyende,int sosinhvien,DateTime deadline)
         {
             ChuyenDe_DAO.updateCDUD(machuyende,tenchuyende,sosinhvien,deadline);
         }
         public static void xoaCD(int machuyende)
         {
             ChuyenDe_DAO.xoaCD(machuyende);
         }
    }
}
