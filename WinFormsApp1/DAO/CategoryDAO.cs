using HappyCoffeeApp.DTO;
using System.Collections.Generic;
using System.Data;

namespace HappyCoffeeApp.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance => instance ??= new CategoryDAO();
        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string sql = "SELECT MaLoaiSP, TenLoai FROM LoaiSanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow row in data.Rows) list.Add(new Category(row));
            return list;
        }
    }
}
