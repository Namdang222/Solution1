using HappyCoffeeApp.DAO;
using HappyCoffeeApp.DTO;
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
    public partial class AccountProfile : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public AccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txt_name.Text = LoginAccount.UserName;
            txt_DisplayName.Text = LoginAccount.DisplayName;
        }

        void UpdateAccountInfo()
        {
            string displayName = txt_DisplayName.Text;
            string password = txt_Password.Text;
            string newpass = txt_NewPassword.Text;
            string reenterPass = txt_ReEnterPass.Text;
            string userName = txt_name.Text;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
                { 
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void btn_Exitt_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
        public class AccountEvent:EventArgs
        {
            private Account acc;
            public Account Acc
            {
                get { return acc; }
                set { acc = value; }
            }
            public AccountEvent(Account acc)
            {
                this.Acc = acc;
            }
        }
    }
}
