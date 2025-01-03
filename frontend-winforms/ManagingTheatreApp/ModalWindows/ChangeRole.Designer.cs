namespace ManagingTheatreApp.ModalWindows
{
    partial class ChangeRole
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
            emps = new ComboBox();
            role = new TextBox();
            change_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // emps
            // 
            emps.FormattingEnabled = true;
            emps.Location = new Point(155, 33);
            emps.Name = "emps";
            emps.Size = new Size(427, 28);
            emps.TabIndex = 0;
            // 
            // role
            // 
            role.Location = new Point(155, 125);
            role.Name = "role";
            role.Size = new Size(427, 27);
            role.TabIndex = 1;
            // 
            // change_btn
            // 
            change_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            change_btn.BackColor = Color.Black;
            change_btn.Font = new Font("Times New Roman", 12F);
            change_btn.ForeColor = Color.White;
            change_btn.Location = new Point(446, 207);
            change_btn.Name = "change_btn";
            change_btn.Size = new Size(136, 36);
            change_btn.TabIndex = 4;
            change_btn.Text = "OK";
            change_btn.UseVisualStyleBackColor = false;
            change_btn.Click += change_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 5;
            label1.Text = "Сотрудник";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.Location = new Point(33, 128);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 6;
            label2.Text = "Роль";
            // 
            // ChangeRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 255);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(change_btn);
            Controls.Add(role);
            Controls.Add(emps);
            Name = "ChangeRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменить роль";
            Load += ChangeRole_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox emps;
        private TextBox role;
        private Button change_btn;
        private Label label1;
        private Label label2;
    }
}