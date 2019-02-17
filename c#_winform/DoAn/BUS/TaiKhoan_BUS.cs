using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Security.Cryptography;
namespace BUS
{
    public class TaiKhoan_BUS
    {
        public TaiKhoan_BUS()
        {
 
        }
        public static void insertTK(string taikhoan, string matkhau, string email, string chucvu)
        {
            TaiKhoan_DAO.insertTK(taikhoan, matkhau.GetMD5(), email, chucvu);
        }
        public static TaiKhoan_DTO dangnhap(String taikhoan,String matkhau)
        {
            return TaiKhoan_DAO.dangnhap(taikhoan,matkhau.GetMD5());
        }
     
         public static void resetPass(string taikhoan, string matkhau)
        {
            TaiKhoan_DAO.resetPass(taikhoan, matkhau.GetMD5());
        }
         public static string layEmail(string taikhoan)
         {
             return TaiKhoan_DAO.layEmail(taikhoan);
         }
    }

    public static class hl
    {
        public static string GetMD5(this string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }
            return str_md5;
        }
    }
}
