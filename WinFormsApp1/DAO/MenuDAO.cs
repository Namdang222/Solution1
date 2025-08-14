using HappyCoffeeApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffeeApp.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT f.TenSP AS FoodName, bi.SoLuong AS Count, f.DonGia AS Price, f.DonGia * bi.SoLuong AS TotalPrice " +
                           "FROM ChiTietHoaDon AS bi " +
                           "JOIN HoaDon AS b ON bi.MaHD = b.MaHD " +
                           "JOIN SanPham AS f ON bi.MaSP = f.MaSP " +
                           "WHERE b.MaBan = " + id + " AND b.TongTien = 0";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;

        }
    }
}
