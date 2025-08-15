using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffeeApp.DTO
{
    public class Account
    {
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




