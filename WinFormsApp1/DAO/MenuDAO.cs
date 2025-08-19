using HappyCoffeeApp.DTO;
using System.Collections.Generic;
using System.Data;

namespace HappyCoffeeApp.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance => instance ??= new MenuDAO();

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
        //public List<Menu> GetListMenuByTable(int id)
        //{
        //    List<Menu> listMenu = new List<Menu>();
        //    string query = "SELECT f.TenSP AS FoodName, bi.SoLuong AS Count, f.DonGia AS Price, f.DonGia * bi.SoLuong AS TotalPrice " +
        //                   "FROM ChiTietHoaDon AS bi " +
        //                   "JOIN HoaDon AS b ON bi.MaHD = b.MaHD " +
        //                   "JOIN SanPham AS f ON bi.MaSP = f.MaSP " +
        //                   "WHERE b.MaBan = " + id + " AND b.TongTien = 0";

        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);

        //    foreach (DataRow item in data.Rows)
        //    {
        //        Menu menu = new Menu(item);
        //        listMenu.Add(menu);
        //    }
        //    return listMenu;


        //}
    }
}
