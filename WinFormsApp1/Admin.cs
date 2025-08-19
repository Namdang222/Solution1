using HappyCoffeeApp.DAO;
using HappyCoffeeApp.DTO;
using System;
using System.Windows.Forms;

namespace HappyCoffeeApp
{
    public partial class Admin : Form
    {
        BindingSource drinkList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource accountList = new BindingSource();

        public Admin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Gán BindingSource vào DataGridView
            dgV_Drinks.DataSource = drinkList;
            dGv_Category.DataSource = categoryList;
            dGv_taBle.DataSource = tableList;
            dGv_accCount.DataSource = accountList;

            // Load dữ liệu
            LoadAll();

            // Add bindings
            AddDrinkBinding();
            AddCategoryBinding();
            AddTableBinding();
            AddAccountBinding();
            LoadAccountTypeCombo();
            HideDrinkCategoryIDColumn();
            HideTableIDColumn();

            // Sửa lỗi designer event
            btn_ViewBill.Click += btn_ViewBill_Click;
            btb_DelDrinks.Click += btb_DelDrinks_Click;
            dgV_Drinks.SelectionChanged += dgV_Drinks_SelectionChanged;
            btn_ViewCategory.Click += btn_ViewCategory_Click;
            btn_DelCaregory.Click += btn_DelCaregory_Click;
            btn_ViewTable.Click += btn_ViewTable_Click;
        }

        private void btn_DelCaregory_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadAll()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
            drinkList.DataSource = DrinkDAO.Instance.GetDrinkByCategoryID(
                categoryList.Count > 0 ? ((Category)categoryList[0]).ID : 0);
            tableList.DataSource = TableDAO.Instance.LoadTableList();
            accountList.DataSource = AccountDAO.Instance.GetAllAccounts();

            cmb_DrinksCategory.DataSource = categoryList;
            cmb_DrinksCategory.DisplayMember = "Name";
            cmb_DrinksCategory.ValueMember = "ID";

            cmb_AccountType.Items.Clear();
            cmb_AccountType.Items.Add("User");
            cmb_AccountType.Items.Add("Admin");
        }

        #region Bindings
        private void AddDrinkBinding()
        {
            txt_NameDrinks.DataBindings.Add("Text", drinkList, "Name", true, DataSourceUpdateMode.Never);
            num_Price.DataBindings.Add("Value", drinkList, "Price", true, DataSourceUpdateMode.Never);
            cmb_DrinksCategory.DataBindings.Add("SelectedValue", drinkList, "CategoryID", true, DataSourceUpdateMode.Never);
        }

        private void AddCategoryBinding()
        {
            txt_DangMucCaregory.DataBindings.Add("Text", categoryList, "Name", true, DataSourceUpdateMode.Never);
            textBox3.DataBindings.Add("Text", categoryList, "ID", true, DataSourceUpdateMode.Never);
        }

        private void AddTableBinding()
        {
            txt_TableName.DataBindings.Add("Text", tableList, "Name", true, DataSourceUpdateMode.Never);
            cmb_TableStatus.DataBindings.Add("Text", tableList, "Status", true, DataSourceUpdateMode.Never);
            textBox2.DataBindings.Add("Text", tableList, "ID", true, DataSourceUpdateMode.Never);
        }

        private void AddAccountBinding()
        {
            txt_UserName.DataBindings.Add("Text", accountList, "TenDangNhap", true, DataSourceUpdateMode.Never);
            txt_Password.DataBindings.Add("Text", accountList, "MatKhau", true, DataSourceUpdateMode.Never);
        }
        #endregion

        #region Drinks CRUD
        private void cmb_DrinksCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_DrinksCategory.SelectedItem == null) return;
            int categoryId = (cmb_DrinksCategory.SelectedItem as Category).ID;
            drinkList.DataSource = DrinkDAO.Instance.GetDrinkByCategoryID(categoryId);
        }
        private void HideDrinkCategoryIDColumn()
        {
            if (dgV_Drinks.Columns["CategoryID"] != null)
            {
                dgV_Drinks.Columns["CategoryID"].Visible = false;
            }
        }


        private void btn_AddDrinks_Click(object sender, EventArgs e)
        {
            string name = txt_NameDrinks.Text.Trim();
            float price = (float)num_Price.Value;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên đồ uống!");
                return;
            }

            int categoryId = 0;
            if (cmb_DrinksCategory.SelectedItem is Category category)
                categoryId = category.ID;
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục hợp lệ!");
                return;
            }

            if (DrinkDAO.Instance.InsertDrink(name, categoryId, price))
            {
                MessageBox.Show("Thêm đồ uống thành công!");
                drinkList.DataSource = DrinkDAO.Instance.GetDrinkByCategoryID(categoryId);
            }
            else MessageBox.Show("Thêm thất bại!");

        }

        private void btb_DelDrinks_Click(object sender, EventArgs e)
        {
            if (dgV_Drinks.CurrentRow == null) return;
            Drink drink = dgV_Drinks.CurrentRow.DataBoundItem as Drink;
            if (drink == null) return;

            if (DrinkDAO.Instance.DeleteDrink(drink.MaSP))
            {
                MessageBox.Show("Xóa đồ uống thành công!");
                int categoryId = drink.CategoryID;
                drinkList.DataSource = DrinkDAO.Instance.GetDrinkByCategoryID(categoryId);
            }
            else MessageBox.Show("Xóa thất bại!");
        }

        private void btn_UpdateDrinks_Click(object sender, EventArgs e)
        {
            if (dgV_Drinks.CurrentRow == null) return;
            if (!(dgV_Drinks.CurrentRow.DataBoundItem is Drink drink)) return;

            string name = txt_NameDrinks.Text.Trim();
            float price = (float)num_Price.Value;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên đồ uống!");
                return;
            }

            int categoryId = 0;
            if (cmb_DrinksCategory.SelectedItem is Category category)
                categoryId = category.ID;
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục hợp lệ!");
                return;
            }

            if (DrinkDAO.Instance.UpdateDrink(drink.MaSP, name, categoryId, price))
            {
                MessageBox.Show("Cập nhật thành công!");
                drinkList.DataSource = DrinkDAO.Instance.GetDrinkByCategoryID(categoryId);
            }
            else MessageBox.Show("Cập nhật thất bại!");

        }
        private void dgV_Drinks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgV_Drinks.CurrentRow != null)
            {
                Drink drink = dgV_Drinks.CurrentRow.DataBoundItem as Drink;
                if (drink == null) return;

                txt_NameDrinks.Text = drink.TenSP;
                num_Price.Value = (decimal)drink.DonGia;

                // Gán SelectedValue chỉ khi ComboBox đã có DataSource và ValueMember
                if (cmb_DrinksCategory.DataSource != null
                    && !string.IsNullOrEmpty(cmb_DrinksCategory.ValueMember))
                {
                    try
                    {
                        cmb_DrinksCategory.SelectedValue = drink.CategoryID;
                    }
                    catch
                    {
                        // nếu CategoryID không tồn tại trong DataSource, tránh lỗi
                        cmb_DrinksCategory.SelectedIndex = -1;
                    }
                }
            }
        }

        #endregion
        #region Category CRUD
        //private void btn_AddCategory_Click(object sender, EventArgs e)
        //{
        //    string name = txt_DangMucCaregory.Text;
        //    if (CategoryDAO.Instance.InsertCategory(name))
        //    {
        //        MessageBox.Show("Thêm danh mục thành công!");
        //        categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        //    }
        //    else MessageBox.Show("Thêm thất bại!");
        //}
        //private void btn_DelCaregory_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(textBox3.Text);
        //    if (CategoryDAO.Instance.DeleteCategory(id))
        //    {
        //        MessageBox.Show("Xóa danh mục thành công!");
        //        categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        //    }
        //    else MessageBox.Show("Xóa thất bại!");
        //}
        //private void btn_EditCategory_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(textBox3.Text);
        //    string name = txt_DangMucCaregory.Text;
        //    if (CategoryDAO.Instance.UpdateCategory(id, name))
        //    {
        //        MessageBox.Show("Cập nhật danh mục thành công!");
        //        categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        //    }
        //    else MessageBox.Show("Cập nhật thất bại!");
        //}
        private void btn_ViewCategory_Click(object sender, EventArgs e)
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        #endregion
        #region Table CRUD
        private void HideTableIDColumn()
        {
            if (dGv_taBle.Columns["ID"] != null)
            {
                dGv_taBle.Columns["ID"].Visible = false;
            }
        }
        private void btn_AddTable_Click(object sender, EventArgs e)
        {
            string name = txt_TableName.Text;
            string status = cmb_TableStatus.Text;
            if (TableDAO.Instance.InsertTable(name, status))
            {
                MessageBox.Show("Thêm bàn thành công!");
                tableList.DataSource = TableDAO.Instance.LoadTableList();
            }
            else MessageBox.Show("Thêm thất bại!");
        }
        private void btn_DelTable_Click(object sender, EventArgs e)
        {
            if (dGv_taBle.CurrentRow == null) return;
            Table table = dGv_taBle.CurrentRow.DataBoundItem as Table;
            if (table == null) return;

            if (TableDAO.Instance.DeleteTable(table.MaBan))
            {
                MessageBox.Show("Xóa bàn thành công!");
                tableList.DataSource = TableDAO.Instance.LoadTableList();
            }
            else MessageBox.Show("Không thể xóa bàn đang có liên kết!");
        }
        private void btn_EditTable_Click(object sender, EventArgs e)
        {
            if (dGv_taBle.CurrentRow == null) return;
            Table table = dGv_taBle.CurrentRow.DataBoundItem as Table;
            if (table == null) return;

            string name = txt_TableName.Text;
            string status = cmb_TableStatus.Text;

            if (TableDAO.Instance.UpdateTable(table.MaBan, name, status))
            {
                MessageBox.Show("Cập nhật bàn thành công!");
                tableList.DataSource = TableDAO.Instance.LoadTableList();
            }
            else MessageBox.Show("Cập nhật thất bại!");
        }
        private void btn_ViewTable_Click(object sender, EventArgs e)
        {
            tableList.DataSource = TableDAO.Instance.LoadTableList();
        }
        #endregion
        #region Account CRUD
        private void LoadAccountTypeCombo()
        {
            cmb_AccountType.Items.Clear();
            cmb_AccountType.Items.Add("User");
            cmb_AccountType.Items.Add("Admin");
        }
        private void btn_addAccount_Click(object sender, EventArgs e)
        {
            string role = cmb_AccountType.SelectedItem?.ToString() ?? "User";
            Account acc = new Account(txt_UserName.Text, txt_Password.Text, role);
            if (AccountDAO.Instance.InsertAccount(acc))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                accountList.DataSource = AccountDAO.Instance.GetAllAccounts();
            }
            else MessageBox.Show("Thêm thất bại!");
        }
        private void btn_editAccount_Click(object sender, EventArgs e)
        {
            string role = cmb_AccountType.SelectedItem?.ToString() ?? "User";
            Account acc = new Account(txt_UserName.Text, txt_Password.Text, role);
            if (AccountDAO.Instance.UpdateAccount(acc))
            {
                MessageBox.Show("Cập nhật thành công!");
                accountList.DataSource = AccountDAO.Instance.GetAllAccounts();
            }
            else MessageBox.Show("Cập nhật thất bại!");
        }
        private void btn_delAccount_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            if (AccountDAO.Instance.DeleteAccount(username))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
                accountList.DataSource = AccountDAO.Instance.GetAllAccounts();
            }
            else MessageBox.Show("Xóa thất bại!");
        }

        private void btn_ResetPass_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            if (AccountDAO.Instance.ResetPassword(username))
            {
                MessageBox.Show("Reset mật khẩu thành công! Mật khẩu mặc định 123");
                accountList.DataSource = AccountDAO.Instance.GetAllAccounts();
            }
            else MessageBox.Show("Reset thất bại!");
        }
        private void dGv_accCount_SelectionChanged(object sender, EventArgs e)
        {
            if (dGv_accCount.CurrentRow == null) return;
            Account acc = dGv_accCount.CurrentRow.DataBoundItem as Account;
            if (acc == null) return;

            txt_UserName.Text = acc.Username;
            txt_Password.Text = acc.Password;
            cmb_AccountType.SelectedItem = acc.DisplayName; // bind Role đúng với combo
        }
        #endregion
        #region View Bill
        private void btn_ViewBill_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dTP_FromDate.Value;
            DateTime toDate = dTP_ToDate.Value;

            var list = BillInfoDAO.Instance.GetBillInfoList(fromDate, toDate);
            dGv_Total.DataSource = list;

            // Ẩn các cột ID nếu không muốn hiển thị
            if (dGv_Total.Columns["ID"] != null) dGv_Total.Columns["ID"].Visible = false;
            if (dGv_Total.Columns["MaHD"] != null) dGv_Total.Columns["MaHD"].Visible = false;
            if (dGv_Total.Columns["MaSP"] != null) dGv_Total.Columns["MaSP"].Visible = false;
        }
        #endregion
    }
}
