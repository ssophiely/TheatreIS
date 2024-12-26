namespace TheTheatre
{
    partial class SpectaclesForm
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
            if (!ReturnForm.Visible)
            {
                ReturnForm.Close();
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            Close = new Button();
            shows_t = new DataGridView();
            Name_ = new DataGridViewTextBoxColumn();
            See = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            Del = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            allworkers_t = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            inshow_t = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            max_price = new NumericUpDown();
            min_price = new NumericUpDown();
            label9 = new Label();
            label3 = new Label();
            label8 = new Label();
            add = new Button();
            minutes_nud = new NumericUpDown();
            label7 = new Label();
            hour_nud = new NumericUpDown();
            label4 = new Label();
            hall_cb = new ComboBox();
            description_tb = new TextBox();
            show_name = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)shows_t).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allworkers_t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inshow_t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)max_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)min_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutes_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hour_nud).BeginInit();
            SuspendLayout();
            // 
            // Close
            // 
            Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F);
            Close.ForeColor = Color.White;
            Close.Location = new Point(983, 630);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 3;
            Close.Text = "Меню";
            Close.UseVisualStyleBackColor = false;
            //Close.Click += Close_Click;
            // 
            // shows_t
            // 
            shows_t.AllowDrop = true;
            shows_t.AllowUserToAddRows = false;
            shows_t.AllowUserToDeleteRows = false;
            shows_t.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            shows_t.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            shows_t.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            shows_t.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            shows_t.BackgroundColor = Color.White;
            shows_t.BorderStyle = BorderStyle.None;
            shows_t.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            shows_t.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            shows_t.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shows_t.ColumnHeadersVisible = false;
            shows_t.Columns.AddRange(new DataGridViewColumn[] { Name_, See, Edit, Del });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            shows_t.DefaultCellStyle = dataGridViewCellStyle7;
            shows_t.Dock = DockStyle.Top;
            shows_t.Location = new Point(0, 0);
            shows_t.Name = "shows_t";
            shows_t.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            shows_t.RowHeadersVisible = false;
            shows_t.RowHeadersWidth = 70;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 10.2F);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            shows_t.RowsDefaultCellStyle = dataGridViewCellStyle8;
            shows_t.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            shows_t.RowTemplate.Height = 50;
            shows_t.ShowCellToolTips = false;
            shows_t.Size = new Size(1137, 176);
            shows_t.TabIndex = 7;
            // 
            // Name_
            // 
            Name_.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Name_.DefaultCellStyle = dataGridViewCellStyle3;
            Name_.FillWeight = 320F;
            Name_.HeaderText = "Название";
            Name_.MinimumWidth = 6;
            Name_.Name = "Name_";
            Name_.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // See
            // 
            See.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.LightYellow;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            See.DefaultCellStyle = dataGridViewCellStyle4;
            See.FillWeight = 80F;
            See.FlatStyle = FlatStyle.Popup;
            See.HeaderText = "Подробнее";
            See.MinimumWidth = 6;
            See.Name = "See";
            See.Resizable = DataGridViewTriState.True;
            See.Text = "Подробнее";
            See.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Lavender;
            dataGridViewCellStyle5.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            Edit.DefaultCellStyle = dataGridViewCellStyle5;
            Edit.FillWeight = 80F;
            Edit.FlatStyle = FlatStyle.Popup;
            Edit.HeaderText = "Редактировать";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.Text = "Редактировать";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Del
            // 
            Del.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Plum;
            dataGridViewCellStyle6.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            Del.DefaultCellStyle = dataGridViewCellStyle6;
            Del.FillWeight = 70F;
            Del.FlatStyle = FlatStyle.Popup;
            Del.HeaderText = "Удалить";
            Del.MinimumWidth = 6;
            Del.Name = "Del";
            Del.Resizable = DataGridViewTriState.True;
            Del.Text = "Удалить";
            Del.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(248, 244, 255);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(max_price);
            groupBox1.Controls.Add(min_price);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(add);
            groupBox1.Controls.Add(minutes_nud);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(hour_nud);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(hall_cb);
            groupBox1.Controls.Add(description_tb);
            groupBox1.Controls.Add(show_name);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1113, 427);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить спектакль";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(allworkers_t);
            groupBox2.Controls.Add(inshow_t);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(6, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1101, 207);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавить участника спектакля";
            // 
            // allworkers_t
            // 
            allworkers_t.AllowDrop = true;
            allworkers_t.AllowUserToAddRows = false;
            allworkers_t.AllowUserToDeleteRows = false;
            allworkers_t.AllowUserToOrderColumns = true;
            allworkers_t.AllowUserToResizeColumns = false;
            allworkers_t.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            allworkers_t.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            allworkers_t.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allworkers_t.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            allworkers_t.BackgroundColor = Color.White;
            allworkers_t.BorderStyle = BorderStyle.None;
            allworkers_t.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            allworkers_t.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            allworkers_t.ColumnHeadersHeight = 25;
            allworkers_t.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            allworkers_t.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewButtonColumn1 });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            allworkers_t.DefaultCellStyle = dataGridViewCellStyle14;
            allworkers_t.Location = new Point(6, 24);
            allworkers_t.Name = "allworkers_t";
            allworkers_t.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            allworkers_t.RowHeadersVisible = false;
            allworkers_t.RowHeadersWidth = 70;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new Font("Times New Roman", 7.8F);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            allworkers_t.RowsDefaultCellStyle = dataGridViewCellStyle15;
            allworkers_t.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            allworkers_t.RowTemplate.Height = 50;
            allworkers_t.ShowCellToolTips = false;
            allworkers_t.Size = new Size(544, 175);
            allworkers_t.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.SelectionBackColor = Color.White;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTextBoxColumn2.DividerWidth = 1;
            dataGridViewTextBoxColumn2.FillWeight = 220F;
            dataGridViewTextBoxColumn2.HeaderText = "Имя";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewTextBoxColumn4.HeaderText = "ID";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Visible = false;
            dataGridViewTextBoxColumn4.Width = 54;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.Plum;
            dataGridViewCellStyle13.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewButtonColumn1.DividerWidth = 1;
            dataGridViewButtonColumn1.FillWeight = 120F;
            dataGridViewButtonColumn1.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn1.HeaderText = "";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn1.Text = "Добавить роль";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // inshow_t
            // 
            inshow_t.AllowDrop = true;
            inshow_t.AllowUserToAddRows = false;
            inshow_t.AllowUserToDeleteRows = false;
            inshow_t.AllowUserToOrderColumns = true;
            inshow_t.AllowUserToResizeColumns = false;
            inshow_t.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            inshow_t.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            inshow_t.Anchor = AnchorStyles.Right;
            inshow_t.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            inshow_t.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            inshow_t.BackgroundColor = Color.White;
            inshow_t.BorderStyle = BorderStyle.None;
            inshow_t.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = SystemColors.Control;
            dataGridViewCellStyle17.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            inshow_t.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            inshow_t.ColumnHeadersHeight = 25;
            inshow_t.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            inshow_t.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, role, dataGridViewTextBoxColumn5, dataGridViewButtonColumn3 });
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = SystemColors.Window;
            dataGridViewCellStyle21.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            inshow_t.DefaultCellStyle = dataGridViewCellStyle21;
            inshow_t.Location = new Point(606, 22);
            inshow_t.Name = "inshow_t";
            inshow_t.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            inshow_t.RowHeadersVisible = false;
            inshow_t.RowHeadersWidth = 70;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Font = new Font("Times New Roman", 7.8F);
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            inshow_t.RowsDefaultCellStyle = dataGridViewCellStyle22;
            inshow_t.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            inshow_t.RowTemplate.Height = 50;
            inshow_t.ShowCellToolTips = false;
            inshow_t.Size = new Size(489, 177);
            inshow_t.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.SelectionBackColor = Color.White;
            dataGridViewCellStyle18.SelectionForeColor = Color.Black;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewTextBoxColumn1.DividerWidth = 1;
            dataGridViewTextBoxColumn1.FillWeight = 180F;
            dataGridViewTextBoxColumn1.HeaderText = "Участник";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle19.Format = "N0";
            dataGridViewCellStyle19.NullValue = null;
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewTextBoxColumn5.HeaderText = "ID";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Visible = false;
            dataGridViewTextBoxColumn5.Width = 54;
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = Color.Plum;
            dataGridViewCellStyle20.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle20.SelectionForeColor = Color.Black;
            dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle20;
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
            // max_price
            // 
            max_price.Anchor = AnchorStyles.Right;
            max_price.Font = new Font("Times New Roman", 9F);
            max_price.Location = new Point(1000, 76);
            max_price.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            max_price.Name = "max_price";
            max_price.Size = new Size(107, 25);
            max_price.TabIndex = 19;
            // 
            // min_price
            // 
            min_price.Anchor = AnchorStyles.Right;
            min_price.Font = new Font("Times New Roman", 9F);
            min_price.Location = new Point(764, 76);
            min_price.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            min_price.Name = "min_price";
            min_price.Size = new Size(97, 25);
            min_price.TabIndex = 18;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.Font = new Font("Times New Roman", 9F);
            label9.Location = new Point(891, 73);
            label9.Name = "label9";
            label9.Size = new Size(103, 40);
            label9.TabIndex = 17;
            label9.Text = "Максимальная цена билета:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.Font = new Font("Times New Roman", 9F);
            label3.Location = new Point(634, 73);
            label3.Name = "label3";
            label3.Size = new Size(94, 37);
            label3.TabIndex = 16;
            label3.Text = "Минимальная цена билета:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F);
            label8.Location = new Point(1000, 40);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 15;
            label8.Text = "мин";
            // 
            // add
            // 
            add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            add.BackColor = Color.Violet;
            add.Font = new Font("Times New Roman", 12F);
            add.Location = new Point(971, 385);
            add.Name = "add";
            add.Size = new Size(136, 36);
            add.TabIndex = 9;
            add.Text = "Создать";
            add.UseVisualStyleBackColor = false;
            // 
            // minutes_nud
            // 
            minutes_nud.Anchor = AnchorStyles.Right;
            minutes_nud.Font = new Font("Times New Roman", 9F);
            minutes_nud.Location = new Point(919, 34);
            minutes_nud.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minutes_nud.Name = "minutes_nud";
            minutes_nud.Size = new Size(75, 25);
            minutes_nud.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F);
            label7.Location = new Point(869, 40);
            label7.Name = "label7";
            label7.Size = new Size(16, 17);
            label7.TabIndex = 13;
            label7.Text = "ч";
            // 
            // hour_nud
            // 
            hour_nud.Anchor = AnchorStyles.Right;
            hour_nud.Font = new Font("Times New Roman", 9F);
            hour_nud.Location = new Point(788, 32);
            hour_nud.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            hour_nud.Name = "hour_nud";
            hour_nud.Size = new Size(75, 25);
            hour_nud.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F);
            label4.Location = new Point(634, 34);
            label4.Name = "label4";
            label4.Size = new Size(138, 17);
            label4.TabIndex = 11;
            label4.Text = "Продолжительность:";
            // 
            // hall_cb
            // 
            hall_cb.Anchor = AnchorStyles.Right;
            hall_cb.BackColor = Color.White;
            hall_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            hall_cb.Font = new Font("Times New Roman", 9F);
            hall_cb.FormattingEnabled = true;
            hall_cb.Items.AddRange(new object[] { "Малый", "Большой" });
            hall_cb.Location = new Point(685, 125);
            hall_cb.Name = "hall_cb";
            hall_cb.Size = new Size(422, 25);
            hall_cb.TabIndex = 9;
            // 
            // description_tb
            // 
            description_tb.Font = new Font("Times New Roman", 9F);
            description_tb.Location = new Point(120, 73);
            description_tb.Multiline = true;
            description_tb.Name = "description_tb";
            description_tb.ScrollBars = ScrollBars.Vertical;
            description_tb.Size = new Size(436, 77);
            description_tb.TabIndex = 8;
            // 
            // show_name
            // 
            show_name.Font = new Font("Times New Roman", 9F);
            show_name.Location = new Point(120, 33);
            show_name.Name = "show_name";
            show_name.Size = new Size(436, 25);
            show_name.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F);
            label6.Location = new Point(634, 125);
            label6.Name = "label6";
            label6.Size = new Size(33, 17);
            label6.TabIndex = 5;
            label6.Text = "Зал:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F);
            label2.Location = new Point(6, 84);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 1;
            label2.Text = "Описание:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // SpectaclesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1137, 669);
            Controls.Add(groupBox1);
            Controls.Add(shows_t);
            Controls.Add(Close);
            Name = "SpectaclesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спектакли";
            ((System.ComponentModel.ISupportInitialize)shows_t).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allworkers_t).EndInit();
            ((System.ComponentModel.ISupportInitialize)inshow_t).EndInit();
            ((System.ComponentModel.ISupportInitialize)max_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)min_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutes_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)hour_nud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Close;
        private DataGridView shows_t;
        private GroupBox groupBox1;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox show_name;
        private TextBox description_tb;
        private ComboBox hall_cb;
        private Button add;
        private Label label4;
        private Label label8;
        private NumericUpDown minutes_nud;
        private Label label7;
        private NumericUpDown hour_nud;
        private NumericUpDown max_price;
        private NumericUpDown min_price;
        private Label label9;
        private Label label3;
        private GroupBox groupBox2;
        private DataGridView inshow_t;
        private DataGridView allworkers_t;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewTextBoxColumn Name_;
        private DataGridViewButtonColumn See;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Del;
    }
}