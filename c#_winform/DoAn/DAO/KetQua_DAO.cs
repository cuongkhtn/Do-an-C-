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
    public class KetQua_DAO
    {
        public KetQua_DAO()
        { }
        public static List<KetQua_DTO> loadKetQua(int masinhvien,int machuyende,int mahocky)
        {
            SqlConnection con;
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            String sql = " select sv.hoten, cd.tenchuyende, kq.diem from sinhvien sv,ketqua kq,chuyende cd where sv.masv=" + masinhvien + "and cd.machuyende=" + machuyende + "and kq.mahocky=" + mahocky + "and kq.masv=" + masinhvien + "and kq.machuyende=" + machuyende + "";
            //SqlDataReader reader = provider.GetReader(CommandType.Text,sql);
            DataTable dt = DataProviders.LayDataTable(sql, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KetQua_DTO> listKQ = new List<KetQua_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KetQua_DTO kq = new KetQua_DTO();
                    kq.TenSinhVien = dt.Rows[i]["hoten"].ToString();
                    kq.Tenchuyende =dt.Rows[i]["tenchuyende"].ToString();
                    kq.Diem = int.Parse(dt.Rows[i]["diem"].ToString());

                listKQ.Add(kq);
            }
            return listKQ;
            provider.Disconnect();
        }
        //---------------------------------------------------------------------
        public static List<KetQua_DTO> loadKetQuaAll( int machuyende, int mahocky)
        {
            SqlConnection con;
            DataProviders provider = new DataProviders();
            con = provider.Connect();
            String sql = " select sv.hoten, cd.tenchuyende, kq.diem from sinhvien sv,ketqua kq,chuyende cd where cd.machuyende=" + machuyende + "and kq.mahocky=" + mahocky + "and kq.masv=sv.masv and kq.machuyende=" + machuyende + "";
            //SqlDataReader reader = provider.GetReader(CommandType.Text,sql);
            DataTable dt = DataProviders.LayDataTable(sql, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KetQua_DTO> listKQ = new List<KetQua_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KetQua_DTO kq = new KetQua_DTO();
                kq.TenSinhVien = dt.Rows[i]["hoten"].ToString();
                kq.Tenchuyende = dt.Rows[i]["tenchuyende"].ToString();
                kq.Diem = int.Parse(dt.Rows[i]["diem"].ToString());

                listKQ.Add(kq);
            }
            return listKQ;
            provider.Disconnect();
        }
    }
}
