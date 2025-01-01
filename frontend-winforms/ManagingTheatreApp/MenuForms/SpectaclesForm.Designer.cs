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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            Close = new Button();
            spec_dataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            spec_name = new DataGridViewTextBoxColumn();
            duration = new DataGridViewTextBoxColumn();
            genre = new DataGridViewComboBoxColumn();
            plot = new DataGridViewTextBoxColumn();
            roles = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            add_spectacle = new GroupBox();
            create_btn = new Button();
            all_emps = new DataGridView();
            emp_id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Exp = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            emp_add = new DataGridViewButtonColumn();
            spec_emps = new DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            emp_del = new DataGridViewButtonColumn();
            spec_genre = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            hours = new NumericUpDown();
            label5 = new Label();
            spec_plot = new TextBox();
            name = new TextBox();
            label3 = new Label();
            label4 = new Label();
            roles_dataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)spec_dataGridView).BeginInit();
            add_spectacle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)all_emps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spec_emps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roles_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Close
            // 
            Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F);
            Close.ForeColor = Color.White;
            Close.Location = new Point(930, 694);
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
            spec_dataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, spec_name, duration, genre, plot, roles, delete });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            spec_dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            spec_dataGridView.GridColor = Color.DimGray;
            spec_dataGridView.Location = new Point(12, 32);
            spec_dataGridView.Name = "spec_dataGridView";
            spec_dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            spec_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            spec_dataGridView.Size = new Size(1054, 211);
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
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.LightBlue;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.NullValue = "Удалить";
            dataGridViewCellStyle5.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            delete.DefaultCellStyle = dataGridViewCellStyle5;
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
            label2.Location = new Point(12, 256);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 6;
            label2.Text = "Роли";
            // 
            // add_spectacle
            // 
            add_spectacle.Controls.Add(create_btn);
            add_spectacle.Controls.Add(all_emps);
            add_spectacle.Controls.Add(spec_emps);
            add_spectacle.Controls.Add(spec_genre);
            add_spectacle.Controls.Add(label6);
            add_spectacle.Controls.Add(label7);
            add_spectacle.Controls.Add(hours);
            add_spectacle.Controls.Add(label5);
            add_spectacle.Controls.Add(spec_plot);
            add_spectacle.Controls.Add(name);
            add_spectacle.Controls.Add(label3);
            add_spectacle.Controls.Add(label4);
            add_spectacle.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add_spectacle.Location = new Point(12, 391);
            add_spectacle.Name = "add_spectacle";
            add_spectacle.Size = new Size(1054, 297);
            add_spectacle.TabIndex = 8;
            add_spectacle.TabStop = false;
            add_spectacle.Text = "Добавить спектакль";
            // 
            // create_btn
            // 
            create_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            create_btn.BackColor = Color.LightBlue;
            create_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            create_btn.ForeColor = Color.Black;
            create_btn.Location = new Point(11, 260);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(130, 31);
            create_btn.TabIndex = 10;
            create_btn.Text = "Создать";
            create_btn.UseVisualStyleBackColor = false;
            create_btn.Click += create_btn_Click;
            // 
            // all_emps
            // 
            all_emps.AllowDrop = true;
            all_emps.AllowUserToAddRows = false;
            all_emps.AllowUserToDeleteRows = false;
            all_emps.AllowUserToOrderColumns = true;
            all_emps.AllowUserToResizeColumns = false;
            all_emps.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            all_emps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            all_emps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            all_emps.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            all_emps.BackgroundColor = Color.White;
            all_emps.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            all_emps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            all_emps.ColumnHeadersHeight = 25;
            all_emps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            all_emps.Columns.AddRange(new DataGridViewColumn[] { emp_id, dataGridViewTextBoxColumn5, Exp, Phone, dataGridViewTextBoxColumn6, emp_add });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            all_emps.DefaultCellStyle = dataGridViewCellStyle13;
            all_emps.Location = new Point(504, 163);
            all_emps.Name = "all_emps";
            all_emps.ReadOnly = true;
            all_emps.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            all_emps.RowHeadersVisible = false;
            all_emps.RowHeadersWidth = 70;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new Font("Times New Roman", 7.8F);
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            all_emps.RowsDefaultCellStyle = dataGridViewCellStyle14;
            all_emps.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            all_emps.RowTemplate.Height = 50;
            all_emps.ShowCellToolTips = false;
            all_emps.Size = new Size(544, 119);
            all_emps.TabIndex = 28;
            all_emps.CellContentClick += all_emps_CellContentClick;
            // 
            // emp_id
            // 
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            emp_id.DefaultCellStyle = dataGridViewCellStyle10;
            emp_id.HeaderText = "ID";
            emp_id.MinimumWidth = 6;
            emp_id.Name = "emp_id";
            emp_id.ReadOnly = true;
            emp_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.SelectionBackColor = Color.White;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTextBoxColumn5.DividerWidth = 1;
            dataGridViewTextBoxColumn5.FillWeight = 300F;
            dataGridViewTextBoxColumn5.HeaderText = "Имя";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Exp
            // 
            Exp.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Exp.HeaderText = "Стаж";
            Exp.MinimumWidth = 6;
            Exp.Name = "Exp";
            Exp.ReadOnly = true;
            Exp.Width = 67;
            // 
            // Phone
            // 
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Phone.HeaderText = "Телефон";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 85;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DividerWidth = 1;
            dataGridViewTextBoxColumn6.FillWeight = 160F;
            dataGridViewTextBoxColumn6.HeaderText = "Должность";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // emp_add
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.LightBlue;
            dataGridViewCellStyle12.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            emp_add.DefaultCellStyle = dataGridViewCellStyle12;
            emp_add.DividerWidth = 1;
            emp_add.FillWeight = 120F;
            emp_add.FlatStyle = FlatStyle.Popup;
            emp_add.HeaderText = "";
            emp_add.MinimumWidth = 6;
            emp_add.Name = "emp_add";
            emp_add.ReadOnly = true;
            emp_add.Resizable = DataGridViewTriState.True;
            emp_add.Text = "Добавить";
            emp_add.UseColumnTextForButtonValue = true;
            // 
            // spec_emps
            // 
            spec_emps.AllowDrop = true;
            spec_emps.AllowUserToAddRows = false;
            spec_emps.AllowUserToDeleteRows = false;
            spec_emps.AllowUserToOrderColumns = true;
            spec_emps.AllowUserToResizeColumns = false;
            spec_emps.AllowUserToResizeRows = false;
            spec_emps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            spec_emps.Anchor = AnchorStyles.Right;
            spec_emps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            spec_emps.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            spec_emps.BackgroundColor = Color.White;
            spec_emps.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            spec_emps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            spec_emps.ColumnHeadersHeight = 25;
            spec_emps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            spec_emps.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn8, role, emp_del });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = SystemColors.Window;
            dataGridViewCellStyle18.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = Color.White;
            dataGridViewCellStyle18.SelectionForeColor = Color.Black;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            spec_emps.DefaultCellStyle = dataGridViewCellStyle18;
            spec_emps.Location = new Point(504, 29);
            spec_emps.MultiSelect = false;
            spec_emps.Name = "spec_emps";
            spec_emps.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            spec_emps.RowHeadersVisible = false;
            spec_emps.RowHeadersWidth = 70;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new Font("Times New Roman", 7.8F);
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            spec_emps.RowsDefaultCellStyle = dataGridViewCellStyle19;
            spec_emps.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            spec_emps.RowTemplate.Height = 50;
            spec_emps.ShowCellToolTips = false;
            spec_emps.Size = new Size(544, 94);
            spec_emps.TabIndex = 27;
            spec_emps.CellContentClick += spec_emps_CellContentClick;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewCellStyle15.Format = "N0";
            dataGridViewCellStyle15.NullValue = null;
            dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTextBoxColumn9.HeaderText = "ID";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Visible = false;
            dataGridViewTextBoxColumn9.Width = 49;
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
            // emp_del
            // 
            emp_del.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.LightBlue;
            dataGridViewCellStyle17.ForeColor = Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle17.SelectionForeColor = Color.Black;
            emp_del.DefaultCellStyle = dataGridViewCellStyle17;
            emp_del.DividerWidth = 1;
            emp_del.FillWeight = 80F;
            emp_del.FlatStyle = FlatStyle.Popup;
            emp_del.HeaderText = "";
            emp_del.MinimumWidth = 6;
            emp_del.Name = "emp_del";
            emp_del.ReadOnly = true;
            emp_del.Resizable = DataGridViewTriState.True;
            emp_del.Text = "Удалить";
            emp_del.UseColumnTextForButtonValue = true;
            // 
            // spec_genre
            // 
            spec_genre.Anchor = AnchorStyles.Right;
            spec_genre.BackColor = Color.White;
            spec_genre.DropDownStyle = ComboBoxStyle.DropDownList;
            spec_genre.Font = new Font("Times New Roman", 9F);
            spec_genre.FormattingEnabled = true;
            spec_genre.Items.AddRange(new object[] { "Малый", "Большой" });
            spec_genre.Location = new Point(125, 78);
            spec_genre.Name = "spec_genre";
            spec_genre.Size = new Size(349, 25);
            spec_genre.TabIndex = 22;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F);
            label6.Location = new Point(11, 78);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 21;
            label6.Text = "Жанр:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F);
            label7.Location = new Point(247, 225);
            label7.Name = "label7";
            label7.Size = new Size(16, 17);
            label7.TabIndex = 18;
            label7.Text = "ч";
            // 
            // hours
            // 
            hours.Anchor = AnchorStyles.Right;
            hours.DecimalPlaces = 2;
            hours.Font = new Font("Times New Roman", 9F);
            hours.Location = new Point(166, 217);
            hours.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            hours.Name = "hours";
            hours.Size = new Size(75, 25);
            hours.TabIndex = 17;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F);
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(138, 17);
            label5.TabIndex = 16;
            label5.Text = "Продолжительность:";
            // 
            // spec_plot
            // 
            spec_plot.Font = new Font("Times New Roman", 9F);
            spec_plot.Location = new Point(125, 119);
            spec_plot.Multiline = true;
            spec_plot.Name = "spec_plot";
            spec_plot.ScrollBars = ScrollBars.Vertical;
            spec_plot.Size = new Size(349, 77);
            spec_plot.TabIndex = 12;
            // 
            // name
            // 
            name.Font = new Font("Times New Roman", 9F);
            name.Location = new Point(125, 37);
            name.Name = "name";
            name.Size = new Size(349, 25);
            name.TabIndex = 11;
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
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Control;
            dataGridViewCellStyle20.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle20.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            roles_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            roles_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roles_dataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            roles_dataGridView.GridColor = Color.DimGray;
            roles_dataGridView.Location = new Point(12, 278);
            roles_dataGridView.Name = "roles_dataGridView";
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = SystemColors.Control;
            dataGridViewCellStyle25.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle25.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            roles_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            roles_dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle26.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle26.SelectionBackColor = Color.White;
            dataGridViewCellStyle26.SelectionForeColor = Color.Black;
            roles_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle26;
            roles_dataGridView.Size = new Size(1054, 107);
            roles_dataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewTextBoxColumn1.FillWeight = 150F;
            dataGridViewTextBoxColumn1.HeaderText = "Название";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewTextBoxColumn2.FillWeight = 150F;
            dataGridViewTextBoxColumn2.HeaderText = "Сотрудник";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewTextBoxColumn3.HeaderText = "Должность";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle24;
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
            ClientSize = new Size(1084, 733);
            Controls.Add(roles_dataGridView);
            Controls.Add(add_spectacle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(spec_dataGridView);
            Controls.Add(Close);
            Name = "SpectaclesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спектакли";
            Load += SpectaclesForm_Load;
            ((System.ComponentModel.ISupportInitialize)spec_dataGridView).EndInit();
            add_spectacle.ResumeLayout(false);
            add_spectacle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)all_emps).EndInit();
            ((System.ComponentModel.ISupportInitialize)spec_emps).EndInit();
            ((System.ComponentModel.ISupportInitialize)hours).EndInit();
            ((System.ComponentModel.ISupportInitialize)roles_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close;
        private DataGridView spec_dataGridView;
        private Label label1;
        private Label label2;
        private GroupBox add_spectacle;
        private DataGridView roles_dataGridView;
        private ComboBox spec_genre;
        private Label label6;
        private Label label7;
        private NumericUpDown hours;
        private Label label5;
        private TextBox spec_plot;
        private TextBox name;
        private Label label3;
        private Label label4;
        private DataGridView all_emps;
        private DataGridView spec_emps;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button create_btn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn spec_name;
        private DataGridViewTextBoxColumn duration;
        private DataGridViewComboBoxColumn genre;
        private DataGridViewTextBoxColumn plot;
        private DataGridViewButtonColumn roles;
        private DataGridViewButtonColumn delete;
        private DataGridViewTextBoxColumn emp_id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Exp;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn emp_add;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn role;
        private DataGridViewButtonColumn emp_del;
    }
}