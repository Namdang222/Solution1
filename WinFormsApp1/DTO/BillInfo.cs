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
        public BillInfo(int maCTHD, int soLuong, decimal donGia, int maHD, int maSP)
        {
            this.MaCTHD = maCTHD;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.MaHD = maHD;
            this.MaSP = maSP;
        }

        public BillInfo(DataRow row)
        {
            this.MaCTHD = (int)row["MaCTHD"];
            this.SoLuong = (int)row["SoLuong"];
            this.DonGia = Convert.ToDecimal(row["DonGia"]);
            this.MaHD = (int)row["MaHD"];
            this.MaSP = (int)row["MaSP"];
        }

        private int maCTHD;
        public int MaCTHD
        {
            get { return maCTHD; }
            set { maCTHD = value; }
        }

        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private decimal donGia;
        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        private int maHD;
        public int MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        private int maSP;
        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

    }
}
