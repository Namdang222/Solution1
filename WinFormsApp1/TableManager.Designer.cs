namespace HappyCoffeeApp
{
    partial class TableManager
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
            panel2 = new Panel();
            txbTotalPrice = new TextBox();
            cmb_Switch = new ComboBox();
            btn_SwitchTable = new Button();
            numericUpDown1 = new NumericUpDown();
            btn_Discount = new Button();
            btn_Check = new Button();
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            lsv_Bill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel4 = new Panel();
            cbFood = new ComboBox();
            num_Count = new NumericUpDown();
            btn_Add = new Button();
            cmb_Category = new ComboBox();
            fLP_Table = new FlowLayoutPanel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_Count).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbTotalPrice);
            panel2.Controls.Add(cmb_Switch);
            panel2.Controls.Add(btn_SwitchTable);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(btn_Discount);
            panel2.Controls.Add(btn_Check);
            panel2.Location = new Point(414, 296);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 79);
            panel2.TabIndex = 1;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txbTotalPrice.ForeColor = Color.OrangeRed;
            txbTotalPrice.Location = new Point(174, 30);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(128, 25);
            txbTotalPrice.TabIndex = 5;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // cmb_Switch
            // 
            cmb_Switch.FormattingEnabled = true;
            cmb_Switch.Location = new Point(5, 50);
            cmb_Switch.Margin = new Padding(3, 2, 3, 2);
            cmb_Switch.Name = "cmb_Switch";
            cmb_Switch.Size = new Size(83, 23);
            cmb_Switch.TabIndex = 3;
            // 
            // btn_SwitchTable
            // 
            btn_SwitchTable.Location = new Point(6, 14);
            btn_SwitchTable.Margin = new Padding(3, 2, 3, 2);
            btn_SwitchTable.Name = "btn_SwitchTable";
            btn_SwitchTable.Size = new Size(82, 32);
            btn_SwitchTable.TabIndex = 4;
            btn_SwitchTable.Text = "Chuyển bàn";
            btn_SwitchTable.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(93, 50);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(82, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Discount
            // 
            btn_Discount.Location = new Point(92, 14);
            btn_Discount.Margin = new Padding(3, 2, 3, 2);
            btn_Discount.Name = "btn_Discount";
            btn_Discount.Size = new Size(82, 32);
            btn_Discount.TabIndex = 3;
            btn_Discount.Text = "Giảm giá";
            btn_Discount.UseVisualStyleBackColor = true;
            // 
            // btn_Check
            // 
            btn_Check.Location = new Point(308, 21);
            btn_Check.Margin = new Padding(3, 2, 3, 2);
            btn_Check.Name = "btn_Check";
            btn_Check.Size = new Size(82, 42);
            btn_Check.TabIndex = 2;
            btn_Check.Text = "Thanh toán";
            btn_Check.UseVisualStyleBackColor = true;
            btn_Check.Click += btn_Check_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(820, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(70, 20);
            thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(170, 22);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(170, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lsv_Bill);
            panel3.Location = new Point(414, 89);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 202);
            panel3.TabIndex = 3;
            // 
            // lsv_Bill
            // 
            lsv_Bill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsv_Bill.GridLines = true;
            lsv_Bill.Location = new Point(3, 0);
            lsv_Bill.Margin = new Padding(3, 2, 3, 2);
            lsv_Bill.Name = "lsv_Bill";
            lsv_Bill.Size = new Size(391, 198);
            lsv_Bill.TabIndex = 0;
            lsv_Bill.UseCompatibleStateImageBehavior = false;
            lsv_Bill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 100;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(num_Count);
            panel4.Controls.Add(btn_Add);
            panel4.Controls.Add(cmb_Category);
            panel4.Location = new Point(416, 23);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(392, 62);
            panel4.TabIndex = 4;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(1, 36);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(135, 23);
            cbFood.TabIndex = 3;
            // 
            // num_Count
            // 
            num_Count.Location = new Point(306, 3);
            num_Count.Margin = new Padding(3, 2, 3, 2);
            num_Count.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            num_Count.Name = "num_Count";
            num_Count.Size = new Size(51, 23);
            num_Count.TabIndex = 2;
            num_Count.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(196, 2);
            btn_Add.Margin = new Padding(3, 2, 3, 2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(82, 57);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "Thêm món";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // cmb_Category
            // 
            cmb_Category.FormattingEnabled = true;
            cmb_Category.Location = new Point(3, 3);
            cmb_Category.Margin = new Padding(3, 2, 3, 2);
            cmb_Category.Name = "cmb_Category";
            cmb_Category.Size = new Size(133, 23);
            cmb_Category.TabIndex = 0;
            cmb_Category.SelectedIndexChanged += cmb_Category_SelectedIndexChanged;
            // 
            // fLP_Table
            // 
            fLP_Table.Location = new Point(10, 26);
            fLP_Table.Margin = new Padding(3, 2, 3, 2);
            fLP_Table.Name = "fLP_Table";
            fLP_Table.Size = new Size(398, 350);
            fLP_Table.TabIndex = 5;
            // 
            // TableManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 385);
            Controls.Add(fLP_Table);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TableManager";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)num_Count).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel3;
        private ListView lsv_Bill;
        private Panel panel4;
        private NumericUpDown num_Count;
        private Button btn_Add;
        private ComboBox cmb_Category;
        private Button btn_Check;
        private FlowLayoutPanel fLP_Table;
        private ComboBox cmb_Switch;
        private Button btn_SwitchTable;
        private NumericUpDown numericUpDown1;
        private Button btn_Discount;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
        private ComboBox cbFood;
    }
}