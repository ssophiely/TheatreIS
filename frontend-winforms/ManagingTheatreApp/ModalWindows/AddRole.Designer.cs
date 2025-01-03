namespace ManagingTheatreApp.ModalWindows
{
    partial class AddRole
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
            label2 = new Label();
            label1 = new Label();
            add_btn = new Button();
            role = new TextBox();
            emps = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.Location = new Point(27, 117);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 11;
            label2.Text = "Роль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 10;
            label1.Text = "Сотрудник";
            // 
            // add_btn
            // 
            add_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            add_btn.BackColor = Color.Black;
            add_btn.Font = new Font("Times New Roman", 12F);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(440, 196);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(136, 36);
            add_btn.TabIndex = 9;
            add_btn.Text = "OK";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // role
            // 
            role.Location = new Point(149, 114);
            role.Name = "role";
            role.Size = new Size(427, 27);
            role.TabIndex = 8;
            // 
            // emps
            // 
            emps.FormattingEnabled = true;
            emps.Location = new Point(149, 22);
            emps.Name = "emps";
            emps.Size = new Size(427, 28);
            emps.TabIndex = 7;
            // 
            // AddRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 255);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(add_btn);
            Controls.Add(role);
            Controls.Add(emps);
            Name = "AddRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить роль";
            Load += AddRole_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button add_btn;
        private TextBox role;
        private ComboBox emps;
    }
}