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
            dataGridView1 = new DataGridView();
            tcb_Drinks = new TabPage();
            panel6 = new Panel();
            btn_CheckDrinks = new Button();
            txt_CheckNameDrinks = new TextBox();
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
            tcb_Table = new TabPage();
            tcb_Accounts = new TabPage();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            panel7 = new Panel();
            panel8 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            dataGridView2 = new DataGridView();
            tbc_Admin.SuspendLayout();
            tcb_Bill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tcb_Drinks.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_Price).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgV_Drinks).BeginInit();
            tcb_DrinksCategory.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(6, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 347);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(863, 341);
            dataGridView1.TabIndex = 0;
            // 
            // tcb_Drinks
            // 
            tcb_Drinks.Controls.Add(panel6);
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
            // panel6
            // 
            panel6.Controls.Add(btn_CheckDrinks);
            panel6.Controls.Add(txt_CheckNameDrinks);
            panel6.Location = new Point(517, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(358, 62);
            panel6.TabIndex = 3;
            // 
            // btn_CheckDrinks
            // 
            btn_CheckDrinks.Location = new Point(261, 3);
            btn_CheckDrinks.Name = "btn_CheckDrinks";
            btn_CheckDrinks.Size = new Size(94, 56);
            btn_CheckDrinks.TabIndex = 2;
            btn_CheckDrinks.Text = "Tìm";
            btn_CheckDrinks.UseVisualStyleBackColor = true;
            // 
            // txt_CheckNameDrinks
            // 
            txt_CheckNameDrinks.Location = new Point(3, 18);
            txt_CheckNameDrinks.Name = "txt_CheckNameDrinks";
            txt_CheckNameDrinks.Size = new Size(252, 27);
            txt_CheckNameDrinks.TabIndex = 3;
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
            // 
            // btb_DelDrinks
            // 
            btb_DelDrinks.Location = new Point(103, 3);
            btb_DelDrinks.Name = "btb_DelDrinks";
            btb_DelDrinks.Size = new Size(94, 56);
            btb_DelDrinks.TabIndex = 1;
            btb_DelDrinks.Text = "Xóa";
            btb_DelDrinks.UseVisualStyleBackColor = true;
            // 
            // btn_AddDrinks
            // 
            btn_AddDrinks.Location = new Point(3, 3);
            btn_AddDrinks.Name = "btn_AddDrinks";
            btn_AddDrinks.Size = new Size(94, 56);
            btn_AddDrinks.TabIndex = 0;
            btn_AddDrinks.Text = "Thêm";
            btn_AddDrinks.UseVisualStyleBackColor = true;
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
            dgV_Drinks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgV_Drinks.Location = new Point(3, 3);
            dgV_Drinks.Name = "dgV_Drinks";
            dgV_Drinks.RowHeadersWidth = 51;
            dgV_Drinks.Size = new Size(502, 361);
            dgV_Drinks.TabIndex = 0;
            // 
            // tcb_DrinksCategory
            // 
            tcb_DrinksCategory.Controls.Add(dataGridView2);
            tcb_DrinksCategory.Controls.Add(button1);
            tcb_DrinksCategory.Controls.Add(button2);
            tcb_DrinksCategory.Controls.Add(button3);
            tcb_DrinksCategory.Controls.Add(button4);
            tcb_DrinksCategory.Controls.Add(panel7);
            tcb_DrinksCategory.Controls.Add(panel8);
            tcb_DrinksCategory.Location = new Point(4, 29);
            tcb_DrinksCategory.Name = "tcb_DrinksCategory";
            tcb_DrinksCategory.Padding = new Padding(3);
            tcb_DrinksCategory.Size = new Size(881, 447);
            tcb_DrinksCategory.TabIndex = 2;
            tcb_DrinksCategory.Text = "Danh mục";
            tcb_DrinksCategory.UseVisualStyleBackColor = true;
            // 
            // tcb_Table
            // 
            tcb_Table.Location = new Point(4, 29);
            tcb_Table.Name = "tcb_Table";
            tcb_Table.Padding = new Padding(3);
            tcb_Table.Size = new Size(881, 447);
            tcb_Table.TabIndex = 3;
            tcb_Table.Text = "Bàn ngồi";
            tcb_Table.UseVisualStyleBackColor = true;
            // 
            // tcb_Accounts
            // 
            tcb_Accounts.Location = new Point(4, 29);
            tcb_Accounts.Name = "tcb_Accounts";
            tcb_Accounts.Padding = new Padding(3);
            tcb_Accounts.Size = new Size(881, 447);
            tcb_Accounts.TabIndex = 4;
            tcb_Accounts.Text = "Tài khoản";
            tcb_Accounts.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(306, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 56);
            button1.TabIndex = 8;
            button1.Text = "Xem";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(206, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 56);
            button2.TabIndex = 7;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(104, 4);
            button3.Name = "button3";
            button3.Size = new Size(94, 56);
            button3.TabIndex = 5;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(4, 4);
            button4.Name = "button4";
            button4.Size = new Size(94, 56);
            button4.TabIndex = 4;
            button4.Text = "Thêm";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(261, 3);
            button5.Name = "button5";
            button5.Size = new Size(94, 56);
            button5.TabIndex = 2;
            button5.Text = "Tìm";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 27);
            textBox1.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(button5);
            panel7.Controls.Add(textBox1);
            panel7.Location = new Point(518, 7);
            panel7.Name = "panel7";
            panel7.Size = new Size(358, 62);
            panel7.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Controls.Add(numericUpDown1);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(comboBox1);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(label7);
            panel8.Controls.Add(textBox2);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(textBox3);
            panel8.Location = new Point(518, 75);
            panel8.Name = "panel8";
            panel8.Size = new Size(358, 367);
            panel8.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(98, 133);
            numericUpDown1.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(241, 27);
            numericUpDown1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 135);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 10;
            label5.Text = "Giá:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 28);
            comboBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 93);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 8;
            label6.Text = "Danh mục:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 55);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 6;
            label7.Text = "Tên Coffee:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 27);
            textBox2.TabIndex = 7;
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(10, 75);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(502, 366);
            dataGridView2.TabIndex = 10;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 505);
            Controls.Add(tbc_Admin);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tbc_Admin.ResumeLayout(false);
            tcb_Bill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tcb_Drinks.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_Price).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgV_Drinks).EndInit();
            tcb_DrinksCategory.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private DataGridView dataGridView1;
        private Button btn_ViewBill;
        private DateTimePicker dTP_ToDate;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button btn_ShowDrinks;
        private Button btn_UpdateDrinks;
        private Button btb_DelDrinks;
        private Button btn_AddDrinks;
        private DataGridView dgV_Drinks;
        private TextBox txt_CheckNameDrinks;
        private Button btn_CheckDrinks;
        private Label label1;
        private TextBox txt_DrinksID;
        private Label label2;
        private TextBox txt_NameDrinks;
        private NumericUpDown num_Price;
        private Label label4;
        private ComboBox cmb_DrinksCategory;
        private Label label3;
        private DataGridView dataGridView2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel7;
        private Button button5;
        private TextBox textBox1;
        private Panel panel8;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox3;
    }
}