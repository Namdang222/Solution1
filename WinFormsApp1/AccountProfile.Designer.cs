namespace HappyCoffeeApp
{
    partial class AccountProfile
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
            panel1 = new Panel();
            txt_name = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txt_DisplayName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txt_Password = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txt_NewPassword = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txt_ReEnterPass = new TextBox();
            label5 = new Label();
            btn_Update = new Button();
            btn_Exitt = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 72);
            panel1.TabIndex = 0;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(144, 30);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(266, 27);
            txt_name.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_DisplayName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 75);
            panel2.TabIndex = 5;
            // 
            // txt_DisplayName
            // 
            txt_DisplayName.Location = new Point(144, 30);
            txt_DisplayName.Name = "txt_DisplayName";
            txt_DisplayName.Size = new Size(266, 27);
            txt_DisplayName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txt_Password);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(432, 75);
            panel3.TabIndex = 6;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(144, 30);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(266, 27);
            txt_Password.TabIndex = 4;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 30);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txt_NewPassword);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 252);
            panel4.Name = "panel4";
            panel4.Size = new Size(432, 75);
            panel4.TabIndex = 7;
            // 
            // txt_NewPassword
            // 
            txt_NewPassword.Location = new Point(144, 30);
            txt_NewPassword.Name = "txt_NewPassword";
            txt_NewPassword.Size = new Size(266, 27);
            txt_NewPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 30);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu mới:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txt_ReEnterPass);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 333);
            panel5.Name = "panel5";
            panel5.Size = new Size(432, 75);
            panel5.TabIndex = 7;
            // 
            // txt_ReEnterPass
            // 
            txt_ReEnterPass.Location = new Point(144, 30);
            txt_ReEnterPass.Name = "txt_ReEnterPass";
            txt_ReEnterPass.Size = new Size(266, 27);
            txt_ReEnterPass.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 30);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 3;
            label5.Text = "Xác nhận mật khẩu:";
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(230, 428);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(94, 29);
            btn_Update.TabIndex = 8;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Exitt
            // 
            btn_Exitt.Location = new Point(350, 428);
            btn_Exitt.Name = "btn_Exitt";
            btn_Exitt.Size = new Size(94, 29);
            btn_Exitt.TabIndex = 9;
            btn_Exitt.Text = "Thoát";
            btn_Exitt.UseVisualStyleBackColor = true;
            btn_Exitt.Click += btn_Exitt_Click;
            // 
            // AccountProfile
            // 
            AcceptButton = btn_Update;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Exitt;
            ClientSize = new Size(481, 484);
            Controls.Add(btn_Exitt);
            Controls.Add(btn_Update);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_name;
        private Label label1;
        private Panel panel2;
        private TextBox txt_DisplayName;
        private Label label2;
        private Panel panel3;
        private TextBox txt_Password;
        private Label label3;
        private Panel panel4;
        private TextBox txt_NewPassword;
        private Label label4;
        private Panel panel5;
        private TextBox txt_ReEnterPass;
        private Label label5;
        private Button btn_Update;
        private Button btn_Exitt;
    }
}