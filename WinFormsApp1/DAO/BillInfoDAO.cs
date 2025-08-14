using HappyCoffeeApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffeeApp.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance => instance ??= new BillInfoDAO();
        private BillInfoDAO() { }

        public void InsertBillInfo(int maHD, int maSP, int soLuong)
        {
            // Nếu món đã tồn tại trong hóa đơn thì cộng dồn số lượng
            object exist = DataProvider.Instance.ExecuteScalar(
                "SELECT SoLuong FROM ChiTietHoaDon WHERE MaHD=@p0 AND MaSP=@p1",
                new object[] { maHD, maSP });

            if (exist != null && exist != System.DBNull.Value)
            {
                int currentQty = System.Convert.ToInt32(exist);
                DataProvider.Instance.ExecuteNonQuery(
                    "UPDATE ChiTietHoaDon SET SoLuong=@p0 WHERE MaHD=@p1 AND MaSP=@p2",
                    new object[] { currentQty + soLuong, maHD, maSP });
            }
            else
            {
                decimal price = System.Convert.ToDecimal(DataProvider.Instance.ExecuteScalar(
                    "SELECT DonGia FROM SanPham WHERE MaSP=@p0", new object[] { maSP }));

                DataProvider.Instance.ExecuteNonQuery(
                    "INSERT INTO ChiTietHoaDon(SoLuong, DonGia, MaHD, MaSP) VALUES (@p0, @p1, @p2, @p3)",
                    new object[] { soLuong, price, maHD, maSP });
            }
        }

    }
}
