using HappyCoffeeApp;
using System.Windows.Forms;

namespace WinFormsApp1
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
            TableManager tableManager = new TableManager();
            this.Hide();
            tableManager.ShowDialog();
            this.Show();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
            
        }
    }
}
