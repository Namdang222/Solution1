
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
        public List<Drink> GetDrinkByCategoryID(int id)
        {
            var list = new List<Drink>();
            string query = "SELECT MaSP, TenSP, DonGia, MaLoaiSanPham FROM SanPham WHERE MaLoaiSanPham = @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, [id]);

            foreach (DataRow r in data.Rows)
                list.Add(new Drink(r));

            return list;
        }

        public bool InsertDrink(string name, int categoryId, float price)
        {
            string query = "INSERT INTO Drink (Name, CategoryID, Price) VALUES (@name, @categoryId, @price)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, categoryId, price });
            return result > 0;
        }

        public bool DeleteDrink(int drinkId)
        {
            string query = "DELETE FROM Drink WHERE ID = @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { drinkId });
            return result > 0;
        }

        public bool UpdateDrink(int drinkId, string name, int categoryId, float price)
        {
            string query = "UPDATE Drink SET Name = @name, CategoryID = @categoryId, Price = @price WHERE ID = @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, categoryId, price, drinkId });
            return result > 0;
        }
    }
}
