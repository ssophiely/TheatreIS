namespace TheTheatre
{
    partial class ShowView
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
            sh_name = new Label();
            label1 = new Label();
            duration = new Label();
            label3 = new Label();
            label5 = new Label();
            description = new TextBox();
            roles = new TextBox();
            label4 = new Label();
            label6 = new Label();
            hall = new Label();
            Close = new Button();
            view_hall = new Button();
            minprice = new Label();
            label9 = new Label();
            maxprice = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // sh_name
            // 
            sh_name.AutoSize = true;
            sh_name.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            sh_name.Location = new Point(217, 33);
            sh_name.Name = "sh_name";
            sh_name.Size = new Size(51, 19);
            sh_name.TabIndex = 4;
            sh_name.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 3;
            label1.Text = "Название:";
            // 
            // duration
            // 
            duration.AutoSize = true;
            duration.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            duration.Location = new Point(217, 75);
            duration.Name = "duration";
            duration.Size = new Size(51, 19);
            duration.TabIndex = 6;
            duration.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 75);
            label3.Name = "label3";
            label3.Size = new Size(175, 19);
            label3.TabIndex = 5;
            label3.Text = "Продолжительность:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 124);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 7;
            label5.Text = "Описание:";
            // 
            // description
            // 
            description.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            description.Location = new Point(217, 124);
            description.Multiline = true;
            description.Name = "description";
            description.ScrollBars = ScrollBars.Vertical;
            description.Size = new Size(772, 59);
            description.TabIndex = 9;
            description.TabStop = false;
            // 
            // roles
            // 
            roles.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            roles.Location = new Point(217, 205);
            roles.Multiline = true;
            roles.Name = "roles";
            roles.ScrollBars = ScrollBars.Vertical;
            roles.Size = new Size(772, 172);
            roles.TabIndex = 11;
            roles.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 205);
            label4.Name = "label4";
            label4.Size = new Size(157, 19);
            label4.TabIndex = 10;
            label4.Text = "Участники и роли:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 400);
            label6.Name = "label6";
            label6.Size = new Size(42, 19);
            label6.TabIndex = 12;
            label6.Text = "Зал:";
            // 
            // hall
            // 
            hall.AutoSize = true;
            hall.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            hall.Location = new Point(217, 400);
            hall.Name = "hall";
            hall.Size = new Size(51, 19);
            hall.TabIndex = 13;
            hall.Text = "label3";
            // 
            // Close
            // 
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Close.ForeColor = Color.White;
            Close.Location = new Point(853, 422);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 14;
            Close.Text = "Закрыть";
            Close.UseVisualStyleBackColor = false;
            // 
            // view_hall
            // 
            view_hall.BackColor = Color.Gray;
            view_hall.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            view_hall.ForeColor = Color.White;
            view_hall.Location = new Point(692, 422);
            view_hall.Name = "view_hall";
            view_hall.Size = new Size(155, 36);
            view_hall.TabIndex = 15;
            view_hall.Text = "Посмотреть зал";
            view_hall.UseVisualStyleBackColor = false;
            // 
            // minprice
            // 
            minprice.AutoSize = true;
            minprice.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            minprice.Location = new Point(862, 33);
            minprice.Name = "minprice";
            minprice.Size = new Size(51, 19);
            minprice.TabIndex = 17;
            minprice.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(617, 33);
            label9.Name = "label9";
            label9.Size = new Size(224, 19);
            label9.TabIndex = 16;
            label9.Text = "Минимальная цена билета:";
            // 
            // maxprice
            // 
            maxprice.AutoSize = true;
            maxprice.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            maxprice.Location = new Point(862, 75);
            maxprice.Name = "maxprice";
            maxprice.Size = new Size(60, 19);
            maxprice.TabIndex = 19;
            maxprice.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(617, 75);
            label11.Name = "label11";
            label11.Size = new Size(230, 19);
            label11.TabIndex = 18;
            label11.Text = "Максимальная цена билета:";
            // 
            // ShowView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1001, 470);
            Controls.Add(maxprice);
            Controls.Add(label11);
            Controls.Add(minprice);
            Controls.Add(label9);
            Controls.Add(view_hall);
            Controls.Add(Close);
            Controls.Add(hall);
            Controls.Add(label6);
            Controls.Add(roles);
            Controls.Add(label4);
            Controls.Add(description);
            Controls.Add(label5);
            Controls.Add(duration);
            Controls.Add(label3);
            Controls.Add(sh_name);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(1019, 517);
            MinimizeBox = false;
            MinimumSize = new Size(1019, 517);
            Name = "ShowView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о спектакле";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sh_name;
        private Label label1;
        private Label duration;
        private Label label3;
        private Label label5;
        private TextBox description;
        private TextBox roles;
        private Label label4;
        private Label label6;
        private Label hall;
        private Button Close;
        private Button view_hall;
        private Label minprice;
        private Label label9;
        private Label maxprice;
        private Label label11;
    }
}