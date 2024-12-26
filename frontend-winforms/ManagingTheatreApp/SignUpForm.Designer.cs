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
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F);
            linkLabel1.Location = new Point(454, 305);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(64, 22);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Войти";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F);
            button1.Location = new Point(331, 244);
            button1.Name = "button1";
            button1.Size = new Size(187, 29);
            button1.TabIndex = 10;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F);
            textBox2.Location = new Point(292, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 30);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F);
            textBox1.Location = new Point(292, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 30);
            textBox1.TabIndex = 8;
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
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 12F);
            textBox3.Location = new Point(292, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(226, 30);
            textBox3.TabIndex = 13;
            textBox3.TextChanged += textBox3_TextChanged;
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
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private Label label3;
    }
}