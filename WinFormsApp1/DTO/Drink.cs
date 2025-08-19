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

        //public int ID { get; set; }
        //public string Name { get; set; }
        //public decimal Price { get; set; }
        //public int CategoryID { get; set; }


        public Drink(int maSP, string tenSP, int maLoaiSanPham, float donGia)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.MaLoaiSanPham = maLoaiSanPham;
            this.DonGia = donGia;
        }

        public Drink(DataRow row)
        {
            this.MaSP = (int)row["MaSP"];
            this.TenSP = row["TenSP"].ToString();
            this.MaLoaiSanPham = (int)row["MaLoaiSanPham"];
            this.DonGia = Convert.ToSingle(row["DonGia"]);
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

        private int maLoaiSanPham;
        public int MaLoaiSanPham
        {
            get { return maLoaiSanPham; }
            set { maLoaiSanPham = value; }
        }

        private float donGia;
        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }

        }

        public int CategoryID { get; internal set; }
    }
}
