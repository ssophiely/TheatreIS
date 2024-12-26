namespace TheTheatre
{
    partial class ShowEdit
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            label1 = new Label();
            name_tb = new TextBox();
            descriptiont_tb = new TextBox();
            label5 = new Label();
            hall_cb = new ComboBox();
            label3 = new Label();
            Change = new Button();
            maxpr = new NumericUpDown();
            minpr = new NumericUpDown();
            label9 = new Label();
            label2 = new Label();
            label8 = new Label();
            m_nud = new NumericUpDown();
            label7 = new Label();
            h_nud = new NumericUpDown();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            allworkers_t = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            inshow_t = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)maxpr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minpr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)m_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)h_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allworkers_t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inshow_t).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 4;
            label1.Text = "Название:";
            // 
            // name_tb
            // 
            name_tb.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            name_tb.Location = new Point(239, 19);
            name_tb.Name = "name_tb";
            name_tb.Size = new Size(877, 25);
            name_tb.TabIndex = 5;
            name_tb.TabStop = false;
            // 
            // descriptiont_tb
            // 
            descriptiont_tb.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            descriptiont_tb.Location = new Point(239, 160);
            descriptiont_tb.Multiline = true;
            descriptiont_tb.Name = "descriptiont_tb";
            descriptiont_tb.ScrollBars = ScrollBars.Vertical;
            descriptiont_tb.Size = new Size(877, 76);
            descriptiont_tb.TabIndex = 11;
            descriptiont_tb.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 179);
            label5.Name = "label5";
            label5.Size = new Size(83, 17);
            label5.TabIndex = 10;
            label5.Text = "Описание:";
            // 
            // hall_cb
            // 
            hall_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            hall_cb.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hall_cb.FormattingEnabled = true;
            hall_cb.Items.AddRange(new object[] { "Малый", "Большой" });
            hall_cb.Location = new Point(239, 260);
            hall_cb.Name = "hall_cb";
            hall_cb.Size = new Size(334, 25);
            hall_cb.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 262);
            label3.Name = "label3";
            label3.Size = new Size(36, 17);
            label3.TabIndex = 14;
            label3.Text = "Зал:";
            // 
            // Change
            // 
            Change.BackColor = Color.Black;
            Change.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Change.ForeColor = Color.White;
            Change.Location = new Point(980, 467);
            Change.Name = "Change";
            Change.Size = new Size(136, 36);
            Change.TabIndex = 18;
            Change.Text = "Изменить";
            Change.UseVisualStyleBackColor = false;
            // 
            // maxpr
            // 
            maxpr.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maxpr.Location = new Point(824, 118);
            maxpr.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            maxpr.Name = "maxpr";
            maxpr.Size = new Size(122, 25);
            maxpr.TabIndex = 28;
            // 
            // minpr
            // 
            minpr.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            minpr.Location = new Point(239, 118);
            minpr.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            minpr.Name = "minpr";
            minpr.Size = new Size(122, 25);
            minpr.TabIndex = 27;
            // 
            // label9
            // 
            label9.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(594, 119);
            label9.Name = "label9";
            label9.Size = new Size(214, 25);
            label9.TabIndex = 26;
            label9.Text = "Максимальная цена билета:";
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 120);
            label2.Name = "label2";
            label2.Size = new Size(212, 25);
            label2.TabIndex = 25;
            label2.Text = "Минимальная цена билета:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(453, 67);
            label8.Name = "label8";
            label8.Size = new Size(36, 19);
            label8.TabIndex = 24;
            label8.Text = "мин";
            // 
            // m_nud
            // 
            m_nud.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            m_nud.Location = new Point(372, 61);
            m_nud.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            m_nud.Name = "m_nud";
            m_nud.Size = new Size(75, 25);
            m_nud.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(320, 67);
            label7.Name = "label7";
            label7.Size = new Size(18, 19);
            label7.TabIndex = 22;
            label7.Text = "ч";
            // 
            // h_nud
            // 
            h_nud.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            h_nud.Location = new Point(239, 61);
            h_nud.Name = "h_nud";
            h_nud.Size = new Size(75, 25);
            h_nud.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 67);
            label6.Name = "label6";
            label6.Size = new Size(156, 17);
            label6.TabIndex = 20;
            label6.Text = "Продолжительность:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewButtonColumn1 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(611, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 70;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.Size = new Size(478, 150);
            dataGridView1.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTextBoxColumn2.FillWeight = 320F;
            dataGridViewTextBoxColumn2.HeaderText = "Участник";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Plum;
            dataGridViewCellStyle4.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewButtonColumn1.FillWeight = 70F;
            dataGridViewButtonColumn1.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn1.HeaderText = "Удалить";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn1.Text = "Удалить";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // allworkers_t
            // 
            allworkers_t.AllowDrop = true;
            allworkers_t.AllowUserToAddRows = false;
            allworkers_t.AllowUserToDeleteRows = false;
            allworkers_t.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            allworkers_t.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            allworkers_t.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allworkers_t.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            allworkers_t.BackgroundColor = Color.FromArgb(248, 244, 255);
            allworkers_t.BorderStyle = BorderStyle.None;
            allworkers_t.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            allworkers_t.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            allworkers_t.ColumnHeadersHeight = 25;
            allworkers_t.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            allworkers_t.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewButtonColumn2 });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            allworkers_t.DefaultCellStyle = dataGridViewCellStyle12;
            allworkers_t.Location = new Point(21, 311);
            allworkers_t.Name = "allworkers_t";
            allworkers_t.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            allworkers_t.RowHeadersVisible = false;
            allworkers_t.RowHeadersWidth = 70;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            allworkers_t.RowsDefaultCellStyle = dataGridViewCellStyle13;
            allworkers_t.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            allworkers_t.RowTemplate.Height = 50;
            allworkers_t.ShowCellToolTips = false;
            allworkers_t.Size = new Size(544, 150);
            allworkers_t.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.SelectionBackColor = Color.White;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewTextBoxColumn1.DividerWidth = 1;
            dataGridViewTextBoxColumn1.FillWeight = 220F;
            dataGridViewTextBoxColumn1.HeaderText = "Имя";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DividerWidth = 1;
            dataGridViewTextBoxColumn3.FillWeight = 160F;
            dataGridViewTextBoxColumn3.HeaderText = "Должность";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTextBoxColumn4.HeaderText = "ID";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Visible = false;
            dataGridViewTextBoxColumn4.Width = 54;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewButtonColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.Plum;
            dataGridViewCellStyle11.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewButtonColumn2.DividerWidth = 1;
            dataGridViewButtonColumn2.FillWeight = 120F;
            dataGridViewButtonColumn2.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn2.HeaderText = "";
            dataGridViewButtonColumn2.MinimumWidth = 6;
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            dataGridViewButtonColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn2.Text = "Добавить роль";
            dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // inshow_t
            // 
            inshow_t.AllowDrop = true;
            inshow_t.AllowUserToAddRows = false;
            inshow_t.AllowUserToDeleteRows = false;
            inshow_t.AllowUserToOrderColumns = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            inshow_t.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            inshow_t.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            inshow_t.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            inshow_t.BackgroundColor = Color.FromArgb(248, 244, 255);
            inshow_t.BorderStyle = BorderStyle.None;
            inshow_t.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            inshow_t.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            inshow_t.ColumnHeadersHeight = 25;
            inshow_t.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            inshow_t.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, role, dataGridViewTextBoxColumn6, dataGridViewButtonColumn3 });
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = SystemColors.Window;
            dataGridViewCellStyle19.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            inshow_t.DefaultCellStyle = dataGridViewCellStyle19;
            inshow_t.Location = new Point(594, 311);
            inshow_t.Name = "inshow_t";
            inshow_t.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            inshow_t.RowHeadersVisible = false;
            inshow_t.RowHeadersWidth = 70;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            inshow_t.RowsDefaultCellStyle = dataGridViewCellStyle20;
            inshow_t.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            inshow_t.RowTemplate.Height = 50;
            inshow_t.ShowCellToolTips = false;
            inshow_t.Size = new Size(522, 150);
            inshow_t.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.SelectionBackColor = Color.White;
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewTextBoxColumn5.DividerWidth = 1;
            dataGridViewTextBoxColumn5.FillWeight = 180F;
            dataGridViewTextBoxColumn5.HeaderText = "Участник";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // role
            // 
            role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            role.DividerWidth = 1;
            role.FillWeight = 200F;
            role.HeaderText = "Роль";
            role.MinimumWidth = 6;
            role.Name = "role";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewTextBoxColumn6.HeaderText = "ID";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Visible = false;
            dataGridViewTextBoxColumn6.Width = 54;
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = Color.Plum;
            dataGridViewCellStyle18.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle18.SelectionForeColor = Color.Black;
            dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewButtonColumn3.DividerWidth = 1;
            dataGridViewButtonColumn3.FillWeight = 80F;
            dataGridViewButtonColumn3.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn3.HeaderText = "";
            dataGridViewButtonColumn3.MinimumWidth = 6;
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            dataGridViewButtonColumn3.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn3.Text = "Удалить";
            dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            // 
            // ShowEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1137, 513);
            Controls.Add(allworkers_t);
            Controls.Add(inshow_t);
            Controls.Add(dataGridView1);
            Controls.Add(maxpr);
            Controls.Add(minpr);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(m_nud);
            Controls.Add(label7);
            Controls.Add(h_nud);
            Controls.Add(label6);
            Controls.Add(Change);
            Controls.Add(label3);
            Controls.Add(hall_cb);
            Controls.Add(descriptiont_tb);
            Controls.Add(label5);
            Controls.Add(name_tb);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(1155, 560);
            MinimizeBox = false;
            MinimumSize = new Size(1155, 560);
            Name = "ShowEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение данных о спектакле";
            ((System.ComponentModel.ISupportInitialize)maxpr).EndInit();
            ((System.ComponentModel.ISupportInitialize)minpr).EndInit();
            ((System.ComponentModel.ISupportInitialize)m_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)h_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)allworkers_t).EndInit();
            ((System.ComponentModel.ISupportInitialize)inshow_t).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name_tb;
        private TextBox descriptiont_tb;
        private Label label5;
        private ComboBox hall_cb;
        private Label label3;
        private Button Change;
        private NumericUpDown maxpr;
        private NumericUpDown minpr;
        private Label label9;
        private Label label2;
        private Label label8;
        private NumericUpDown m_nud;
        private Label label7;
        private NumericUpDown h_nud;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridView allworkers_t;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridView inshow_t;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
    }
}