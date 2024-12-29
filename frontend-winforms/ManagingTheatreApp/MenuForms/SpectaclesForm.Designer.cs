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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            Close = new Button();
            spec_dataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            spec_name = new DataGridViewTextBoxColumn();
            duration = new DataGridViewTextBoxColumn();
            genre = new DataGridViewComboBoxColumn();
            plot = new DataGridViewTextBoxColumn();
            roles = new DataGridViewButtonColumn();
            change = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            spec_add_groupBox = new GroupBox();
            allworkers_t = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            inshow_t = new DataGridView();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            hall_cb = new ComboBox();
            label6 = new Label();
            label8 = new Label();
            minutes_nud = new NumericUpDown();
            label7 = new Label();
            hour_nud = new NumericUpDown();
            label5 = new Label();
            description_tb = new TextBox();
            show_name = new TextBox();
            label3 = new Label();
            label4 = new Label();
            roles_dataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)spec_dataGridView).BeginInit();
            spec_add_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allworkers_t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inshow_t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutes_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hour_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roles_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Close
            // 
            Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F);
            Close.ForeColor = Color.White;
            Close.Location = new Point(930, 667);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 3;
            Close.Text = "Меню";
            Close.UseVisualStyleBackColor = false;
            // 
            // spec_dataGridView
            // 
            spec_dataGridView.AllowUserToAddRows = false;
            spec_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            spec_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            spec_dataGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            spec_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            spec_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            spec_dataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, spec_name, duration, genre, plot, roles, change, delete });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            spec_dataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            spec_dataGridView.GridColor = Color.DimGray;
            spec_dataGridView.Location = new Point(12, 32);
            spec_dataGridView.Name = "spec_dataGridView";
            spec_dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            spec_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            spec_dataGridView.Size = new Size(1054, 181);
            spec_dataGridView.TabIndex = 4;
            spec_dataGridView.CellContentClick += spec_dataGridView_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // spec_name
            // 
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            spec_name.DefaultCellStyle = dataGridViewCellStyle2;
            spec_name.FillWeight = 120F;
            spec_name.HeaderText = "Название";
            spec_name.MinimumWidth = 6;
            spec_name.Name = "spec_name";
            // 
            // duration
            // 
            duration.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            duration.HeaderText = "Время";
            duration.MinimumWidth = 6;
            duration.Name = "duration";
            duration.Width = 88;
            // 
            // genre
            // 
            genre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            genre.HeaderText = "Жанр";
            genre.MinimumWidth = 6;
            genre.Name = "genre";
            genre.Resizable = DataGridViewTriState.True;
            genre.SortMode = DataGridViewColumnSortMode.Automatic;
            genre.Width = 81;
            // 
            // plot
            // 
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            plot.DefaultCellStyle = dataGridViewCellStyle3;
            plot.FillWeight = 150F;
            plot.HeaderText = "Сюжет";
            plot.MinimumWidth = 6;
            plot.Name = "plot";
            // 
            // roles
            // 
            roles.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.NullValue = "Открыть";
            roles.DefaultCellStyle = dataGridViewCellStyle4;
            roles.FlatStyle = FlatStyle.Popup;
            roles.HeaderText = "Роли";
            roles.MinimumWidth = 6;
            roles.Name = "roles";
            roles.Text = "Открыть";
            roles.Width = 80;
            // 
            // change
            // 
            change.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.NullValue = "Изменить";
            change.DefaultCellStyle = dataGridViewCellStyle5;
            change.FlatStyle = FlatStyle.Popup;
            change.HeaderText = "";
            change.MinimumWidth = 6;
            change.Name = "change";
            change.Text = "Изменить";
            change.Width = 80;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.NullValue = "Удалить";
            delete.DefaultCellStyle = dataGridViewCellStyle6;
            delete.FlatStyle = FlatStyle.Popup;
            delete.HeaderText = "";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Text = "Удалить";
            delete.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 5;
            label1.Text = "Спектакли";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.Location = new Point(12, 228);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 6;
            label2.Text = "Роли";
            // 
            // spec_add_groupBox
            // 
            spec_add_groupBox.Controls.Add(allworkers_t);
            spec_add_groupBox.Controls.Add(inshow_t);
            spec_add_groupBox.Controls.Add(hall_cb);
            spec_add_groupBox.Controls.Add(label6);
            spec_add_groupBox.Controls.Add(label8);
            spec_add_groupBox.Controls.Add(minutes_nud);
            spec_add_groupBox.Controls.Add(label7);
            spec_add_groupBox.Controls.Add(hour_nud);
            spec_add_groupBox.Controls.Add(label5);
            spec_add_groupBox.Controls.Add(description_tb);
            spec_add_groupBox.Controls.Add(show_name);
            spec_add_groupBox.Controls.Add(label3);
            spec_add_groupBox.Controls.Add(label4);
            spec_add_groupBox.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            spec_add_groupBox.Location = new Point(12, 426);
            spec_add_groupBox.Name = "spec_add_groupBox";
            spec_add_groupBox.Size = new Size(1054, 235);
            spec_add_groupBox.TabIndex = 8;
            spec_add_groupBox.TabStop = false;
            spec_add_groupBox.Text = "Добавить спектакль";
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
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            allworkers_t.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            allworkers_t.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allworkers_t.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            allworkers_t.BackgroundColor = Color.White;
            allworkers_t.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            allworkers_t.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            allworkers_t.ColumnHeadersHeight = 25;
            allworkers_t.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            allworkers_t.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewButtonColumn1 });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            allworkers_t.DefaultCellStyle = dataGridViewCellStyle14;
            allworkers_t.Location = new Point(504, 130);
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
            allworkers_t.Size = new Size(544, 97);
            allworkers_t.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.SelectionBackColor = Color.White;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTextBoxColumn5.DividerWidth = 1;
            dataGridViewTextBoxColumn5.FillWeight = 220F;
            dataGridViewTextBoxColumn5.HeaderText = "Имя";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.DividerWidth = 1;
            dataGridViewTextBoxColumn6.FillWeight = 160F;
            dataGridViewTextBoxColumn6.HeaderText = "Должность";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewTextBoxColumn7.HeaderText = "ID";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Visible = false;
            dataGridViewTextBoxColumn7.Width = 54;
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
            inshow_t.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            inshow_t.Anchor = AnchorStyles.Right;
            inshow_t.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            inshow_t.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            inshow_t.BackgroundColor = Color.White;
            inshow_t.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            inshow_t.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            inshow_t.ColumnHeadersHeight = 25;
            inshow_t.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            inshow_t.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn8, role, dataGridViewTextBoxColumn9, dataGridViewButtonColumn3 });
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = SystemColors.Window;
            dataGridViewCellStyle19.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            inshow_t.DefaultCellStyle = dataGridViewCellStyle19;
            inshow_t.Location = new Point(504, 16);
            inshow_t.Name = "inshow_t";
            inshow_t.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            inshow_t.RowHeadersVisible = false;
            inshow_t.RowHeadersWidth = 70;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new Font("Times New Roman", 7.8F);
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            inshow_t.RowsDefaultCellStyle = dataGridViewCellStyle20;
            inshow_t.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            inshow_t.RowTemplate.Height = 50;
            inshow_t.ShowCellToolTips = false;
            inshow_t.Size = new Size(544, 94);
            inshow_t.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.SelectionBackColor = Color.White;
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewTextBoxColumn8.DividerWidth = 1;
            dataGridViewTextBoxColumn8.FillWeight = 180F;
            dataGridViewTextBoxColumn8.HeaderText = "Участник";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
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
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewTextBoxColumn9.HeaderText = "ID";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Visible = false;
            dataGridViewTextBoxColumn9.Width = 54;
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
            // hall_cb
            // 
            hall_cb.Anchor = AnchorStyles.Right;
            hall_cb.BackColor = Color.White;
            hall_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            hall_cb.Font = new Font("Times New Roman", 9F);
            hall_cb.FormattingEnabled = true;
            hall_cb.Items.AddRange(new object[] { "Малый", "Большой" });
            hall_cb.Location = new Point(125, 75);
            hall_cb.Name = "hall_cb";
            hall_cb.Size = new Size(349, 25);
            hall_cb.TabIndex = 22;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F);
            label6.Location = new Point(11, 75);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 21;
            label6.Text = "Жанр:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F);
            label8.Location = new Point(379, 210);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 20;
            label8.Text = "мин";
            // 
            // minutes_nud
            // 
            minutes_nud.Anchor = AnchorStyles.Right;
            minutes_nud.Font = new Font("Times New Roman", 9F);
            minutes_nud.Location = new Point(298, 204);
            minutes_nud.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minutes_nud.Name = "minutes_nud";
            minutes_nud.Size = new Size(75, 25);
            minutes_nud.TabIndex = 19;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F);
            label7.Location = new Point(248, 210);
            label7.Name = "label7";
            label7.Size = new Size(16, 17);
            label7.TabIndex = 18;
            label7.Text = "ч";
            // 
            // hour_nud
            // 
            hour_nud.Anchor = AnchorStyles.Right;
            hour_nud.Font = new Font("Times New Roman", 9F);
            hour_nud.Location = new Point(167, 202);
            hour_nud.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            hour_nud.Name = "hour_nud";
            hour_nud.Size = new Size(75, 25);
            hour_nud.TabIndex = 17;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F);
            label5.Location = new Point(13, 204);
            label5.Name = "label5";
            label5.Size = new Size(138, 17);
            label5.TabIndex = 16;
            label5.Text = "Продолжительность:";
            // 
            // description_tb
            // 
            description_tb.Font = new Font("Times New Roman", 9F);
            description_tb.Location = new Point(125, 119);
            description_tb.Multiline = true;
            description_tb.Name = "description_tb";
            description_tb.ScrollBars = ScrollBars.Vertical;
            description_tb.Size = new Size(349, 77);
            description_tb.TabIndex = 12;
            // 
            // show_name
            // 
            show_name.Font = new Font("Times New Roman", 9F);
            show_name.Location = new Point(125, 37);
            show_name.Name = "show_name";
            show_name.Size = new Size(349, 25);
            show_name.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F);
            label3.Location = new Point(11, 130);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 10;
            label3.Text = "Сюжет:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F);
            label4.Location = new Point(11, 38);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 9;
            label4.Text = "Название:";
            // 
            // roles_dataGridView
            // 
            roles_dataGridView.AllowUserToAddRows = false;
            roles_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roles_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            roles_dataGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = SystemColors.Control;
            dataGridViewCellStyle21.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle21.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            roles_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            roles_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roles_dataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            roles_dataGridView.GridColor = SystemColors.HighlightText;
            roles_dataGridView.Location = new Point(12, 250);
            roles_dataGridView.Name = "roles_dataGridView";
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = SystemColors.Control;
            dataGridViewCellStyle26.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle26.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
            roles_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            roles_dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle27.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle27.SelectionBackColor = Color.White;
            dataGridViewCellStyle27.SelectionForeColor = Color.Black;
            roles_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle27;
            roles_dataGridView.Size = new Size(1054, 152);
            roles_dataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewTextBoxColumn1.FillWeight = 150F;
            dataGridViewTextBoxColumn1.HeaderText = "Название";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewTextBoxColumn2.FillWeight = 150F;
            dataGridViewTextBoxColumn2.HeaderText = "Сотрудник";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewTextBoxColumn3.HeaderText = "Должность";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewTextBoxColumn4.FillWeight = 150F;
            dataGridViewTextBoxColumn4.HeaderText = "Спектакль";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // SpectaclesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 706);
            Controls.Add(roles_dataGridView);
            Controls.Add(spec_add_groupBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(spec_dataGridView);
            Controls.Add(Close);
            Name = "SpectaclesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спектакли";
            Load += SpectaclesForm_Load;
            ((System.ComponentModel.ISupportInitialize)spec_dataGridView).EndInit();
            spec_add_groupBox.ResumeLayout(false);
            spec_add_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allworkers_t).EndInit();
            ((System.ComponentModel.ISupportInitialize)inshow_t).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutes_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)hour_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)roles_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close;
        private DataGridView spec_dataGridView;
        private Label label1;
        private Label label2;
        private GroupBox spec_add_groupBox;
        private DataGridView roles_dataGridView;
        private ComboBox hall_cb;
        private Label label6;
        private Label label8;
        private NumericUpDown minutes_nud;
        private Label label7;
        private NumericUpDown hour_nud;
        private Label label5;
        private TextBox description_tb;
        private TextBox show_name;
        private Label label3;
        private Label label4;
        private DataGridView allworkers_t;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridView inshow_t;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn spec_name;
        private DataGridViewTextBoxColumn duration;
        private DataGridViewComboBoxColumn genre;
        private DataGridViewTextBoxColumn plot;
        private DataGridViewButtonColumn roles;
        private DataGridViewButtonColumn change;
        private DataGridViewButtonColumn delete;
    }
}