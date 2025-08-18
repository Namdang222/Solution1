using System;
using System.Data;

namespace HappyCoffeeApp.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance => instance ??= new BillDAO();
        private BillDAO() { }

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDon WHERE MaBan = " + id + " AND TongTien = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.MaHD;
            }
            return -1;
        }
        public void CheckOut(int id)
        {
            string query = "UPDATE HoaDon SET status = 1 WHERE MaHD = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        // Lấy bill chưa thanh toán hoặc tạo mới nếu chưa có
        public int GetOrCreateOpenBillByTable(int maBan)
        {
            object id = DataProvider.Instance.ExecuteScalar(
                "SELECT MaHD FROM HoaDon WHERE MaBan=@p0 AND TrangThai=N'Chưa thanh toán'",
                new object[] { maBan });

            // Kiểm tra DBNull trước khi convert
            if (id != null && id != DBNull.Value)
                return Convert.ToInt32(id);

            // Nếu chưa có hóa đơn, tạo mới
            DataProvider.Instance.ExecuteNonQuery(
                "INSERT INTO HoaDon(NgayLap, MaBan, TrangThai, TongTien) VALUES (GETDATE(), @p0, N'Chưa thanh toán', 0)",
                new object[] { maBan });

            // Lấy ID vừa insert bằng SCOPE_IDENTITY()
            object newId = DataProvider.Instance.ExecuteScalar("SELECT SCOPE_IDENTITY()");
            return Convert.ToInt32(newId);
        }



        // Thanh toán bill
        public void Checkout(int maHD, decimal totalPrice)
        {
            DataProvider.Instance.ExecuteNonQuery(
                "UPDATE HoaDon SET TrangThai=N'Đã thanh toán', TongTien=@p0 WHERE MaHD=@p1",
                new object[] { totalPrice, maHD });
        }
    }
}
