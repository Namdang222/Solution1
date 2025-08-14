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
    }
}
