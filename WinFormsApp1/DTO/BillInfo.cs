using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffeeApp.DTO
{
    public class BillInfo
    {
        public int ID { get; set; }
        public int MaHD { get; set; }
        public int MaSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        // Dành cho hiển thị
        public string TenSanPham { get; set; }
        public DateTime NgayBan { get; set; }
        public string TenNhanVien { get; set; }

        public decimal ThanhTien => SoLuong * DonGia;

        public BillInfo(int id, int maHD, int maSP, int soLuong, decimal donGia)
        {
            ID = id;
            MaHD = maHD;
            MaSP = maSP;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        public BillInfo(DataRow row)
        {
            ID = (int)row["MaCTHD"];
            MaHD = (int)row["MaHD"];
            MaSP = (int)row["MaSP"];
            SoLuong = (int)row["SoLuong"];
            DonGia = (decimal)row["DonGia"];
            // Nếu DataRow có các cột TenSanPham, NgayBan, TenNhanVien
            if (row.Table.Columns.Contains("TenSanPham")) TenSanPham = row["TenSanPham"].ToString();
            if (row.Table.Columns.Contains("NgayBan")) NgayBan = (DateTime)row["NgayBan"];
            if (row.Table.Columns.Contains("TenNhanVien")) TenNhanVien = row["TenNhanVien"].ToString();
        }
    }
}
