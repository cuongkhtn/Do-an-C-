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
    public class HocKy_DAO
    {
        public HocKy_DAO()
        { }
        public static List<string> loadNamHoc()
        {
            SqlConnection con;
            //String[] listNH=new string[50];
            List<string> listNH=new List<string>();
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            String sql = "select DISTINCT namhoc from hocky";
            //SqlDataReader reader = provider.GetReader(CommandType.Text,sql);
            DataTable dt = DataProviders.LayDataTable(sql, con);
            if (dt.Rows.Count == 0)
            {
                return null;       
            }
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listNH.Add(dt.Rows[i]["namhoc"].ToString());
                //
            }
            return listNH;
            provider.Disconnect();
        }
        public static int layMaHK(string namhoc,int hocky)
        {
          
            DataProviders provider = new DataProviders();
            provider.Connect();
            String sql = "select mahocky from hocky where namhoc='" + namhoc + "'and hocky=" + hocky + "";
            //SqlDataReader reader = provider.GetReader(CommandType.Text,sql);
            SqlDataReader reader = provider.GetReader(CommandType.Text, sql);
            if (reader.Read())
            {
                    int a = int.Parse(reader["mahocky"].ToString());
                    return a;
            }
            return -1;
        }
    }
}
