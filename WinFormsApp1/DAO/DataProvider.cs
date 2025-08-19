using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;

namespace HappyCoffeeApp.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance => instance ??= new DataProvider();
        private string connectionString =
            "Data Source=Matilda;Initial Catalog=PRO131;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        // Lấy danh sách tên param xuất hiện trong query theo thứ tự
        private List<string> GetParameterNames(string query)
        {
            var matches = Regex.Matches(query, @"@\w+");
            var names = new List<string>();
            foreach (Match m in matches)
            {
                string name = m.Value;
                if (!names.Contains(name))
                    names.Add(name);
            }
            return names;
        }

        // Thêm parameters vào SqlCommand theo logic đã mô tả
        private void AddParameters(SqlCommand cmd, string query, object[] parameter)
        {
            if (parameter == null || parameter.Length == 0) return;

            var names = GetParameterNames(query);

            if (names.Count == 0)
            {
                // Không tìm thấy tên tham số -> dùng @p0,@p1,... (backward-compatibility)
                for (int i = 0; i < parameter.Length; i++)
                {
                    cmd.Parameters.AddWithValue($"@p{i}", parameter[i] ?? DBNull.Value);
                }
                return;
            }

            if (parameter.Length != names.Count)
            {
                throw new ArgumentException(
                    $"Parameter count mismatch: query has {names.Count} parameters ({string.Join(", ", names)}) but you passed {parameter.Length} values.");
            }

            for (int i = 0; i < names.Count; i++)
            {
                cmd.Parameters.AddWithValue(names[i], parameter[i] ?? DBNull.Value);
            }
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    AddParameters(cmd, query, parameter);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int r = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    AddParameters(cmd, query, parameter);
                    r = cmd.ExecuteNonQuery();
                }
            }
            return r;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object r = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    AddParameters(cmd, query, parameter);
                    r = cmd.ExecuteScalar();
                }
            }
            return r;
        }
    }
}
