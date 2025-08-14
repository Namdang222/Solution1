using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffeeApp.DTO
{
    public class Category
    {
        public Category(int maSP, string tenSP, decimal donGia, int maLoaiSanPham)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.DonGia = donGia;
            this.MaLoaiSanPham = maLoaiSanPham;
        }

        public Category(DataRow row)
        {
            this.MaSP = (int)row["MaSP"];
            this.TenSP = row["TenSP"].ToString();
            this.DonGia = Convert.ToDecimal(row["DonGia"]);
            this.MaLoaiSanPham = (int)row["MaLoaiSanPham"];
        }

        private int maSP;
        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        private string tenSP;
        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        private decimal donGia;
        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        private int maLoaiSanPham;
        public int MaLoaiSanPham
        {
            get { return maLoaiSanPham; }
            set { maLoaiSanPham = value; }
        }


    }
}
