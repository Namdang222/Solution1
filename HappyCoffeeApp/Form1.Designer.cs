namespace HappyCoffeeApp
{
    partial class frm_Login
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
            btn_login = new Button();
            btn_signin = new Button();
            txt_NameLogin = new TextBox();
            txt_Passlogin = new TextBox();
            label2 = new Label();
            pic_Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_Logo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 165);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(141, 278);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(155, 35);
            btn_login.TabIndex = 1;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_signin
            // 
            btn_signin.Location = new Point(360, 278);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(153, 35);
            btn_signin.TabIndex = 2;
            btn_signin.Text = "Đăng ký";
            btn_signin.UseVisualStyleBackColor = true;
            // 
            // txt_NameLogin
            // 
            txt_NameLogin.Location = new Point(220, 162);
            txt_NameLogin.Name = "txt_NameLogin";
            txt_NameLogin.Size = new Size(293, 27);
            txt_NameLogin.TabIndex = 3;
            // 
            // txt_Passlogin
            // 
            txt_Passlogin.Location = new Point(220, 208);
            txt_Passlogin.Name = "txt_Passlogin";
            txt_Passlogin.Size = new Size(293, 27);
            txt_Passlogin.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 211);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu:";
            // 
            // pic_Logo
            // 
            pic_Logo.Location = new Point(220, 26);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new Size(201, 108);
            pic_Logo.TabIndex = 6;
            pic_Logo.TabStop = false;
            pic_Logo.Click += pic_Logo_Click;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 384);
            Controls.Add(pic_Logo);
            Controls.Add(label2);
            Controls.Add(txt_Passlogin);
            Controls.Add(txt_NameLogin);
            Controls.Add(btn_signin);
            Controls.Add(btn_login);
            Controls.Add(label1);
            Name = "frm_Login";
            Text = "Login";
            Load += frm_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pic_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label label1;
        internal Button btn_login;
        internal Button btn_signin;
        internal TextBox txt_NameLogin;
        internal TextBox txt_Passlogin;
        internal Label label2;
        private PictureBox pic_Logo;
    }
}
