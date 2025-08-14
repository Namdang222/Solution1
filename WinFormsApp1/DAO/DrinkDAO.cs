using System.Collections.Generic;
using System.Data;
using HappyCoffeeApp.DTO;

namespace HappyCoffeeApp.DAO
{
    public class DrinkDAO
    {
        private static DrinkDAO instance;
        public static DrinkDAO Instance => instance ??= new DrinkDAO();
        private DrinkDAO() { }

        public List<Drink> GetDrinkByCategoryID(int categoryId)
        {
            List<Drink> list = new List<Drink>();
            string query = "SELECT MaSP, TenSP, DonGia, MaLoaiSanPham FROM SanPham WHERE MaLoaiSanPham = @maLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { categoryId });

            foreach (DataRow row in data.Rows)
            {
                list.Add(new Drink(row));
            }
            return list;
        }

        public List<Drink> GetListDrink()
        {
            var list = new List<Drink>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaSP, TenSP, DonGia, MaLoaiSanPham FROM SanPham");
            foreach (DataRow r in data.Rows) list.Add(new Drink(r));
            return list;
        }
    }
}
