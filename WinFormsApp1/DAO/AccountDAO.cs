using HappyCoffeeApp.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HappyCoffeeApp.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance => instance ??= new AccountDAO();
        private AccountDAO() { }

        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=PRO131;Integrated Security=True;Trust Server Certificate=True";

        public List<Account> GetAllAccounts()
        {
            List<Account> list = new List<Account>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TenDangNhap, MatKhau, Role FROM TaiKhoan";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Account(
                                reader["TenDangNhap"].ToString(),
                                reader["MatKhau"].ToString(),
                                reader["Role"].ToString()
                            ));
                        }
                    }
                }
            }
            return list;
        }

        public bool InsertAccount(Account acc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau) VALUES (@username, @password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", acc.Username);
                    cmd.Parameters.AddWithValue("@password", acc.Password);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateAccount(Account acc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE TaiKhoan SET MatKhau=@password, Role=@role WHERE TenDangNhap=@username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", acc.Username);
                    cmd.Parameters.AddWithValue("@password", acc.Password);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteAccount(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM TaiKhoan WHERE TenDangNhap=@username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ResetPassword(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE TaiKhoan SET MatKhau='123' WHERE TenDangNhap=@username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName, @displayName, @password, @newPassword", new object[] {userName, displayName, pass, newPass});
            return result > 0;
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where userName = '" +  userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
    }
}
