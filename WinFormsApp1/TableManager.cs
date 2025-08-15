using HappyCoffeeApp.DAO;
using HappyCoffeeApp.DTO;
using System.Globalization;
namespace HappyCoffeeApp
{
    public partial class TableManager : Form
    {
        private int _currentTableId = -1;

        public TableManager()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
            LoadSwitchTableCombo();
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
            cbFood.DisplayMember = "Name";
            cbFood.ValueMember = "ID";
        }


        void LoadTable()
        {
            fLP_Table.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table table in tableList)
            {
                Button btn = new Button() { Width = 100, Height = 60 };
                btn.Text = $"{table.Name}\n{table.Status}";
                btn.Tag = table.ID;

                if (table.Status == "Trống")
                    btn.BackColor = Color.LightGreen;
                else
                    btn.BackColor = Color.LightPink;

                btn.Click += (s, e) =>
                {
                    _currentTableId = (int)((Button)s).Tag;
                    ShowBill(_currentTableId);
                };

                fLP_Table.Controls.Add(btn);
                MessageBox.Show("Số bàn: " + fLP_Table.Controls.Count);
            }
            
        }

        void ShowBill(int maBan)
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
            AccountProfile accountProfile = new AccountProfile();
            accountProfile.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }
        void LoadSwitchTableCombo()
        {
            cmb_Switch.DataSource = TableDAO.Instance.LoadTableList();
            cmb_Switch.DisplayMember = "Name";
            cmb_Switch.ValueMember = "ID";
        }

        private void btn_SwitchTable_Click(object sender, EventArgs e)
        {
            if (_currentTableId < 0)
            {
                MessageBox.Show("Vui lòng chọn bàn để chuyển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
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
                // Chuyển hóa đơn
                TableDAO.Instance.SwitchTable(_currentTableId, targetTableId);

                // Cập nhật trạng thái bàn
                DataProvider.Instance.ExecuteNonQuery(
                    "UPDATE Ban SET TrangThai = N'Trống' WHERE MaBan = @p0",
                    new object[] { _currentTableId });

                DataProvider.Instance.ExecuteNonQuery(
                    "UPDATE Ban SET TrangThai = N'Có khách' WHERE MaBan = @p0",
                    new object[] { targetTableId });

                // Load lại bảng và hóa đơn
                LoadTable();
                ShowBill(targetTableId);

                // Cập nhật _currentTableId sang bàn mới
                _currentTableId = targetTableId;
            }

        }
    }
}
