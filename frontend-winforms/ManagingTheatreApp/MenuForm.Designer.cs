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
            exit_btn = new Button();
            hall_btn = new Button();
            stat_btn = new Button();
            spec_btn = new Button();
            rep_btn = new Button();
            SuspendLayout();
            // 
            // exit_btn
            // 
            exit_btn.Font = new Font("Times New Roman", 12F);
            exit_btn.Location = new Point(553, 310);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(94, 29);
            exit_btn.TabIndex = 0;
            exit_btn.Text = "Выйти";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // hall_btn
            // 
            hall_btn.Font = new Font("Times New Roman", 12F);
            hall_btn.Location = new Point(201, 188);
            hall_btn.Name = "hall_btn";
            hall_btn.Size = new Size(246, 29);
            hall_btn.TabIndex = 4;
            hall_btn.Text = "Настройка зала";
            hall_btn.UseVisualStyleBackColor = true;
            // 
            // stat_btn
            // 
            stat_btn.Font = new Font("Times New Roman", 12F);
            stat_btn.Location = new Point(201, 242);
            stat_btn.Name = "stat_btn";
            stat_btn.Size = new Size(246, 29);
            stat_btn.TabIndex = 5;
            stat_btn.Text = "Статистика";
            stat_btn.UseVisualStyleBackColor = true;
            // 
            // spec_btn
            // 
            spec_btn.Font = new Font("Times New Roman", 12F);
            spec_btn.Location = new Point(201, 74);
            spec_btn.Name = "spec_btn";
            spec_btn.Size = new Size(246, 29);
            spec_btn.TabIndex = 1;
            spec_btn.Text = "Управление спектаклями";
            spec_btn.UseVisualStyleBackColor = true;
            spec_btn.Click += spec_btn_Click;
            // 
            // rep_btn
            // 
            rep_btn.Font = new Font("Times New Roman", 12F);
            rep_btn.Location = new Point(201, 129);
            rep_btn.Name = "rep_btn";
            rep_btn.Size = new Size(246, 29);
            rep_btn.TabIndex = 2;
            rep_btn.Text = "Управление репертуаром";
            rep_btn.UseVisualStyleBackColor = true;
            rep_btn.Click += rep_btn_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 362);
            Controls.Add(stat_btn);
            Controls.Add(hall_btn);
            Controls.Add(rep_btn);
            Controls.Add(spec_btn);
            Controls.Add(exit_btn);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            ResumeLayout(false);
        }

        #endregion

        private Button exit_btn;
        private Button hall_btn;
        private Button stat_btn;
        private Button spec_btn;
        private Button rep_btn;
    }
}