using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffeeApp.DTO
{
    public class Menu
    {
        public Menu(string drinkName, int count, float price, float totalPrice = 0)
        {
            this.DrinkName = drinkName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.DrinkName = row["FoodName"].ToString(); // Đổi từ "Name" sang "FoodName"
            this.Count = Convert.ToInt32(row["Count"]);
            this.Price = Convert.ToSingle(row["Price"]);
            this.TotalPrice = Convert.ToSingle(row["TotalPrice"]);
        }

        public string DrinkName { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
        public float TotalPrice { get; set; }


    }
}
