using System.Data;

namespace HappyCoffeeApp.DTO
{
    public class Menu
    {

        public string FoodName { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

        public Menu(string foodName, int count, decimal price, decimal totalPrice)
        {
            FoodName = foodName;
            Count = count;
            Price = price;
            TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            FoodName = row["FoodName"].ToString();
            Count = (int)row["Count"];
            Price = (decimal)row["Price"];
            TotalPrice = (decimal)row["TotalPrice"];
        }

        //public Menu(string drinkName, int count, float price, float totalPrice = 0)
        //{
        //    this.DrinkName = drinkName;
        //    this.Count = count;
        //    this.Price = price;
        //    this.TotalPrice = totalPrice;
        //}

        //public Menu(DataRow row)
        //{
        //    this.DrinkName = row["FoodName"].ToString(); // Đổi từ "Name" sang "FoodName"
        //    this.Count = Convert.ToInt32(row["Count"]);
        //    this.Price = Convert.ToSingle(row["Price"]);
        //    this.TotalPrice = Convert.ToSingle(row["TotalPrice"]);
        //}

        //public string DrinkName { get; set; }
        //public int Count { get; set; }
        //public float Price { get; set; }
        //public float TotalPrice { get; set; }



    }
}
