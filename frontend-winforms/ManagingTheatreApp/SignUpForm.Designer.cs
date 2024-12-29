namespace ManagingTheatreApp
{
    partial class SignUpForm
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
            linkLabel1 = new LinkLabel();
            signup_btn = new Button();
            password = new TextBox();
            login = new TextBox();
            label2 = new Label();
            label1 = new Label();
            password2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F);
            linkLabel1.Location = new Point(454, 299);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(64, 22);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Войти";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // signup_btn
            // 
            signup_btn.Font = new Font("Times New Roman", 12F);
            signup_btn.Location = new Point(331, 244);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(187, 29);
            signup_btn.TabIndex = 10;
            signup_btn.Text = "Зарегистрироваться";
            signup_btn.UseVisualStyleBackColor = true;
            signup_btn.Click += signup_btn_Click;
            // 
            // password
            // 
            password.Font = new Font("Times New Roman", 12F);
            password.Location = new Point(292, 110);
            password.Name = "password";
            password.Size = new Size(226, 30);
            password.TabIndex = 9;
            password.UseSystemPasswordChar = true;
            // 
            // login
            // 
            login.Font = new Font("Times New Roman", 12F);
            login.Location = new Point(292, 41);
            login.Name = "login";
            login.Size = new Size(226, 30);
            login.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(194, 113);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 7;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(194, 44);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 6;
            label1.Text = "Логин";
            // 
            // password2
            // 
            password2.Font = new Font("Times New Roman", 12F);
            password2.Location = new Point(292, 179);
            password2.Name = "password2";
            password2.Size = new Size(226, 30);
            password2.TabIndex = 13;
            password2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(83, 182);
            label3.Name = "label3";
            label3.Size = new Size(183, 22);
            label3.TabIndex = 12;
            label3.Text = "Подтвердите пароль";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 362);
            Controls.Add(password2);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(signup_btn);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button signup_btn;
        private TextBox password;
        private TextBox login;
        private Label label2;
        private Label label1;
        private TextBox password2;
        private Label label3;
    }
}