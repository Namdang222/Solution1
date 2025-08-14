using HappyCoffeeApp.DAO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HappyCoffeeApp
{
    public partial class Admin : Form
    {
        private object connection;

        public Admin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            loadacclist();
        }

        private void Admin_Load(object sender, EventArgs e)
        {


        }

        private void dGv_Total_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void loadacclist()
        {
            string sqlconn = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=PRO131;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(sqlconn);
            string query = "select * from ";
        }
    }
}
