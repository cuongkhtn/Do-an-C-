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
    public class SinhVien_DAO
    {
        public static int layMaSV(string hoten)
        {

            DataProviders provider = new DataProviders();
            provider.Connect();
            String sql = "select masv from sinhvien where hoten='" + hoten + "'";
            //SqlDataReader reader = provider.GetReader(CommandType.Text,sql);
            SqlDataReader reader = provider.GetReader(CommandType.Text, sql);
            if (reader.Read())
            {
                int a = int.Parse(reader["masv"].ToString());
                return a;
            }
            return -1;
        }
    }
}
