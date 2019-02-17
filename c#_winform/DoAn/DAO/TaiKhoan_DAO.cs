using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class TaiKhoan_DAO
    {
         public TaiKhoan_DAO()
         {

         }
         public static void insertTK(string taikhoan, string matkhau, string email, string chucvu)
         {
             SqlConnection con;
             DataProviders provider = new DataProviders();
             con = provider.Connect();
             String sql = "insert into taikhoan values(@taikhoan,@matkhau,@email,@chucvu)";
             provider.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "@taikhoan", Value = taikhoan },
                 new SqlParameter { ParameterName = "@matkhau", Value = matkhau},
                 new SqlParameter { ParameterName = "@email", Value = email},
                 new SqlParameter { ParameterName = "@chucvu", Value = chucvu});
             provider.Disconnect();
         }
         public static void resetPass(string taikhoan, string matkhau)
         {
             SqlConnection con;
             DataProviders provider = new DataProviders();
             con = provider.Connect();
             String sql = "update taikhoan set matkhau=@matkhau where taikhoan=@taikhoan";
             provider.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "@taikhoan", Value = taikhoan },
                 new SqlParameter { ParameterName = "@matkhau", Value = matkhau });
             provider.Disconnect();
         }
         public static string layEmail(string taikhoan)
         {
             SqlConnection con;
             DataProviders provider = new DataProviders();
             con = provider.Connect();
             String sql = "select * from taikhoan where taikhoan='"+taikhoan+"'";
             SqlDataReader reader = provider.GetReader(CommandType.Text, sql);
             if (reader.Read())
             {
                 string email;
                 email = reader[2].ToString();
                 provider.Disconnect();
                 return email;
             }
             else
             {
                 provider.Disconnect();
                 return null;
             }
         }
        public static TaiKhoan_DTO dangnhap(String taikhoan,String matkhau)
         {
             SqlConnection con;
             DataProviders provider = new DataProviders();
             con = provider.Connect();
             String sql = "select * from taikhoan where taikhoan='"+taikhoan+"' and matkhau='"+matkhau+"'";
             SqlDataReader reader = provider.GetReader(CommandType.Text, sql);
            if(reader.Read())
            {
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.Chucvu = reader[3].ToString();
                provider.Disconnect();
                return tk;
            }
            else
            { provider.Disconnect();
            return null;
            }
            
         }
        
    }
}
