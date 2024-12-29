namespace ManagingTheatreApp
{
    partial class SignInForm
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
            login = new TextBox();
            password = new TextBox();
            signin_btn = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(159, 66);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(159, 135);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // login
            // 
            login.Font = new Font("Times New Roman", 12F);
            login.Location = new Point(257, 63);
            login.Name = "login";
            login.Size = new Size(226, 30);
            login.TabIndex = 2;
            // 
            // password
            // 
            password.Font = new Font("Times New Roman", 12F);
            password.Location = new Point(257, 132);
            password.Name = "password";
            password.Size = new Size(226, 30);
            password.TabIndex = 3;
            password.UseSystemPasswordChar = true;
            // 
            // signin_btn
            // 
            signin_btn.Font = new Font("Times New Roman", 12F);
            signin_btn.Location = new Point(335, 210);
            signin_btn.Name = "signin_btn";
            signin_btn.Size = new Size(148, 29);
            signin_btn.TabIndex = 4;
            signin_btn.Text = "Войти";
            signin_btn.UseVisualStyleBackColor = true;
            signin_btn.Click += signin_btn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F);
            linkLabel1.Location = new Point(291, 267);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(192, 22);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Пройти регистрацию";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 362);
            Controls.Add(linkLabel1);
            Controls.Add(signin_btn);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox login;
        private TextBox password;
        private Button signin_btn;
        private LinkLabel linkLabel1;
    }
}
