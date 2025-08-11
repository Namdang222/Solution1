using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffeeApp.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool login(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { username, password });
            return Convert.ToInt32(result) > 0;
        }
    }
}
