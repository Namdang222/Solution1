using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffeeApp.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime date, int? maKH, int? maNV, int maBan, int? maKM, decimal total, string status)
        {
            ID = id;
            Date = date;
            MaKH = maKH;
            MaNV = maNV;
            MaBan = maBan;
            MaKM = maKM;
            Total = total;
            Status = status;
        }

        public Bill(DataRow row)
        {
            ID = (int)row["MaHD"];
            Date = (DateTime)row["NgayLap"];
            MaKH = row["MaKH"] != DBNull.Value ? (int?)row["MaKH"] : null;
            MaNV = row["MaNV"] != DBNull.Value ? (int?)row["MaNV"] : null;
            MaBan = (int)row["MaBan"];
            MaKM = row["MaKhuyenMai"] != DBNull.Value ? (int?)row["MaKhuyenMai"] : null;
            Total = (decimal)row["TongTien"];
            Status = row["TrangThai"].ToString();
        }

        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int? MaKH { get; set; }
        public int? MaNV { get; set; }
        public int MaBan { get; set; }
        public int? MaKM { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
    }
}