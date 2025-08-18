
using HappyCoffeeApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using HappyCoffeeApp.DTO;

namespace HappyCoffeeApp.DAO
{
    public class DrinkDAO
    {
        private static DrinkDAO instance;
        private DrinkDAO() { }
        {

            string query = "SELECT * FROM SanPham where MaSP = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
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
