namespace ManagingTheatreApp.MenuForms
{
    partial class StatisticsForm
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            tickets_table = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            Menu = new Button();
            box_table = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tickets_table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)box_table).BeginInit();
            SuspendLayout();
            // 
            // tickets_table
            // 
            tickets_table.AllowUserToAddRows = false;
            tickets_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tickets_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tickets_table.BackgroundColor = Color.White;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            tickets_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            tickets_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tickets_table.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn7 });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Window;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle16.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = Color.White;
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            tickets_table.DefaultCellStyle = dataGridViewCellStyle16;
            tickets_table.GridColor = Color.DimGray;
            tickets_table.Location = new Point(12, 242);
            tickets_table.Name = "tickets_table";
            tickets_table.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.Control;
            dataGridViewCellStyle17.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            tickets_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            tickets_table.RowHeadersVisible = false;
            tickets_table.RowHeadersWidth = 51;
            dataGridViewCellStyle18.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tickets_table.RowsDefaultCellStyle = dataGridViewCellStyle18;
            tickets_table.Size = new Size(881, 201);
            tickets_table.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewTextBoxColumn4.FillWeight = 150F;
            dataGridViewTextBoxColumn4.HeaderText = "Дата";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTextBoxColumn7.FillWeight = 300F;
            dataGridViewTextBoxColumn7.HeaderText = "Число проданных билетов";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Menu
            // 
            Menu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Menu.BackColor = Color.Black;
            Menu.Font = new Font("Times New Roman", 12F);
            Menu.ForeColor = Color.White;
            Menu.Location = new Point(757, 480);
            Menu.Name = "Menu";
            Menu.Size = new Size(136, 36);
            Menu.TabIndex = 35;
            Menu.Text = "Меню";
            Menu.UseVisualStyleBackColor = false;
            Menu.Click += Menu_Click;
            // 
            // box_table
            // 
            box_table.AllowUserToAddRows = false;
            box_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            box_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            box_table.BackgroundColor = Color.White;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = SystemColors.Control;
            dataGridViewCellStyle19.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            box_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            box_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            box_table.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.Window;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle22.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = Color.White;
            dataGridViewCellStyle22.SelectionForeColor = Color.Black;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.False;
            box_table.DefaultCellStyle = dataGridViewCellStyle22;
            box_table.GridColor = Color.DimGray;
            box_table.Location = new Point(12, 12);
            box_table.Name = "box_table";
            box_table.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = SystemColors.Control;
            dataGridViewCellStyle23.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle23.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            box_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            box_table.RowHeadersVisible = false;
            box_table.RowHeadersWidth = 51;
            dataGridViewCellStyle24.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            box_table.RowsDefaultCellStyle = dataGridViewCellStyle24;
            box_table.Size = new Size(881, 201);
            box_table.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewTextBoxColumn1.FillWeight = 150F;
            dataGridViewTextBoxColumn1.HeaderText = "Спектакль";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewTextBoxColumn2.FillWeight = 300F;
            dataGridViewTextBoxColumn2.HeaderText = "Кассовые сборы за текущий год";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 528);
            Controls.Add(box_table);
            Controls.Add(Menu);
            Controls.Add(tickets_table);
            Name = "StatisticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            Load += StatisticsForm_Load;
            ((System.ComponentModel.ISupportInitialize)tickets_table).EndInit();
            ((System.ComponentModel.ISupportInitialize)box_table).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView tickets_table;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Button Menu;
        private DataGridView box_table;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}