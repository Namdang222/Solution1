
using HappyCoffeeApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffeeApp.DAO
{
    public class DrinkDAO
    {
        private static DrinkDAO instance;
        public static DrinkDAO Instance
        {
            get { if (instance == null)instance = new DrinkDAO(); return DrinkDAO.instance; }
            private set { DrinkDAO.instance = value; }
        }
        private DrinkDAO() { }
        public List<Drink> GetFoodByCategoryID(int id)
        {
            List<Drink> list = new List<Drink> ();

            string query = "SELECT * FROM SanPham where idCategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Drink food = new Drink(item);
                list.Add(food);
            }

            return list;
        }
    }
}
