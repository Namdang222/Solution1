namespace HappyCoffeeApp
{
    partial class Login
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
            pic_logo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txt_Namelogin = new TextBox();
            txt_Passlogin = new TextBox();
            btn_login = new Button();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            SuspendLayout();
            // 
            // pic_logo
            // 
            pic_logo.Location = new Point(262, 12);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(213, 130);
            pic_logo.TabIndex = 0;
            pic_logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 174);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 211);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // txt_Namelogin
            // 
            txt_Namelogin.Location = new Point(296, 171);
            txt_Namelogin.Name = "txt_Namelogin";
            txt_Namelogin.Size = new Size(214, 27);
            txt_Namelogin.TabIndex = 3;
            // 
            // txt_Passlogin
            // 
            txt_Passlogin.Location = new Point(296, 211);
            txt_Passlogin.Name = "txt_Passlogin";
            txt_Passlogin.PasswordChar = '*';
            txt_Passlogin.Size = new Size(214, 27);
            txt_Passlogin.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(296, 266);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 5;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(416, 266);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 29);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Login
            // 
            AcceptButton = btn_login;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_exit;
            ClientSize = new Size(704, 378);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(txt_Passlogin);
            Controls.Add(txt_Namelogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pic_logo);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_logo;
        private Label label1;
        private Label label2;
        private TextBox txt_Namelogin;
        private TextBox txt_Passlogin;
        private Button btn_login;
        private Button btn_exit;
    }
}