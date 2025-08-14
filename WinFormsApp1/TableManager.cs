using HappyCoffeeApp.DAO;
using HappyCoffeeApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace HappyCoffeeApp
{
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cmb_Category.DataSource = listCategory;
            cmb_Category.DisplayMember = "Name";
        }
        void LoadDrinkListByCategoryID(int MaSP)
        {
            List<Drink> listDrinks = DrinkDAO.Instance.GetFoodByCategoryID(MaSP);
            cbFood.DataSource = listDrinks;
            cbFood.DisplayMember = "Name";
        }
        void LoadTable()
        {
            fLP_Table.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.ViTri + Environment.NewLine + item.TrangThai;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                fLP_Table.Controls.Add(btn);
            }

        }
        void ShowBill(int id)
        {
            lsv_Bill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.DrinkName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsv_Bill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).MaBan;
            lsv_Bill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
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
        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.MaSP;

            LoadDrinkListByCategoryID(id);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Kiểm tra bàn đã chọn
            if (lsv_Bill.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Table table = lsv_Bill.Tag as Table;

            // Kiểm tra món đã chọn
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

            // Kiểm tra hóa đơn hiện tại của bàn
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.MaBan);

            if (idBill == -1)
            {
                // Nếu chưa có hóa đơn → tạo mới
                BillDAO.Instance.InsertBill(table.MaBan);
                int newBillID = BillDAO.Instance.GetMaxIDBill();
                BillInfoDAO.Instance.InsertBillInfo(newBillID, drinkID, count);
            }
            else
            {
                // Nếu đã có hóa đơn → thêm món vào hóa đơn đó
                BillInfoDAO.Instance.InsertBillInfo(idBill, drinkID, count);
            }

            // Hiển thị lại hóa đơn và cập nhật trạng thái bàn
            ShowBill(table.MaBan);
            LoadTable();


        }
        private void btn_Check_Click(object sender, EventArgs e)
        {
            Table table = lsv_Bill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.MaBan);

            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn " + table.ViTri, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill);
                    ShowBill(table.MaBan);
                    LoadTable();
                }
            }
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}