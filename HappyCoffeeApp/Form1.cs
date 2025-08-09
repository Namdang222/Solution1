using System;
using System.Drawing;
using System.Windows.Forms;
namespace HappyCoffeeApp
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            pic_Logo.Image = Image.FromFile("D:\\FPT Polytechnic\\FPT Polytechnic\\PRO131\\Happy Coffee.png");
            pic_Logo.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        private void pic_Logo_Click(object sender, EventArgs e)
        {

        }
    }
}
