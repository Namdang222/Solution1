using HappyCoffeeApp.DAO;
using HappyCoffeeApp.DTO;
using System.Globalization;

using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HappyCoffeeApp.AccountProfile;
using static System.Windows.Forms.ListViewItem;
namespace HappyCoffeeApp
{
    public partial class TableManager : Form
    {
        private Account loginAccount;
        private int _currentTableId;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Id); }
        }
        public TableManager(Account acc)

        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();

            LoadSwitchTableCombo();
        }

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cmb_Category.DataSource = listCategory;
            cmb_Category.DisplayMember = "Name";
            cmb_Category.ValueMember = "ID";
        }


        void LoadDrinkListByCategoryID(int id)
        {
            List<Drink> listDrink = DrinkDAO.Instance.GetDrinkByCategoryID(id);

            if (listDrink == null || listDrink.Count == 0)
            {
                // Clear combo để tránh giữ giá trị cũ
                cbFood.DataSource = null;
                cbFood.Items.Clear();
                MessageBox.Show($"Không tìm thấy sản phẩm cho category id = {id}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cbFood.DataSource = listDrink;
        }

        //void LoadDrinkListByCategoryID(int MaSP)
        //{
        //    List<Drink> listDrinks = DrinkDAO.Instance.GetFoodByCategoryID(MaSP);
        //    cbFood.DataSource = listDrinks;

        //    cbFood.DisplayMember = "Name";
        //    cbFood.ValueMember = "ID";
        //}


        public void LoadTable()
        {
            fLP_Table.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table table in tableList)
            {
                Button btn = new Button()
                {
                    Width = 100,
                    Height = 60,
                    Text = $"{table.ViTri}\n{table.TrangThai}",
                    Tag = table.MaBan
                };

                // Đổi màu theo trạng thái
                btn.BackColor = table.TrangThai == "Trống" ? Color.LightGreen : Color.LightPink;

                // Gán sự kiện click
                btn.Click += (s, e) =>
                {
                    int tableId = (int)((Button)s).Tag;
                    _currentTableId = tableId;
                    ShowBill(tableId);
                };
                // Thêm button vào giao diện
                fLP_Table.Controls.Add(btn);
            }
        }
        private void ShowBill(int maBan)
        {
            lsv_Bill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(maBan);
            decimal totalPrice = 0;

            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName);
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("n0"));
                lsvItem.SubItems.Add(item.TotalPrice.ToString("n0"));
                totalPrice += item.TotalPrice;
                lsv_Bill.Items.Add(lsvItem);
            }

            txbTotalPrice.Text = totalPrice.ToString("n0", CultureInfo.InvariantCulture);
        }


        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Category.SelectedValue is int id)
            {
                LoadDrinkListByCategoryID(id);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (_currentTableId < 0)
            {
                MessageBox.Show("Vui lòng chọn bàn");
                return;
            }

            int drinkId = (int)cbFood.SelectedValue;
            int count = (int)num_Count.Value;

            int billId = BillDAO.Instance.GetOrCreateOpenBillByTable(_currentTableId);
            BillInfoDAO.Instance.InsertBillInfo(billId, drinkId, count);

            DataProvider.Instance.ExecuteNonQuery(
                "UPDATE Ban SET TrangThai=N'Có khách' WHERE MaBan=@p0", new object[] { _currentTableId });

            ShowBill(_currentTableId);
            LoadTable();

            int tableID = ((sender as Button).Tag as Table).MaBan;
            lsv_Bill.Tag = (sender as Button).Tag;
            ShowBill(tableID);

        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (_currentTableId < 0)
            {
                MessageBox.Show("Vui lòng chọn bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy tổng tiền chưa thanh toán
            object result = DataProvider.Instance.ExecuteScalar(@"
                    SELECT SUM(ct.SoLuong * ct.DonGia)
                    FROM ChiTietHoaDon ct
                    JOIN HoaDon hd ON hd.MaHD = ct.MaHD
                    WHERE hd.MaBan=@p0 AND hd.TrangThai = N'Chưa thanh toán'",
                new object[] { _currentTableId });

            decimal total = (result == null || result == DBNull.Value) ? 0 : Convert.ToDecimal(result);

            // Lấy % giảm giá từ numericUpDown1
            int discount = (int)numericUpDown1.Value;

            // Tính tiền sau giảm giá
            decimal finalPrice = total * (100 - discount) / 100m;

            // Hiển thị tiền sau giảm giá luôn trong txbTotalPrice
            txbTotalPrice.Text = finalPrice.ToString("n0", System.Globalization.CultureInfo.InvariantCulture);

            // Lấy bill hiện tại
            int billId = BillDAO.Instance.GetOrCreateOpenBillByTable(_currentTableId);

            // Thanh toán bill với giá đã giảm
            BillDAO.Instance.Checkout(billId, finalPrice);

            // Cập nhật trạng thái bàn
            DataProvider.Instance.ExecuteNonQuery(
                "UPDATE Ban SET TrangThai = N'Trống' WHERE MaBan = @p0",
                new object[] { _currentTableId });

            // Cập nhật UI
            ShowBill(_currentTableId);
            LoadTable();

            MessageBox.Show($"Thanh toán thành công!\nTổng tiền: {total:n0}\nGiảm giá: {discount}%\nThanh toán: {finalPrice:n0}",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo",
                MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;

            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo",
                MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;

            Application.Exit();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile accountProfile = new AccountProfile(LoginAccount);
            accountProfile.UpdateAccount += f_UpdateAccount;
            accountProfile.ShowDialog();
        }
        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }
        void LoadSwitchTableCombo()
        {

            cmb_Switch.DataSource = TableDAO.Instance.LoadTableList();
            cmb_Switch.DisplayMember = "ViTri";   // hoặc "TenBan" nếu bạn có
            cmb_Switch.ValueMember = "MaBan";     // đúng với lớp Table



        }

        private void btn_SwitchTable_Click(object sender, EventArgs e)
        {
            if (_currentTableId < 0)
            {
                MessageBox.Show("Vui lòng chọn bàn để chuyển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lsv_Bill.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Table table = lsv_Bill.Tag as Table;

            if (cbFood.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn món trước khi thêm vào hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Drink selectedDrink = cbFood.SelectedItem as Drink;
            int drinkID = selectedDrink.MaSP;
            int count = (int)num_Count.Value;

            if (count <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.MaBan);

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.MaBan);
                idBill = BillDAO.Instance.GetMaxBillID();
            }

            int targetTableId = (int)cmb_Switch.SelectedValue;

            if (targetTableId == _currentTableId)
            {
                MessageBox.Show("Không thể chuyển sang cùng bàn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn chuyển bàn {_currentTableId} sang bàn {targetTableId}?",
                "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(_currentTableId, targetTableId);

                DataProvider.Instance.ExecuteNonQuery("UPDATE Ban SET TrangThai = N'Trống' WHERE MaBan = @p0", new object[] { _currentTableId });
                DataProvider.Instance.ExecuteNonQuery("UPDATE Ban SET TrangThai = N'Có khách' WHERE MaBan = @p0", new object[] { targetTableId });

                LoadTable();
                ShowBill(targetTableId);

                _currentTableId = targetTableId;

                BillInfoDAO.Instance.InsertBillInfo(idBill, drinkID, count);
            }

            ShowBill(table.MaBan);
            LoadTable();

        }
        
        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
