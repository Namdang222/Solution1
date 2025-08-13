using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyCoffeeApp
{
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
            LoadTable();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            Application.Exit();
        }
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile accountProfile = new AccountProfile();
            accountProfile.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }
        void LoadTable()
        {
            // This method should load the tables from the database and display them in the UI.
            // For example, you might use a DataGridView to show the tables.
            // Here is a placeholder for the actual implementation.
            MessageBox.Show("LoadTable method is not implemented yet.");

        }
    }
}
