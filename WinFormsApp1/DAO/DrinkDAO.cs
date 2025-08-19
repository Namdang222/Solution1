
using HappyCoffeeApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace HappyCoffeeApp.DAO
{
    public class DrinkDAO
    {
        private static DrinkDAO instance;
        public static DrinkDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DrinkDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }
        private DrinkDAO()
        {

            //string query = "SELECT * FROM SanPham where MaSP = " + id;
            //DataTable data = DataProvider.Instance.ExecuteQuery(query);
            //foreach (DataRow item in data.Rows)
            //{   int maSP = (int)item["MaSP"];
            //    string tenSP = item["TenSP"].ToString();
            //    int maLoaiSanPham = (int)item["MaLoaiSanPham"];
            //    float donGia = Convert.ToSingle(item["DonGia"]);
            //    Drink drink = new Drink(maSP, tenSP, maLoaiSanPham, donGia);
            //    // Add the drink to a collection or process it as needed
            //}
        }
        public List<Drink> GetListDrinkByCategoryID(int id)
        {
            var list = new List<Drink>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaSP, TenSP, DonGia, MaLoaiSanPham FROM SanPham");
            foreach (DataRow r in data.Rows) list.Add(new Drink(r));
            return list;
        }
    }
}
