using System.Data;

namespace HappyCoffeeApp.DTO
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Category(int id, string name)
        {
            ID = id;
            Name = name;
        }

        // Constructor nhận DataRow
        public Category(DataRow row)
        {
            // Chú ý trùng với tên cột trong bảng SQL
            ID = (int)row["MaLoaiSP"];
            Name = (string?)row["TenLoai"];
        }
    }
}
