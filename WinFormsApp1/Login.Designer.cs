namespace WinFormsApp1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_name = new TextBox();
            txt_password = new TextBox();
            btn_Login = new Button();
            pic_logo = new PictureBox();
            btn_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 134);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 179);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(313, 131);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(266, 27);
            txt_name.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(313, 179);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(266, 27);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(170, 229);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(143, 42);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += this.btn_Login_Click;
            // 
            // pic_logo
            // 
            pic_logo.Location = new Point(300, 28);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(125, 97);
            pic_logo.TabIndex = 6;
            pic_logo.TabStop = false;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(412, 229);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(157, 44);
            btn_Exit.TabIndex = 7;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Login
            // 
            AcceptButton = btn_Login;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Exit;
            ClientSize = new Size(714, 316);
            Controls.Add(btn_Exit);
            Controls.Add(pic_logo);
            Controls.Add(btn_Login);
            Controls.Add(txt_password);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_name;
        private TextBox txt_password;
        private Button btn_Login;
        private PictureBox pic_logo;
        private Button btn_Exit;
    }
}
