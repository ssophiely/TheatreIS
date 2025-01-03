namespace ManagingTheatreApp.MenuForms
{
    partial class RepertoireForm
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
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            rep_table = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            spec = new DataGridViewTextBoxColumn();
            box = new DataGridViewTextBoxColumn();
            rate = new DataGridViewTextBoxColumn();
            acts = new DataGridViewButtonColumn();
            rep_del = new DataGridViewButtonColumn();
            add_spectacle = new GroupBox();
            specs = new CheckedListBox();
            dateTimePicker1 = new DateTimePicker();
            add_rep = new Button();
            label7 = new Label();
            hours = new NumericUpDown();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            Close = new Button();
            groupBox1 = new GroupBox();
            add_act = new Button();
            numericUpDown2 = new NumericUpDown();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label6 = new Label();
            label8 = new Label();
            acts_table = new DataGridView();
            label9 = new Label();
            role_id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            spec_id = new DataGridViewTextBoxColumn();
            act_del = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)rep_table).BeginInit();
            add_spectacle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hours).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)acts_table).BeginInit();
            SuspendLayout();
            // 
            // rep_table
            // 
            rep_table.AllowUserToAddRows = false;
            rep_table.AllowUserToDeleteRows = false;
            rep_table.AllowUserToOrderColumns = true;
            rep_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rep_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            rep_table.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            rep_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            rep_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rep_table.Columns.AddRange(new DataGridViewColumn[] { Id, date, spec, box, rate, acts, rep_del });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            rep_table.DefaultCellStyle = dataGridViewCellStyle8;
            rep_table.GridColor = Color.DimGray;
            rep_table.Location = new Point(12, 12);
            rep_table.Name = "rep_table";
            rep_table.ReadOnly = true;
            rep_table.RowHeadersVisible = false;
            rep_table.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rep_table.RowsDefaultCellStyle = dataGridViewCellStyle9;
            rep_table.Size = new Size(974, 125);
            rep_table.TabIndex = 5;
            rep_table.CellContentClick += rep_table_CellContentClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 80;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            date.DefaultCellStyle = dataGridViewCellStyle2;
            date.HeaderText = "Дата";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 120;
            // 
            // spec
            // 
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            spec.DefaultCellStyle = dataGridViewCellStyle3;
            spec.HeaderText = "Спектакль";
            spec.MinimumWidth = 6;
            spec.Name = "spec";
            spec.ReadOnly = true;
            // 
            // box
            // 
            box.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            box.DefaultCellStyle = dataGridViewCellStyle4;
            box.HeaderText = "Кассовый сбор";
            box.MinimumWidth = 6;
            box.Name = "box";
            box.ReadOnly = true;
            box.Resizable = DataGridViewTriState.False;
            box.Width = 180;
            // 
            // rate
            // 
            rate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rate.DefaultCellStyle = dataGridViewCellStyle5;
            rate.HeaderText = "Рейтинг";
            rate.MinimumWidth = 6;
            rate.Name = "rate";
            rate.ReadOnly = true;
            rate.Resizable = DataGridViewTriState.False;
            rate.SortMode = DataGridViewColumnSortMode.NotSortable;
            rate.Width = 125;
            // 
            // acts
            // 
            acts.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.LightBlue;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.NullValue = "Открыть";
            dataGridViewCellStyle6.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            acts.DefaultCellStyle = dataGridViewCellStyle6;
            acts.FlatStyle = FlatStyle.Popup;
            acts.HeaderText = "Показы";
            acts.MinimumWidth = 6;
            acts.Name = "acts";
            acts.ReadOnly = true;
            acts.Width = 80;
            // 
            // rep_del
            // 
            rep_del.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.LightBlue;
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.NullValue = "Удалить";
            dataGridViewCellStyle7.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            rep_del.DefaultCellStyle = dataGridViewCellStyle7;
            rep_del.FlatStyle = FlatStyle.Popup;
            rep_del.HeaderText = "";
            rep_del.MinimumWidth = 6;
            rep_del.Name = "rep_del";
            rep_del.ReadOnly = true;
            rep_del.Width = 80;
            // 
            // add_spectacle
            // 
            add_spectacle.Controls.Add(specs);
            add_spectacle.Controls.Add(dateTimePicker1);
            add_spectacle.Controls.Add(add_rep);
            add_spectacle.Controls.Add(label7);
            add_spectacle.Controls.Add(hours);
            add_spectacle.Controls.Add(label5);
            add_spectacle.Controls.Add(label3);
            add_spectacle.Controls.Add(label4);
            add_spectacle.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add_spectacle.Location = new Point(12, 308);
            add_spectacle.Name = "add_spectacle";
            add_spectacle.Size = new Size(600, 207);
            add_spectacle.TabIndex = 9;
            add_spectacle.TabStop = false;
            add_spectacle.Text = "Создать репертуар";
            // 
            // specs
            // 
            specs.Location = new Point(95, 75);
            specs.Name = "specs";
            specs.Size = new Size(499, 92);
            specs.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(95, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 29;
            // 
            // add_rep
            // 
            add_rep.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            add_rep.BackColor = Color.LightBlue;
            add_rep.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add_rep.ForeColor = Color.Black;
            add_rep.Location = new Point(491, 170);
            add_rep.Name = "add_rep";
            add_rep.Size = new Size(103, 31);
            add_rep.TabIndex = 28;
            add_rep.Text = "Создать";
            add_rep.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F);
            label7.Location = new Point(647, 274);
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
            hours.Location = new Point(566, 266);
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
            label5.Location = new Point(412, 268);
            label5.Name = "label5";
            label5.Size = new Size(138, 17);
            label5.TabIndex = 16;
            label5.Text = "Продолжительность:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F);
            label3.Location = new Point(15, 44);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 10;
            label3.Text = "Дата:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F);
            label4.Location = new Point(12, 88);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 9;
            label4.Text = "Спектакли:";
            // 
            // Close
            // 
            Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F);
            Close.ForeColor = Color.White;
            Close.Location = new Point(850, 519);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 10;
            Close.Text = "Меню";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(add_act);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(618, 308);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 207);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить показ";
            // 
            // add_act
            // 
            add_act.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            add_act.BackColor = Color.LightBlue;
            add_act.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add_act.ForeColor = Color.Black;
            add_act.Location = new Point(242, 170);
            add_act.Name = "add_act";
            add_act.Size = new Size(103, 31);
            add_act.TabIndex = 31;
            add_act.Text = "Добавить";
            add_act.UseVisualStyleBackColor = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(165, 102);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(180, 27);
            numericUpDown2.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(95, 36);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 29;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F);
            label1.Location = new Point(717, 327);
            label1.Name = "label1";
            label1.Size = new Size(16, 17);
            label1.TabIndex = 18;
            label1.Text = "ч";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Right;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Font = new Font("Times New Roman", 9F);
            numericUpDown1.Location = new Point(636, 319);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(75, 25);
            numericUpDown1.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F);
            label2.Location = new Point(482, 321);
            label2.Name = "label2";
            label2.Size = new Size(138, 17);
            label2.TabIndex = 16;
            label2.Text = "Продолжительность:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F);
            label6.Location = new Point(15, 44);
            label6.Name = "label6";
            label6.Size = new Size(42, 17);
            label6.TabIndex = 10;
            label6.Text = "Дата:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F);
            label8.Location = new Point(15, 106);
            label8.Name = "label8";
            label8.Size = new Size(101, 17);
            label8.TabIndex = 9;
            label8.Text = "ID репертуара:";
            // 
            // acts_table
            // 
            acts_table.AllowUserToAddRows = false;
            acts_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            acts_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            acts_table.BackgroundColor = Color.White;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            acts_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            acts_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            acts_table.Columns.AddRange(new DataGridViewColumn[] { role_id, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn7, spec_id, act_del });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.White;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            acts_table.DefaultCellStyle = dataGridViewCellStyle14;
            acts_table.GridColor = Color.DimGray;
            acts_table.Location = new Point(12, 179);
            acts_table.Name = "acts_table";
            acts_table.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            acts_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            acts_table.RowHeadersVisible = false;
            acts_table.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            acts_table.RowsDefaultCellStyle = dataGridViewCellStyle16;
            acts_table.Size = new Size(974, 110);
            acts_table.TabIndex = 33;
            acts_table.CellContentClick += acts_table_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F);
            label9.Location = new Point(12, 157);
            label9.Name = "label9";
            label9.Size = new Size(63, 19);
            label9.TabIndex = 32;
            label9.Text = "Показы";
            // 
            // role_id
            // 
            role_id.HeaderText = "Id";
            role_id.MinimumWidth = 6;
            role_id.Name = "role_id";
            role_id.ReadOnly = true;
            role_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTextBoxColumn4.FillWeight = 150F;
            dataGridViewTextBoxColumn4.HeaderText = "Дата";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewTextBoxColumn7.FillWeight = 300F;
            dataGridViewTextBoxColumn7.HeaderText = "Спектакль";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // spec_id
            // 
            spec_id.HeaderText = "";
            spec_id.MinimumWidth = 6;
            spec_id.Name = "spec_id";
            spec_id.ReadOnly = true;
            spec_id.Visible = false;
            // 
            // act_del
            // 
            act_del.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.LightBlue;
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dataGridViewCellStyle13.NullValue = "Удалить";
            dataGridViewCellStyle13.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            act_del.DefaultCellStyle = dataGridViewCellStyle13;
            act_del.FlatStyle = FlatStyle.Popup;
            act_del.HeaderText = "";
            act_del.MinimumWidth = 6;
            act_del.Name = "act_del";
            act_del.ReadOnly = true;
            act_del.Width = 80;
            // 
            // RepertoireForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 567);
            Controls.Add(acts_table);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(Close);
            Controls.Add(add_spectacle);
            Controls.Add(rep_table);
            Name = "RepertoireForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Репертуар";
            Load += RepertoireForm_Load;
            ((System.ComponentModel.ISupportInitialize)rep_table).EndInit();
            add_spectacle.ResumeLayout(false);
            add_spectacle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hours).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)acts_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView rep_table;
        private GroupBox add_spectacle;
        private Label label7;
        private NumericUpDown hours;
        private Label label5;
        private Label label3;
        private Label label4;
        private Button Close;
        private Button add_rep;
        private DateTimePicker dateTimePicker1;
        private CheckedListBox specs;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label6;
        private Label label8;
        private Button add_act;
        private NumericUpDown numericUpDown2;
        private DataGridView acts_table;
        private Label label9;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn spec;
        private DataGridViewTextBoxColumn box;
        private DataGridViewTextBoxColumn rate;
        private DataGridViewButtonColumn acts;
        private DataGridViewButtonColumn rep_del;
        private DataGridViewTextBoxColumn role_id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn spec_id;
        private DataGridViewButtonColumn act_del;
    }
}