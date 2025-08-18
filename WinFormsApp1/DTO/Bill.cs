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

        public Bill(int maHD, DateTime ngayLap, int maKH, int maNV, int maBan, int maKhuyenMai, float tongTien)
        {
            this.MaHD = maHD;
            this.NgayLap = ngayLap;
            this.MaKH = maKH;
            this.MaNV = maNV;
            this.MaBan = maBan;
            this.MaKhuyenMai = maKhuyenMai;
            this.TongTien = tongTien;

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

            this.MaHD = (int)row["MaHD"];
            this.NgayLap = Convert.ToDateTime(row["NgayLap"]);
            this.MaKH = (int)row["MaKH"];
            this.MaNV = (int)row["MaNV"];
            this.MaBan = (int)row["MaBan"];
            this.MaKhuyenMai = (int)row["MaKhuyenMai"];
            this.TongTien = Convert.ToSingle(row["TongTien"]);
        }

        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaKH { get; set; }
        public int MaNV { get; set; }
        public int MaBan { get; set; }
        public int MaKhuyenMai { get; set; }
        public float TongTien { get; set; }
    }

}

