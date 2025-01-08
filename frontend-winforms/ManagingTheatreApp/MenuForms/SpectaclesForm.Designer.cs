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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            Close = new Button();
            spec_dataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            spec_name = new DataGridViewTextBoxColumn();
            duration = new DataGridViewTextBoxColumn();
            genre = new DataGridViewComboBoxColumn();
            plot = new DataGridViewTextBoxColumn();
            roles = new DataGridViewButtonColumn();
            role_add = new DataGridViewButtonColumn();
            update = new DataGridViewButtonColumn();
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
            role_id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            EmpId = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            sp_id = new DataGridViewTextBoxColumn();
            role_change = new DataGridViewButtonColumn();
            role_del = new DataGridViewButtonColumn();
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
            Close.Location = new Point(930, 679);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 3;
            Close.Text = "Меню";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
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
            spec_dataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, spec_name, duration, genre, plot, roles, role_add, update, delete });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            spec_dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            spec_dataGridView.GridColor = Color.DimGray;
            spec_dataGridView.Location = new Point(12, 32);
            spec_dataGridView.Name = "spec_dataGridView";
            spec_dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            spec_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            spec_dataGridView.Size = new Size(1054, 201);
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
            dataGridViewCellStyle4.BackColor = Color.LightBlue;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.NullValue = "Открыть";
            dataGridViewCellStyle4.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            roles.DefaultCellStyle = dataGridViewCellStyle4;
            roles.FlatStyle = FlatStyle.Popup;
            roles.HeaderText = "Роли";
            roles.MinimumWidth = 6;
            roles.Name = "roles";
            roles.Text = "Открыть";
            roles.Width = 80;
            // 
            // role_add
            // 
            role_add.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.LightBlue;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.NullValue = "Добавить";
            dataGridViewCellStyle5.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            role_add.DefaultCellStyle = dataGridViewCellStyle5;
            role_add.FlatStyle = FlatStyle.Popup;
            role_add.HeaderText = "Роли";
            role_add.MinimumWidth = 6;
            role_add.Name = "role_add";
            role_add.Width = 80;
            // 
            // update
            // 
            update.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.LightBlue;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.NullValue = "Изменить";
            dataGridViewCellStyle6.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            update.DefaultCellStyle = dataGridViewCellStyle6;
            update.FlatStyle = FlatStyle.Popup;
            update.HeaderText = "";
            update.MinimumWidth = 6;
            update.Name = "update";
            update.Resizable = DataGridViewTriState.True;
            update.SortMode = DataGridViewColumnSortMode.Automatic;
            update.Text = "Изменить";
            update.Width = 90;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.LightBlue;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.NullValue = "Удалить";
            dataGridViewCellStyle7.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            delete.DefaultCellStyle = dataGridViewCellStyle7;
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
            label2.Location = new Point(12, 246);
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
            add_spectacle.Location = new Point(12, 393);
            add_spectacle.Name = "add_spectacle";
            add_spectacle.Size = new Size(1054, 288);
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
            create_btn.Location = new Point(11, 251);
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            all_emps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            all_emps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            all_emps.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            all_emps.BackgroundColor = Color.White;
            all_emps.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            all_emps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            all_emps.ColumnHeadersHeight = 25;
            all_emps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            all_emps.Columns.AddRange(new DataGridViewColumn[] { emp_id, dataGridViewTextBoxColumn5, Exp, Phone, dataGridViewTextBoxColumn6, emp_add });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            all_emps.DefaultCellStyle = dataGridViewCellStyle15;
            all_emps.Location = new Point(504, 163);
            all_emps.Name = "all_emps";
            all_emps.ReadOnly = true;
            all_emps.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            all_emps.RowHeadersVisible = false;
            all_emps.RowHeadersWidth = 70;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new Font("Times New Roman", 7.8F);
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            all_emps.RowsDefaultCellStyle = dataGridViewCellStyle16;
            all_emps.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            all_emps.RowTemplate.Height = 50;
            all_emps.ShowCellToolTips = false;
            all_emps.Size = new Size(544, 119);
            all_emps.TabIndex = 28;
            all_emps.CellContentClick += all_emps_CellContentClick;
            // 
            // emp_id
            // 
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = null;
            emp_id.DefaultCellStyle = dataGridViewCellStyle12;
            emp_id.HeaderText = "ID";
            emp_id.MinimumWidth = 6;
            emp_id.Name = "emp_id";
            emp_id.ReadOnly = true;
            emp_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.SelectionBackColor = Color.White;
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.LightBlue;
            dataGridViewCellStyle14.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            emp_add.DefaultCellStyle = dataGridViewCellStyle14;
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
            spec_emps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            spec_emps.Anchor = AnchorStyles.Right;
            spec_emps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            spec_emps.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            spec_emps.BackgroundColor = Color.White;
            spec_emps.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            spec_emps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            spec_emps.ColumnHeadersHeight = 25;
            spec_emps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            spec_emps.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn8, role, emp_del });
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = SystemColors.Window;
            dataGridViewCellStyle20.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = Color.White;
            dataGridViewCellStyle20.SelectionForeColor = Color.Black;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            spec_emps.DefaultCellStyle = dataGridViewCellStyle20;
            spec_emps.Location = new Point(504, 25);
            spec_emps.MultiSelect = false;
            spec_emps.Name = "spec_emps";
            spec_emps.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            spec_emps.RowHeadersVisible = false;
            spec_emps.RowHeadersWidth = 70;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Font = new Font("Times New Roman", 7.8F);
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            spec_emps.RowsDefaultCellStyle = dataGridViewCellStyle21;
            spec_emps.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            spec_emps.RowTemplate.Height = 50;
            spec_emps.ShowCellToolTips = false;
            spec_emps.Size = new Size(544, 94);
            spec_emps.TabIndex = 27;
            spec_emps.CellContentClick += spec_emps_CellContentClick;
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
            dataGridViewTextBoxColumn9.Width = 49;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.SelectionBackColor = Color.White;
            dataGridViewCellStyle18.SelectionForeColor = Color.Black;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle18;
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
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = Color.LightBlue;
            dataGridViewCellStyle19.ForeColor = Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle19.SelectionForeColor = Color.Black;
            emp_del.DefaultCellStyle = dataGridViewCellStyle19;
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
            spec_genre.Location = new Point(125, 74);
            spec_genre.Name = "spec_genre";
            spec_genre.Size = new Size(349, 25);
            spec_genre.TabIndex = 22;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F);
            label6.Location = new Point(11, 74);
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
            label7.Location = new Point(247, 221);
            label7.Name = "label7";
            label7.Size = new Size(16, 17);
            label7.TabIndex = 18;
            label7.Text = "ч";
            // 
            // hours
            // 
            hours.Anchor = AnchorStyles.Right;
            hours.Font = new Font("Times New Roman", 9F);
            hours.Location = new Point(166, 213);
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
            label5.Location = new Point(12, 215);
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
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.Control;
            dataGridViewCellStyle22.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle22.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            roles_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            roles_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roles_dataGridView.Columns.AddRange(new DataGridViewColumn[] { role_id, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, EmpId, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, sp_id, role_change, role_del });
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = SystemColors.Window;
            dataGridViewCellStyle29.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle29.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = Color.White;
            dataGridViewCellStyle29.SelectionForeColor = Color.Black;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.False;
            roles_dataGridView.DefaultCellStyle = dataGridViewCellStyle29;
            roles_dataGridView.GridColor = Color.DimGray;
            roles_dataGridView.Location = new Point(12, 268);
            roles_dataGridView.Name = "roles_dataGridView";
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = SystemColors.Control;
            dataGridViewCellStyle30.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle30.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = DataGridViewTriState.True;
            roles_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            roles_dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle31.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            roles_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle31;
            roles_dataGridView.Size = new Size(1054, 98);
            roles_dataGridView.TabIndex = 9;
            roles_dataGridView.CellContentClick += roles_dataGridView_CellContentClick;
            // 
            // role_id
            // 
            role_id.HeaderText = "Id";
            role_id.MinimumWidth = 6;
            role_id.Name = "role_id";
            role_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewTextBoxColumn1.FillWeight = 150F;
            dataGridViewTextBoxColumn1.HeaderText = "Название";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewTextBoxColumn2.FillWeight = 150F;
            dataGridViewTextBoxColumn2.HeaderText = "Сотрудник";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // EmpId
            // 
            EmpId.HeaderText = "";
            EmpId.MinimumWidth = 6;
            EmpId.Name = "EmpId";
            EmpId.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewTextBoxColumn3.HeaderText = "Должность";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle26;
            dataGridViewTextBoxColumn4.FillWeight = 150F;
            dataGridViewTextBoxColumn4.HeaderText = "Спектакль";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // sp_id
            // 
            sp_id.HeaderText = "";
            sp_id.MinimumWidth = 6;
            sp_id.Name = "sp_id";
            sp_id.Visible = false;
            // 
            // role_change
            // 
            role_change.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = Color.LightBlue;
            dataGridViewCellStyle27.ForeColor = Color.Black;
            dataGridViewCellStyle27.NullValue = "Изменить";
            dataGridViewCellStyle27.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle27.SelectionForeColor = Color.Black;
            role_change.DefaultCellStyle = dataGridViewCellStyle27;
            role_change.FlatStyle = FlatStyle.Popup;
            role_change.HeaderText = "";
            role_change.MinimumWidth = 6;
            role_change.Name = "role_change";
            role_change.Resizable = DataGridViewTriState.True;
            role_change.SortMode = DataGridViewColumnSortMode.Automatic;
            role_change.Width = 80;
            // 
            // role_del
            // 
            role_del.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = Color.LightBlue;
            dataGridViewCellStyle28.ForeColor = Color.Black;
            dataGridViewCellStyle28.NullValue = "Удалить";
            dataGridViewCellStyle28.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle28.SelectionForeColor = Color.Black;
            role_del.DefaultCellStyle = dataGridViewCellStyle28;
            role_del.FlatStyle = FlatStyle.Popup;
            role_del.HeaderText = "";
            role_del.MinimumWidth = 6;
            role_del.Name = "role_del";
            role_del.Width = 80;
            // 
            // SpectaclesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 718);
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
        private Button create_btn;
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn spec_name;
        private DataGridViewTextBoxColumn duration;
        private DataGridViewComboBoxColumn genre;
        private DataGridViewTextBoxColumn plot;
        private DataGridViewButtonColumn roles;
        private DataGridViewButtonColumn role_add;
        private DataGridViewButtonColumn update;
        private DataGridViewButtonColumn delete;
        private DataGridViewTextBoxColumn role_id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn EmpId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn sp_id;
        private DataGridViewButtonColumn role_change;
        private DataGridViewButtonColumn role_del;
    }
}