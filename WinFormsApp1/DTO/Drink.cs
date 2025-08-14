using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffeeApp.DTO
{
    public class Drink
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }

        public Drink() { }

        public Drink(DataRow row)
        {
            ID = (int)row["MaSP"];
            Name = row["TenSP"].ToString();
            Price = (decimal)row["DonGia"];
            CategoryID = (int)row["MaLoaiSanPham"];
        }
    }
}
