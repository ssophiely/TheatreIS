namespace ManagingTheatreApp
{
    partial class MenuForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F);
            button1.Location = new Point(553, 310);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Выйти";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F);
            button2.Location = new Point(223, 36);
            button2.Name = "button2";
            button2.Size = new Size(207, 29);
            button2.TabIndex = 1;
            button2.Text = "Управление спектаклями";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 12F);
            button3.Location = new Point(223, 87);
            button3.Name = "button3";
            button3.Size = new Size(207, 29);
            button3.TabIndex = 2;
            button3.Text = "Управление репертуаром";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 12F);
            button4.Location = new Point(204, 143);
            button4.Name = "button4";
            button4.Size = new Size(246, 29);
            button4.TabIndex = 3;
            button4.Text = "Управление показами";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 12F);
            button5.Location = new Point(204, 200);
            button5.Name = "button5";
            button5.Size = new Size(246, 29);
            button5.TabIndex = 4;
            button5.Text = "Настройка зала";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 12F);
            button6.Location = new Point(204, 254);
            button6.Name = "button6";
            button6.Size = new Size(246, 29);
            button6.TabIndex = 5;
            button6.Text = "Статистика";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Times New Roman", 12F);
            button7.Location = new Point(204, 34);
            button7.Name = "button7";
            button7.Size = new Size(246, 29);
            button7.TabIndex = 1;
            button7.Text = "Управление спектаклями";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Times New Roman", 12F);
            button8.Location = new Point(204, 85);
            button8.Name = "button8";
            button8.Size = new Size(246, 29);
            button8.TabIndex = 2;
            button8.Text = "Управление репертуаром";
            button8.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 362);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuForm";
            Text = "Меню";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}