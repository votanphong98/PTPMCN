using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangSach.DAO
{
    public class ThongKeDAO
    {
        string connectionString =
              ConfigurationManager.ConnectionStrings["QLSach"].ConnectionString;
        public DataTable ThongKeTrongNgay(string ngayban)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"SELECT * FROM DoanhThu WHERE NgayBan = @ngayban";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@ngayban", ngayban);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            return table;
        }
        public int GetTongTienTrongNgay(string ngayban)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"SELECT sum(TongTien) FROM DoanhThu WHERE NgayBan = @ngayban";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@ngayban", ngayban);
            connection.Open();
            int sum = (int)cmd.ExecuteScalar();
            return sum;
        }
        public DataTable ThongKeTuyChon(string ngaybatdau,string ngayketthuc)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"SELECT * FROM DoanhThu WHERE NgayBan BETWEEN @ngaybatdau AND @ngayketthuc";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@ngaybatdau", ngaybatdau);
            cmd.Parameters.AddWithValue("@ngayketthuc", ngayketthuc);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            return table;
        }
        public int GetTongTienTuyChon(string ngaybatdau, string ngayketthuc)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"SELECT sum(TongTien) FROM DoanhThu WHERE NgayBan BETWEEN @ngaybatdau AND @ngayketthuc";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@ngaybatdau", ngaybatdau);
            cmd.Parameters.AddWithValue("@ngayketthuc", ngayketthuc);
            connection.Open();
            int sum = (int)cmd.ExecuteScalar();
            return sum;
        }
    }
}