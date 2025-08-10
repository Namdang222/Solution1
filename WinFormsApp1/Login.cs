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
            pic_logo.Image = Image.FromFile("D:\\FPT Polytechnic\\FPT Polytechnic\\PRO131\\Happy Coffee.png");
            pic_logo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_Namelogin.Text;
            string password = txt_Passlogin.Text;
            if (login(username,password))
            {
                TableManager tableManager = new TableManager();
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
            return AccountDAO.Instance.Login(username, password);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
