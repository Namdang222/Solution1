using HappyCoffeeApp.DTO;
using System.Data;

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
        public List<BillInfo> GetBillInfoList(DateTime fromDate, DateTime toDate)
        {
            List<BillInfo> list = new List<BillInfo>();
            string query = @"
        SELECT ct.MaCTHD, ct.MaHD, ct.MaSP, ct.SoLuong, ct.DonGia, 
               sp.TenSanPham, hd.NgayBan, nv.TenNhanVien
        FROM ChiTietHoaDon ct
        JOIN HoaDon hd ON ct.MaHD = hd.ID
        JOIN SanPham sp ON ct.MaSP = sp.ID
        JOIN NhanVien nv ON hd.NhanVienID = nv.ID
        WHERE hd.NgayBan BETWEEN @from AND @to";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { fromDate, toDate });
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new BillInfo(row));
            }
            return list;

        }

    }
}
