using HappyCoffeeApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using HappyCoffeeApp.DTO;

namespace HappyCoffeeApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "Images", "HappyCoffee.png");
            pic_logo.Image = Image.FromFile(imagePath);
            pic_logo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Namelogin.Text) || string.IsNullOrWhiteSpace(txt_Passlogin.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string username = txt_Namelogin.Text.Trim();
            string password = txt_Passlogin.Text.Trim();
            if (login(username, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(username); 
                TableManager tableManager = new TableManager(loginAccount);
                this.Hide();
                tableManager.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool login(string username, string password)
        {
            string query = "SELECT 1 FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { username, password });
            return Convert.ToInt32(result) > 0;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            Application.Exit();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
