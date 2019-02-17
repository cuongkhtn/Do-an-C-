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
    public class ChuyenDe_DAO
    {
        public ChuyenDe_DAO()
        { }
        public static void updateCDM(int machuyende)
        {
            SqlConnection con;
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            String sql = "update chuyende set tinhtrang=N'MỞ' where machuyende=@machuyende";
            provider.ExecuteNonQuery(CommandType.Text, sql,
                new SqlParameter { ParameterName = "@machuyende", Value = machuyende });
            provider.Disconnect();
        }
        public static void updateCDĐ(int machuyende)
        {
            SqlConnection con;
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            String sql = "update chuyende set tinhtrang=N'ĐÓNG' where machuyende=@machuyende";
            provider.ExecuteNonQuery(CommandType.Text, sql,
                new SqlParameter { ParameterName = "@machuyende", Value = machuyende });
            provider.Disconnect();
        }
        public static void updateCDUD(int machuyende,string tenchuyende,int sosinhvien,DateTime deadline)
        {
            SqlConnection con;
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            String sql = "update chuyende set  tenchuyende=@tenchuyende,soluongsinhvientoida=@sosinhvien ,deadline = @deadline where machuyende=@machuyende";
            provider.ExecuteNonQuery(CommandType.Text, sql,
                new SqlParameter { ParameterName = "@machuyende", Value = machuyende },
                new SqlParameter { ParameterName = "@tenchuyende", Value = tenchuyende },
                new SqlParameter { ParameterName = "@sosinhvien", Value = sosinhvien },
                new SqlParameter { ParameterName = "@deadline", Value = deadline });
            provider.Disconnect();
        }
        public static void xoaCD(int machuyende)
        {
            SqlConnection con;
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            String sql = "delete from chuyende where machuyende=@machuyende";
            provider.ExecuteNonQuery(CommandType.Text, sql,
                new SqlParameter { ParameterName = "@machuyende", Value = machuyende });          
            provider.Disconnect();
        }
        public static int laymacd(string tencd)
        { 
            DataProviders provider = new DataProviders();
            provider.Connect();
            String sql = "select machuyende from chuyende where tenchuyende='"+tencd+"'";
            //SqlDataReader reader = provider.GetReader(CommandType.Text,sql);
            SqlDataReader reader = provider.GetReader(CommandType.Text, sql);
            if (reader.Read())
            {
                    int a = int.Parse(reader["machuyende"].ToString());
                    return a;
            }
            return -1;
        }
            
        public static void insertCD(string tenchuyende, int sosinhvien, DateTime handangky)
        {
            SqlConnection con;
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            String sql = "insert into chuyende(tenchuyende,soluongsinhvientoida,deadline) values(@tenchuyende,@sosinhvien,@handangky)";
            provider.ExecuteNonQuery(CommandType.Text, sql, 
                new SqlParameter { ParameterName = "@tenchuyende", Value = tenchuyende },
                new SqlParameter { ParameterName = "@sosinhvien", Value = sosinhvien },
                new SqlParameter { ParameterName = "@handangky", Value = handangky });
            provider.Disconnect();
        }
        public static void phutrachCD(int machuyende, int magv)
        {
            SqlConnection con;
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            String sql = "update chuyende set magv=@magv where machuyende=@machuyende";
            provider.ExecuteNonQuery(CommandType.Text, sql,
                new SqlParameter { ParameterName = "@magv", Value = magv },
                new SqlParameter { ParameterName = "@machuyende", Value = machuyende });
            provider.Disconnect();
        }
        public static void updateCD(int machuyende, int soluongsinhvientoida, int sonhomtoida, DateTime deadline)
        {
            SqlConnection con;
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            String sql = "update chuyende set soluongsinhvientoida=@soluongsinhvientoida,deadline=@deadline,sonhomtoida=@sonhomtoida where machuyende=@machuyende";
            provider.ExecuteNonQuery(CommandType.Text, sql,
                new SqlParameter { ParameterName = "@soluongsinhvientoida", Value = soluongsinhvientoida },
                new SqlParameter { ParameterName = "@deadline", Value = deadline },
                new SqlParameter { ParameterName = "@sonhomtoida", Value = sonhomtoida },
                new SqlParameter { ParameterName = "@machuyende", Value = machuyende });
            provider.Disconnect();
        }
        public static int kiemtraMaGV(int machuyende)
        {
            int a;
            DataProviders provider = new DataProviders();
            provider.Connect();
            String sql = "select * from chuyende where machuyende='" + machuyende + "'";
            //SqlDataReader reader = provider.GetReader(CommandType.Text,sql);
            SqlDataReader reader = provider.GetReader(CommandType.Text, sql);
            if (reader.Read())
            {
                if (reader["magv"].ToString()!="")
                {
                    a = int.Parse(reader["magv"].ToString());
                    return a;
                }
                    return -1;
                
               
            }
                return -1;

            provider.Disconnect();
        }
        public static int kiemtraHK()
        {
            int a=-1, b = 1; 
            DataProviders provider = new DataProviders();
            provider.Connect();
            String sql = "select * from hocky";
            //SqlDataReader reader = provider.GetReader(CommandType.Text,sql);
            SqlDataReader reader = provider.GetReader(CommandType.Text, sql);
            while (reader.Read())
            {

                if (int.Parse(reader["namhoc"].ToString().Substring(5, 4)) > b)
                {
                    b = int.Parse(reader["namhoc"].ToString().Substring(5, 4));
                    a = int.Parse(reader["mahocky"].ToString());
                    continue;
                }
                if (int.Parse(reader["namhoc"].ToString().Substring(5, 4)) == b && int.Parse(reader["hocky"].ToString()) == 2)
                {
                    //b = int.Parse(reader["namhoc"].ToString().Substring(5, 4));
                    a = int.Parse(reader["mahocky"].ToString());
                }           
            }
             
            return a;

            provider.Disconnect();
        }
        public static List<ChuyenDe_DTO> loadChuyenDe()
        {
            SqlConnection con;
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            String sql = "select * from chuyende";
            //SqlDataReader reader = provider.GetReader(CommandType.Text,sql);
            DataTable dt = DataProviders.LayDataTable(sql, con);
           if(dt.Rows.Count==0)
           {
               return null;
           }
                 List<ChuyenDe_DTO> listCD=new List<ChuyenDe_DTO>();
                 for (int i = 0; i < dt.Rows.Count;i++ )
                 {
                     ChuyenDe_DTO cd = new ChuyenDe_DTO();
                     if (dt.Rows[i]["machuyende"].ToString()!="")
                     cd.Machuyende = int.Parse(dt.Rows[i]["machuyende"].ToString());
                     cd.Tenchuyende = dt.Rows[i]["tenchuyende"].ToString();
                     if (dt.Rows[i]["soluongsinhvientoida"].ToString() != "")
                     cd.Soluongsinhvientoida = int.Parse(dt.Rows[i]["soluongsinhvientoida"].ToString());
                     if (dt.Rows[i]["deadline"].ToString() != "")
                     cd.Deadline = DateTime.Parse(dt.Rows[i]["deadline"].ToString());
                     if (dt.Rows[i]["sonhomtoida"].ToString() != "")
                     cd.Sonhomtoida = int.Parse(dt.Rows[i]["sonhomtoida"].ToString());
                     cd.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                     listCD.Add(cd);
                 }
                return listCD;
           provider.Disconnect();
        }
        public static List<ChuyenDe_DTO> loadChuyenDe1(int mahk)
        {
            SqlConnection con;
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            
            String sql = "select * from chuyende cd,hocky hk,chuyende_hocky hk_cd where hk.mahocky="+mahk+" and hk_cd.mahocky=hk.mahocky and cd.machuyende=hk_cd.machuyende and cd.tinhtrang=N'MỞ'";
            //SqlDataReader reader = provider.GetReader(CommandType.Text,sql);
            DataTable dt = DataProviders.LayDataTable(sql, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChuyenDe_DTO> listCD = new List<ChuyenDe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChuyenDe_DTO cd = new ChuyenDe_DTO();
                if (dt.Rows[i]["machuyende"].ToString() != "")
                    cd.Machuyende = int.Parse(dt.Rows[i]["machuyende"].ToString());
                cd.Tenchuyende = dt.Rows[i]["tenchuyende"].ToString();
                if (dt.Rows[i]["soluongsinhvientoida"].ToString() != "")
                    cd.Soluongsinhvientoida = int.Parse(dt.Rows[i]["soluongsinhvientoida"].ToString());
                if (dt.Rows[i]["deadline"].ToString() != "")
                    cd.Deadline = DateTime.Parse(dt.Rows[i]["deadline"].ToString());
                if (dt.Rows[i]["sonhomtoida"].ToString() != "")
                    cd.Sonhomtoida = int.Parse(dt.Rows[i]["sonhomtoida"].ToString());
                if (dt.Rows[i]["magv"].ToString() != "")
                    cd.Magv = int.Parse(dt.Rows[i]["magv"].ToString());
                
                listCD.Add(cd);
            }
            return listCD;
            provider.Disconnect();
        }
        public static List<ChuyenDe_DTO> loadChuyenDeXem(int hocky,string namhoc)
        {
            SqlConnection con;
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            String sql = "select * from chuyende cd,hocky hk,chuyende_hocky hk_cd where hk.namhoc='" + namhoc + "'and hk.hocky='"+hocky+"' and hk_cd.mahocky=hk.mahocky and cd.machuyende=hk_cd.machuyende and cd.tinhtrang=N'MỞ'";
            //SqlDataReader reader = provider.GetReader(CommandType.Text,sql);
            DataTable dt = DataProviders.LayDataTable(sql, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChuyenDe_DTO> listCD = new List<ChuyenDe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChuyenDe_DTO cd = new ChuyenDe_DTO();
                if (dt.Rows[i]["machuyende"].ToString() != "")
                    cd.Machuyende = int.Parse(dt.Rows[i]["machuyende"].ToString());
                cd.Tenchuyende = dt.Rows[i]["tenchuyende"].ToString();
                if (dt.Rows[i]["soluongsinhvientoida"].ToString() != "")
                    cd.Soluongsinhvientoida = int.Parse(dt.Rows[i]["soluongsinhvientoida"].ToString());
                if (dt.Rows[i]["deadline"].ToString() != "")
                    cd.Deadline = DateTime.Parse(dt.Rows[i]["deadline"].ToString());
                if (dt.Rows[i]["sonhomtoida"].ToString() != "")
                    cd.Sonhomtoida = int.Parse(dt.Rows[i]["sonhomtoida"].ToString());
                if (dt.Rows[i]["magv"].ToString() != "")
                    cd.Magv = int.Parse(dt.Rows[i]["magv"].ToString());

                listCD.Add(cd);
            }
            return listCD;
            provider.Disconnect();
        }
        public static List<ChuyenDe_DTO> loadChuyenDe2(int magv,string namhoc,int hocky)
        {
            SqlConnection con;
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            String sql = "select * from chuyende cd,hocky hk,chuyende_hocky hk_cd where hk.namhoc='" + namhoc + "'and hk.hocky='"+hocky+"' and hk_cd.mahocky=hk.mahocky and cd.machuyende=hk_cd.machuyende and cd.tinhtrang=N'MỞ' and cd.magv='" + magv + "'";
            //SqlDataReader reader = provider.GetReader(CommandType.Text,sql);
            DataTable dt = DataProviders.LayDataTable(sql, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChuyenDe_DTO> listCD = new List<ChuyenDe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChuyenDe_DTO cd = new ChuyenDe_DTO();
                if (dt.Rows[i]["machuyende"].ToString() != "")
                    cd.Machuyende = int.Parse(dt.Rows[i]["machuyende"].ToString());
                cd.Tenchuyende = dt.Rows[i]["tenchuyende"].ToString();
                if (dt.Rows[i]["soluongsinhvientoida"].ToString() != "")
                    cd.Soluongsinhvientoida = int.Parse(dt.Rows[i]["soluongsinhvientoida"].ToString());
                if (dt.Rows[i]["deadline"].ToString() != "")
                    cd.Deadline = DateTime.Parse(dt.Rows[i]["deadline"].ToString());
                if (dt.Rows[i]["sonhomtoida"].ToString() != "")
                    cd.Sonhomtoida = int.Parse(dt.Rows[i]["sonhomtoida"].ToString());

                listCD.Add(cd);
            }
            return listCD;
            provider.Disconnect();
        }
        public static int layMaGV(string taikhoan)
        {
            int a;
            DataProviders provider = new DataProviders();
            provider.Connect();
            String sql = "select * from giaovien where taikhoan='"+taikhoan+"'";
            //SqlDataReader reader = provider.GetReader(CommandType.Text,sql);
            SqlDataReader reader = provider.GetReader(CommandType.Text, sql);
            if (reader.Read())
                 {
                      a = int.Parse(reader["magv"].ToString());
                      return a;
                 }
            else
            {
                return -1;
            }
            
            provider.Disconnect();
        }
    }
}
