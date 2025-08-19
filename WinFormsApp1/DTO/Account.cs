using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffeeApp.DTO
{
    public class Account
    {

        public Account(string userName, string displayName, int type, string password = null )
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = (int)row["type"];
            this.Password = row["password"].ToString();
        }

        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string displayName;
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Role { get; set; } // "User" hoặc "Admin"

        public Account(string username, string password, string role)
        {
            TenDangNhap = username;
            MatKhau = password;
            Role = role;
        }
    }
}
