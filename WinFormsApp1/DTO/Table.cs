using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HappyCoffeeApp.DTO
{
    public class Table
    {
        public Table(int maBan, string viTri, string trangThai)
        {

            ID = id;
            Name = name;
            Status = status;

            this.MaBan = maBan;
            this.ViTri = viTri;
            this.TrangThai = trangThai;

        }

        public Table(DataRow row)
        {

            ID = (int)row["MaBan"];
            Name = row["ViTri"].ToString();
            Status = row["TrangThai"].ToString();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

            this.MaBan = (int)row["MaBan"];
            this.ViTri = row["ViTri"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
        }

        private int maBan;
        public int MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }

        private string viTri;
        public string ViTri
        {
            get { return viTri; }
            set { viTri = value; }
        }

        private string trangThai;
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }


    }
}
