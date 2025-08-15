namespace HappyCoffeeApp
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbc_Admin = new TabControl();
            tcb_Bill = new TabPage();
            panel2 = new Panel();
            btn_ViewBill = new Button();
            dTP_ToDate = new DateTimePicker();
            dTP_FromDate = new DateTimePicker();
            panel1 = new Panel();
            dGv_Total = new DataGridView();
            tcb_Drinks = new TabPage();
            panel5 = new Panel();
            btn_ShowDrinks = new Button();
            btn_UpdateDrinks = new Button();
            btb_DelDrinks = new Button();
            btn_AddDrinks = new Button();
            panel4 = new Panel();
            num_Price = new NumericUpDown();
            label4 = new Label();
            cmb_DrinksCategory = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txt_NameDrinks = new TextBox();
            label1 = new Label();
            txt_DrinksID = new TextBox();
            panel3 = new Panel();
            dgV_Drinks = new DataGridView();
            tcb_DrinksCategory = new TabPage();
            dGv_Category = new DataGridView();
            btn_ViewCategory = new Button();
            btn_EditCategory = new Button();
            btn_DelCaregory = new Button();
            btn_AddCategory = new Button();
            panel8 = new Panel();
            txt_DangMucCaregory = new TextBox();
            label6 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            tcb_Table = new TabPage();
            dGv_taBle = new DataGridView();
            btn_ViewTable = new Button();
            btn_EditTable = new Button();
            btn_DelTable = new Button();
            btn_AddTable = new Button();
            panel7 = new Panel();
            cmb_TableStatus = new ComboBox();
            label9 = new Label();
            txt_TableName = new TextBox();
            label5 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            tcb_Accounts = new TabPage();
            dGv_accCount = new DataGridView();
            panel9 = new Panel();
            btn_ResetPass = new Button();
            cmb_AccountType = new ComboBox();
            label12 = new Label();
            txt_DisplayName = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txt_UserName = new TextBox();
            btn_showAccCount = new Button();
            btn_editAccount = new Button();
            btn_delAccount = new Button();
            btn_addAccount = new Button();
            tbc_Admin.SuspendLayout();
            tcb_Bill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGv_Total).BeginInit();
            tcb_Drinks.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_Price).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgV_Drinks).BeginInit();
            tcb_DrinksCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGv_Category).BeginInit();
            panel8.SuspendLayout();
            tcb_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGv_taBle).BeginInit();
            panel7.SuspendLayout();
            tcb_Accounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGv_accCount).BeginInit();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // tbc_Admin
            // 
            tbc_Admin.Controls.Add(tcb_Bill);
            tbc_Admin.Controls.Add(tcb_Drinks);
            tbc_Admin.Controls.Add(tcb_DrinksCategory);
            tbc_Admin.Controls.Add(tcb_Table);
            tbc_Admin.Controls.Add(tcb_Accounts);
            tbc_Admin.Location = new Point(7, 13);
            tbc_Admin.Name = "tbc_Admin";
            tbc_Admin.SelectedIndex = 0;
            tbc_Admin.Size = new Size(889, 480);
            tbc_Admin.TabIndex = 0;
            // 
            // tcb_Bill
            // 
            tcb_Bill.Controls.Add(panel2);
            tcb_Bill.Controls.Add(panel1);
            tcb_Bill.Location = new Point(4, 29);
            tcb_Bill.Name = "tcb_Bill";
            tcb_Bill.Padding = new Padding(3);
            tcb_Bill.Size = new Size(881, 447);
            tcb_Bill.TabIndex = 0;
            tcb_Bill.Text = "Doanh Thu";
            tcb_Bill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_ViewBill);
            panel2.Controls.Add(dTP_ToDate);
            panel2.Controls.Add(dTP_FromDate);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(869, 74);
            panel2.TabIndex = 1;
            // 
            // btn_ViewBill
            // 
            btn_ViewBill.Location = new Point(682, 4);
            btn_ViewBill.Name = "btn_ViewBill";
            btn_ViewBill.Size = new Size(94, 29);
            btn_ViewBill.TabIndex = 2;
            btn_ViewBill.Text = "Thống kê";
            btn_ViewBill.UseVisualStyleBackColor = true;
            btn_ViewBill.Click += btn_ViewBill_Click;
            // 
            // dTP_ToDate
            // 
            dTP_ToDate.Location = new Point(259, 3);
            dTP_ToDate.Name = "dTP_ToDate";
            dTP_ToDate.Size = new Size(250, 27);
            dTP_ToDate.TabIndex = 1;
            // 
            // dTP_FromDate
            // 
            dTP_FromDate.Location = new Point(3, 3);
            dTP_FromDate.Name = "dTP_FromDate";
            dTP_FromDate.Size = new Size(250, 27);
            dTP_FromDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dGv_Total);
            panel1.Location = new Point(6, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 347);
            panel1.TabIndex = 0;
            // 
            // dGv_Total
            // 
            dGv_Total.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGv_Total.Location = new Point(3, 3);
            dGv_Total.Name = "dGv_Total";
            dGv_Total.RowHeadersWidth = 51;
            dGv_Total.Size = new Size(863, 341);
            dGv_Total.TabIndex = 0;
            // 
            // tcb_Drinks
            // 
            tcb_Drinks.Controls.Add(panel5);
            tcb_Drinks.Controls.Add(panel4);
            tcb_Drinks.Controls.Add(panel3);
            tcb_Drinks.Location = new Point(4, 29);
            tcb_Drinks.Name = "tcb_Drinks";
            tcb_Drinks.Padding = new Padding(3);
            tcb_Drinks.Size = new Size(881, 447);
            tcb_Drinks.TabIndex = 1;
            tcb_Drinks.Text = "Đồ uống";
            tcb_Drinks.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_ShowDrinks);
            panel5.Controls.Add(btn_UpdateDrinks);
            panel5.Controls.Add(btb_DelDrinks);
            panel5.Controls.Add(btn_AddDrinks);
            panel5.Location = new Point(6, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(505, 62);
            panel5.TabIndex = 2;
            // 
            // btn_ShowDrinks
            // 
            btn_ShowDrinks.Location = new Point(305, 3);
            btn_ShowDrinks.Name = "btn_ShowDrinks";
            btn_ShowDrinks.Size = new Size(94, 56);
            btn_ShowDrinks.TabIndex = 3;
            btn_ShowDrinks.Text = "Xem";
            btn_ShowDrinks.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateDrinks
            // 
            btn_UpdateDrinks.Location = new Point(205, 3);
            btn_UpdateDrinks.Name = "btn_UpdateDrinks";
            btn_UpdateDrinks.Size = new Size(94, 56);
            btn_UpdateDrinks.TabIndex = 2;
            btn_UpdateDrinks.Text = "Sửa";
            btn_UpdateDrinks.UseVisualStyleBackColor = true;
            btn_UpdateDrinks.Click += btn_UpdateDrinks_Click;
            // 
            // btb_DelDrinks
            // 
            btb_DelDrinks.Location = new Point(103, 3);
            btb_DelDrinks.Name = "btb_DelDrinks";
            btb_DelDrinks.Size = new Size(94, 56);
            btb_DelDrinks.TabIndex = 1;
            btb_DelDrinks.Text = "Xóa";
            btb_DelDrinks.UseVisualStyleBackColor = true;
            btb_DelDrinks.Click += btb_DelDrinks_Click;
            // 
            // btn_AddDrinks
            // 
            btn_AddDrinks.Location = new Point(3, 3);
            btn_AddDrinks.Name = "btn_AddDrinks";
            btn_AddDrinks.Size = new Size(94, 56);
            btn_AddDrinks.TabIndex = 0;
            btn_AddDrinks.Text = "Thêm";
            btn_AddDrinks.UseVisualStyleBackColor = true;
            btn_AddDrinks.Click += btn_AddDrinks_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(num_Price);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(cmb_DrinksCategory);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txt_NameDrinks);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txt_DrinksID);
            panel4.Location = new Point(517, 74);
            panel4.Name = "panel4";
            panel4.Size = new Size(358, 367);
            panel4.TabIndex = 1;
            // 
            // num_Price
            // 
            num_Price.Location = new Point(98, 133);
            num_Price.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            num_Price.Name = "num_Price";
            num_Price.Size = new Size(241, 27);
            num_Price.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 135);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 10;
            label4.Text = "Giá:";
            // 
            // cmb_DrinksCategory
            // 
            cmb_DrinksCategory.FormattingEnabled = true;
            cmb_DrinksCategory.Location = new Point(98, 90);
            cmb_DrinksCategory.Name = "cmb_DrinksCategory";
            cmb_DrinksCategory.Size = new Size(241, 28);
            cmb_DrinksCategory.TabIndex = 9;
            cmb_DrinksCategory.SelectedIndexChanged += cmb_DrinksCategory_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 93);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 8;
            label3.Text = "Danh mục:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 55);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 6;
            label2.Text = "Tên Coffee:";
            // 
            // txt_NameDrinks
            // 
            txt_NameDrinks.Location = new Point(98, 52);
            txt_NameDrinks.Name = "txt_NameDrinks";
            txt_NameDrinks.Size = new Size(241, 27);
            txt_NameDrinks.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 22);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // txt_DrinksID
            // 
            txt_DrinksID.Location = new Point(98, 19);
            txt_DrinksID.Name = "txt_DrinksID";
            txt_DrinksID.ReadOnly = true;
            txt_DrinksID.Size = new Size(241, 27);
            txt_DrinksID.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgV_Drinks);
            panel3.Location = new Point(3, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(508, 367);
            panel3.TabIndex = 0;
            // 
            // dgV_Drinks
            // 
            dgV_Drinks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgV_Drinks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgV_Drinks.Location = new Point(3, 3);
            dgV_Drinks.Name = "dgV_Drinks";
            dgV_Drinks.RowHeadersWidth = 51;
            dgV_Drinks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgV_Drinks.Size = new Size(502, 361);
            dgV_Drinks.TabIndex = 0;
            dgV_Drinks.SelectionChanged += dgV_Drinks_SelectionChanged;
            // 
            // tcb_DrinksCategory
            // 
            tcb_DrinksCategory.Controls.Add(dGv_Category);
            tcb_DrinksCategory.Controls.Add(btn_ViewCategory);
            tcb_DrinksCategory.Controls.Add(btn_EditCategory);
            tcb_DrinksCategory.Controls.Add(btn_DelCaregory);
            tcb_DrinksCategory.Controls.Add(btn_AddCategory);
            tcb_DrinksCategory.Controls.Add(panel8);
            tcb_DrinksCategory.Location = new Point(4, 29);
            tcb_DrinksCategory.Name = "tcb_DrinksCategory";
            tcb_DrinksCategory.Padding = new Padding(3);
            tcb_DrinksCategory.Size = new Size(881, 447);
            tcb_DrinksCategory.TabIndex = 2;
            tcb_DrinksCategory.Text = "Danh mục";
            tcb_DrinksCategory.UseVisualStyleBackColor = true;
            // 
            // dGv_Category
            // 
            dGv_Category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGv_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGv_Category.Location = new Point(10, 75);
            dGv_Category.Name = "dGv_Category";
            dGv_Category.RowHeadersWidth = 51;
            dGv_Category.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGv_Category.Size = new Size(502, 366);
            dGv_Category.TabIndex = 10;
            // 
            // btn_ViewCategory
            // 
            btn_ViewCategory.Location = new Point(306, 4);
            btn_ViewCategory.Name = "btn_ViewCategory";
            btn_ViewCategory.Size = new Size(94, 56);
            btn_ViewCategory.TabIndex = 8;
            btn_ViewCategory.Text = "Xem";
            btn_ViewCategory.UseVisualStyleBackColor = true;
            btn_ViewCategory.Click += btn_ViewCategory_Click;
            // 
            // btn_EditCategory
            // 
            btn_EditCategory.Location = new Point(206, 4);
            btn_EditCategory.Name = "btn_EditCategory";
            btn_EditCategory.Size = new Size(94, 56);
            btn_EditCategory.TabIndex = 7;
            btn_EditCategory.Text = "Sửa";
            btn_EditCategory.UseVisualStyleBackColor = true;
            btn_EditCategory.Click += btn_EditCategory_Click;
            // 
            // btn_DelCaregory
            // 
            btn_DelCaregory.Location = new Point(104, 4);
            btn_DelCaregory.Name = "btn_DelCaregory";
            btn_DelCaregory.Size = new Size(94, 56);
            btn_DelCaregory.TabIndex = 5;
            btn_DelCaregory.Text = "Xóa";
            btn_DelCaregory.UseVisualStyleBackColor = true;
            btn_DelCaregory.Click += btn_DelCaregory_Click;
            // 
            // btn_AddCategory
            // 
            btn_AddCategory.Location = new Point(4, 4);
            btn_AddCategory.Name = "btn_AddCategory";
            btn_AddCategory.Size = new Size(94, 56);
            btn_AddCategory.TabIndex = 4;
            btn_AddCategory.Text = "Thêm";
            btn_AddCategory.UseVisualStyleBackColor = true;
            btn_AddCategory.Click += btn_AddCategory_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(txt_DangMucCaregory);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(textBox3);
            panel8.Location = new Point(518, 75);
            panel8.Name = "panel8";
            panel8.Size = new Size(358, 367);
            panel8.TabIndex = 6;
            // 
            // txt_DangMucCaregory
            // 
            txt_DangMucCaregory.Location = new Point(101, 57);
            txt_DangMucCaregory.Name = "txt_DangMucCaregory";
            txt_DangMucCaregory.Size = new Size(241, 27);
            txt_DangMucCaregory.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 60);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 8;
            label6.Text = "Danh mục:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 22);
            label8.Name = "label8";
            label8.Size = new Size(27, 20);
            label8.TabIndex = 4;
            label8.Text = "ID:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 19);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(241, 27);
            textBox3.TabIndex = 5;
            // 
            // tcb_Table
            // 
            tcb_Table.Controls.Add(dGv_taBle);
            tcb_Table.Controls.Add(btn_ViewTable);
            tcb_Table.Controls.Add(btn_EditTable);
            tcb_Table.Controls.Add(btn_DelTable);
            tcb_Table.Controls.Add(btn_AddTable);
            tcb_Table.Controls.Add(panel7);
            tcb_Table.Location = new Point(4, 29);
            tcb_Table.Name = "tcb_Table";
            tcb_Table.Padding = new Padding(3);
            tcb_Table.Size = new Size(881, 447);
            tcb_Table.TabIndex = 3;
            tcb_Table.Text = "Bàn ngồi";
            tcb_Table.UseVisualStyleBackColor = true;
            // 
            // dGv_taBle
            // 
            dGv_taBle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGv_taBle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGv_taBle.Location = new Point(10, 75);
            dGv_taBle.Name = "dGv_taBle";
            dGv_taBle.RowHeadersWidth = 51;
            dGv_taBle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGv_taBle.Size = new Size(502, 366);
            dGv_taBle.TabIndex = 16;
            // 
            // btn_ViewTable
            // 
            btn_ViewTable.Location = new Point(306, 4);
            btn_ViewTable.Name = "btn_ViewTable";
            btn_ViewTable.Size = new Size(94, 56);
            btn_ViewTable.TabIndex = 15;
            btn_ViewTable.Text = "Xem";
            btn_ViewTable.UseVisualStyleBackColor = true;
            btn_ViewTable.Click += btn_ViewTable_Click;
            // 
            // btn_EditTable
            // 
            btn_EditTable.Location = new Point(206, 4);
            btn_EditTable.Name = "btn_EditTable";
            btn_EditTable.Size = new Size(94, 56);
            btn_EditTable.TabIndex = 14;
            btn_EditTable.Text = "Sửa";
            btn_EditTable.UseVisualStyleBackColor = true;
            btn_EditTable.Click += btn_EditTable_Click;
            // 
            // btn_DelTable
            // 
            btn_DelTable.Location = new Point(104, 4);
            btn_DelTable.Name = "btn_DelTable";
            btn_DelTable.Size = new Size(94, 56);
            btn_DelTable.TabIndex = 12;
            btn_DelTable.Text = "Xóa";
            btn_DelTable.UseVisualStyleBackColor = true;
            btn_DelTable.Click += btn_DelTable_Click;
            // 
            // btn_AddTable
            // 
            btn_AddTable.Location = new Point(4, 4);
            btn_AddTable.Name = "btn_AddTable";
            btn_AddTable.Size = new Size(94, 56);
            btn_AddTable.TabIndex = 11;
            btn_AddTable.Text = "Thêm";
            btn_AddTable.UseVisualStyleBackColor = true;
            btn_AddTable.Click += btn_AddTable_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(cmb_TableStatus);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(txt_TableName);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(textBox2);
            panel7.Location = new Point(518, 75);
            panel7.Name = "panel7";
            panel7.Size = new Size(358, 367);
            panel7.TabIndex = 13;
            // 
            // cmb_TableStatus
            // 
            cmb_TableStatus.FormattingEnabled = true;
            cmb_TableStatus.Location = new Point(101, 95);
            cmb_TableStatus.Name = "cmb_TableStatus";
            cmb_TableStatus.Size = new Size(238, 28);
            cmb_TableStatus.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 103);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 10;
            label9.Text = "Trạng thái:";
            // 
            // txt_TableName
            // 
            txt_TableName.Location = new Point(101, 57);
            txt_TableName.Name = "txt_TableName";
            txt_TableName.Size = new Size(238, 27);
            txt_TableName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 60);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 8;
            label5.Text = "Tên bàn:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 22);
            label7.Name = "label7";
            label7.Size = new Size(27, 20);
            label7.TabIndex = 4;
            label7.Text = "ID:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 19);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(241, 27);
            textBox2.TabIndex = 5;
            // 
            // tcb_Accounts
            // 
            tcb_Accounts.Controls.Add(dGv_accCount);
            tcb_Accounts.Controls.Add(panel9);
            tcb_Accounts.Controls.Add(btn_showAccCount);
            tcb_Accounts.Controls.Add(btn_editAccount);
            tcb_Accounts.Controls.Add(btn_delAccount);
            tcb_Accounts.Controls.Add(btn_addAccount);
            tcb_Accounts.Location = new Point(4, 29);
            tcb_Accounts.Name = "tcb_Accounts";
            tcb_Accounts.Padding = new Padding(3);
            tcb_Accounts.Size = new Size(881, 447);
            tcb_Accounts.TabIndex = 4;
            tcb_Accounts.Text = "Tài khoản";
            tcb_Accounts.UseVisualStyleBackColor = true;
            // 
            // dGv_accCount
            // 
            dGv_accCount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGv_accCount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGv_accCount.Location = new Point(6, 74);
            dGv_accCount.Name = "dGv_accCount";
            dGv_accCount.RowHeadersWidth = 51;
            dGv_accCount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGv_accCount.Size = new Size(502, 366);
            dGv_accCount.TabIndex = 21;
            dGv_accCount.SelectionChanged += dGv_accCount_SelectionChanged;
            // 
            // panel9
            // 
            panel9.Controls.Add(btn_ResetPass);
            panel9.Controls.Add(cmb_AccountType);
            panel9.Controls.Add(label12);
            panel9.Controls.Add(txt_DisplayName);
            panel9.Controls.Add(label10);
            panel9.Controls.Add(label11);
            panel9.Controls.Add(txt_UserName);
            panel9.Location = new Point(517, 74);
            panel9.Name = "panel9";
            panel9.Size = new Size(358, 367);
            panel9.TabIndex = 20;
            // 
            // btn_ResetPass
            // 
            btn_ResetPass.Location = new Point(208, 127);
            btn_ResetPass.Name = "btn_ResetPass";
            btn_ResetPass.Size = new Size(131, 56);
            btn_ResetPass.TabIndex = 22;
            btn_ResetPass.Text = "Đặt lại mật khẩu";
            btn_ResetPass.UseVisualStyleBackColor = true;
            btn_ResetPass.Click += btn_ResetPass_Click;
            // 
            // cmb_AccountType
            // 
            cmb_AccountType.FormattingEnabled = true;
            cmb_AccountType.Location = new Point(122, 93);
            cmb_AccountType.Name = "cmb_AccountType";
            cmb_AccountType.Size = new Size(217, 28);
            cmb_AccountType.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 96);
            label12.Name = "label12";
            label12.Size = new Size(105, 20);
            label12.TabIndex = 10;
            label12.Text = "Loại tài khoản:";
            // 
            // txt_DisplayName
            // 
            txt_DisplayName.Location = new Point(122, 57);
            txt_DisplayName.Name = "txt_DisplayName";
            txt_DisplayName.Size = new Size(217, 27);
            txt_DisplayName.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 60);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 8;
            label10.Text = "Mật khẩu:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 22);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 4;
            label11.Text = "Tên tài khoản:";
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(122, 19);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(217, 27);
            txt_UserName.TabIndex = 5;
            // 
            // btn_showAccCount
            // 
            btn_showAccCount.Location = new Point(308, 6);
            btn_showAccCount.Name = "btn_showAccCount";
            btn_showAccCount.Size = new Size(94, 56);
            btn_showAccCount.TabIndex = 19;
            btn_showAccCount.Text = "Xem";
            btn_showAccCount.UseVisualStyleBackColor = true;
            // 
            // btn_editAccount
            // 
            btn_editAccount.Location = new Point(208, 6);
            btn_editAccount.Name = "btn_editAccount";
            btn_editAccount.Size = new Size(94, 56);
            btn_editAccount.TabIndex = 18;
            btn_editAccount.Text = "Sửa";
            btn_editAccount.UseVisualStyleBackColor = true;
            btn_editAccount.Click += btn_editAccount_Click;
            // 
            // btn_delAccount
            // 
            btn_delAccount.Location = new Point(106, 6);
            btn_delAccount.Name = "btn_delAccount";
            btn_delAccount.Size = new Size(94, 56);
            btn_delAccount.TabIndex = 17;
            btn_delAccount.Text = "Xóa";
            btn_delAccount.UseVisualStyleBackColor = true;
            btn_delAccount.Click += btn_delAccount_Click;
            // 
            // btn_addAccount
            // 
            btn_addAccount.Location = new Point(6, 6);
            btn_addAccount.Name = "btn_addAccount";
            btn_addAccount.Size = new Size(94, 56);
            btn_addAccount.TabIndex = 16;
            btn_addAccount.Text = "Thêm";
            btn_addAccount.UseVisualStyleBackColor = true;
            btn_addAccount.Click += btn_addAccount_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(908, 505);
            Controls.Add(tbc_Admin);
            MaximizeBox = false;
            Name = "Admin";
            Text = "Admin";
            tbc_Admin.ResumeLayout(false);
            tcb_Bill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGv_Total).EndInit();
            tcb_Drinks.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_Price).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgV_Drinks).EndInit();
            tcb_DrinksCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGv_Category).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            tcb_Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGv_taBle).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tcb_Accounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGv_accCount).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbc_Admin;
        private TabPage tcb_Bill;
        private TabPage tcb_Drinks;
        private TabPage tcb_DrinksCategory;
        private TabPage tcb_Table;
        private TabPage tcb_Accounts;
        private Panel panel2;
        private DateTimePicker dTP_FromDate;
        private Panel panel1;
        private DataGridView dGv_Total;
        private Button btn_ViewBill;
        private DateTimePicker dTP_ToDate;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button btn_ShowDrinks;
        private Button btn_UpdateDrinks;
        private Button btb_DelDrinks;
        private Button btn_AddDrinks;
        private DataGridView dgV_Drinks;
        private Label label1;
        private TextBox txt_DrinksID;
        private Label label2;
        private TextBox txt_NameDrinks;
        private NumericUpDown num_Price;
        private Label label4;
        private ComboBox cmb_DrinksCategory;
        private Label label3;
        private DataGridView dGv_Category;
        private Button btn_ViewCategory;
        private Button btn_EditCategory;
        private Button btn_DelCaregory;
        private Button btn_AddCategory;
        private Panel panel8;
        private Label label6;
        private Label label8;
        private TextBox textBox3;
        private TextBox txt_DangMucCaregory;
        private DataGridView dGv_taBle;
        private Button btn_ViewTable;
        private Button btn_EditTable;
        private Button btn_DelTable;
        private Button btn_AddTable;
        private Panel panel7;
        private TextBox txt_TableName;
        private Label label5;
        private Label label7;
        private TextBox textBox2;
        private ComboBox cmb_TableStatus;
        private Label label9;
        private DataGridView dGv_accCount;
        private Panel panel9;
        private TextBox txt_DisplayName;
        private Label label10;
        private Label label11;
        private TextBox txt_UserName;
        private Button btn_showAccCount;
        private Button btn_editAccount;
        private Button btn_delAccount;
        private Button btn_addAccount;
        private ComboBox cmb_AccountType;
        private Label label12;
        private Button btn_ResetPass;
    }
}