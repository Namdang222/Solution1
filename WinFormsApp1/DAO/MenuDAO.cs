using HappyCoffeeApp.DTO;
using System.Collections.Generic;
using System.Data;

namespace HappyCoffeeApp.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance => instance ??= new MenuDAO();
        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int maBan)
        {
            List<Menu> list = new List<Menu>();
            string sql = @"
SELECT 
    sp.TenSP AS FoodName,
    ct.SoLuong AS [Count],
    ct.DonGia AS Price,
    (ct.SoLuong * ct.DonGia) AS TotalPrice
FROM HoaDon hd
JOIN ChiTietHoaDon ct ON ct.MaHD = hd.MaHD
JOIN SanPham sp ON sp.MaSP = ct.MaSP
WHERE hd.MaBan = @p0 AND hd.TrangThai = N'Chưa thanh toán'
ORDER BY sp.TenSP";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, new object[] { maBan });
            foreach (DataRow row in data.Rows) list.Add(new Menu(row));
            return list;
        }
    }
}
