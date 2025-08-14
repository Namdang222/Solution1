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
