using HappyCoffeeApp.DTO;
using Microsoft.Azure.Amqp.Framing;
using System.Collections.Generic;
using System.Data;

namespace HappyCoffeeApp.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance => instance ??= new TableDAO();
        private TableDAO() { }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        public DataTable GetTableList()
            => DataProvider.Instance.ExecuteQuery("SELECT MaBan, ViTri, TrangThai FROM Ban");

        public List<Table> LoadTableList()
        {
            var list = new List<Table>();
            DataTable data = GetTableList();
            foreach (DataRow r in data.Rows) list.Add(new Table(r));
            return list;
        }



        public bool InsertTable(string viTri, string trangThai = "Trống")
        {
            string sql = "INSERT INTO Ban (ViTri, TrangThai) VALUES (@p0, @p1)";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { viTri, trangThai }) > 0;
        }

        public bool UpdateTable(int maBan, string viTri, string trangThai)
        {
            string sql = "UPDATE Ban SET ViTri=@p0, TrangThai=@p1 WHERE MaBan=@p2";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { viTri, trangThai, maBan }) > 0;
        }

        public bool DeleteTable(int maBan)
        {
            string sql = "DELETE FROM Ban WHERE MaBan=@p0";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { maBan }) > 0;
        }

        //DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
        //    foreach (DataRow item in Data.Rows)
        //    {
        //        Table table = new Table(item);
        //        tableList.Add(Table)
        //    }
        //    DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TableFood");
        //    return tableList;
    }
}