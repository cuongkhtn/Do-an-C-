using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace DAO
{
    class DataProviders
    {
        static String ConnectionString = @"Server=DESKTOP-M0S3SL1\SQLEXPRESS; Database=QLCD;Trusted_Connection=True;";
        SqlConnection Connection { get; set; }
        public SqlConnection Connect()
        {
            try
            {
                if (Connection == null)
                {
                    Connection = new SqlConnection(ConnectionString);
                }
                if (Connection.State != ConnectionState.Closed)
                {
                    Connection.Close();
                }
                Connection.Open();
                return Connection;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void Disconnect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
        public SqlDataReader GetReader(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;
                return command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public static DataTable LayDataTable(String strSql,SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(strSql,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ExecuteNonQuery(CommandType cmdType, String strSql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}