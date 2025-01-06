namespace ManagingTheatreApp.MenuForms
{
    partial class LocationForm
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
            loc_table = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            spec = new DataGridViewTextBoxColumn();
            box = new DataGridViewTextBoxColumn();
            rate = new DataGridViewTextBoxColumn();
            acts = new DataGridViewTextBoxColumn();
            change = new DataGridViewCheckBoxColumn();
            act_id = new NumericUpDown();
            label8 = new Label();
            locations_btn = new Button();
            Close = new Button();
            price_btn = new Button();
            price = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)loc_table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)act_id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price).BeginInit();
            SuspendLayout();
            // 
            // loc_table
            // 
            loc_table.AllowUserToAddRows = false;
            loc_table.AllowUserToDeleteRows = false;
            loc_table.AllowUserToOrderColumns = true;
            loc_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            loc_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            loc_table.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            loc_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            loc_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loc_table.Columns.AddRange(new DataGridViewColumn[] { Id, date, spec, box, rate, acts, change });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            loc_table.DefaultCellStyle = dataGridViewCellStyle8;
            loc_table.GridColor = Color.DimGray;
            loc_table.Location = new Point(12, 98);
            loc_table.Name = "loc_table";
            loc_table.RowHeadersVisible = false;
            loc_table.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loc_table.RowsDefaultCellStyle = dataGridViewCellStyle9;
            loc_table.Size = new Size(999, 355);
            loc_table.TabIndex = 6;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 80;
            // 
            // date
            // 
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            date.DefaultCellStyle = dataGridViewCellStyle2;
            date.HeaderText = "Ряд";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // spec
            // 
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            spec.DefaultCellStyle = dataGridViewCellStyle3;
            spec.HeaderText = "Место";
            spec.MinimumWidth = 6;
            spec.Name = "spec";
            spec.ReadOnly = true;
            // 
            // box
            // 
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            box.DefaultCellStyle = dataGridViewCellStyle4;
            box.FillWeight = 150F;
            box.HeaderText = "Сектор";
            box.MinimumWidth = 6;
            box.Name = "box";
            box.ReadOnly = true;
            box.Resizable = DataGridViewTriState.False;
            // 
            // rate
            // 
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rate.DefaultCellStyle = dataGridViewCellStyle5;
            rate.FillWeight = 150F;
            rate.HeaderText = "Цена";
            rate.MinimumWidth = 6;
            rate.Name = "rate";
            rate.ReadOnly = true;
            rate.Resizable = DataGridViewTriState.False;
            rate.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // acts
            // 
            dataGridViewCellStyle6.NullValue = "Открыть";
            acts.DefaultCellStyle = dataGridViewCellStyle6;
            acts.FillWeight = 150F;
            acts.HeaderText = "Состояние";
            acts.MinimumWidth = 6;
            acts.Name = "acts";
            acts.ReadOnly = true;
            acts.Resizable = DataGridViewTriState.True;
            acts.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // change
            // 
            change.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.LightBlue;
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.NullValue = false;
            dataGridViewCellStyle7.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            change.DefaultCellStyle = dataGridViewCellStyle7;
            change.HeaderText = "";
            change.MinimumWidth = 6;
            change.Name = "change";
            change.Resizable = DataGridViewTriState.True;
            change.Width = 50;
            // 
            // act_id
            // 
            act_id.Location = new Point(122, 27);
            act_id.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            act_id.Name = "act_id";
            act_id.Size = new Size(163, 27);
            act_id.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(21, 30);
            label8.Name = "label8";
            label8.Size = new Size(81, 19);
            label8.TabIndex = 31;
            label8.Text = "ID показа:";
            // 
            // locations_btn
            // 
            locations_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            locations_btn.BackColor = Color.LightBlue;
            locations_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            locations_btn.ForeColor = Color.Black;
            locations_btn.Location = new Point(309, 24);
            locations_btn.Name = "locations_btn";
            locations_btn.Size = new Size(103, 31);
            locations_btn.TabIndex = 33;
            locations_btn.Text = "Открыть";
            locations_btn.UseVisualStyleBackColor = false;
            locations_btn.Click += locations_btn_Click;
            // 
            // Close
            // 
            Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F);
            Close.ForeColor = Color.White;
            Close.Location = new Point(875, 466);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 34;
            Close.Text = "Меню";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // price_btn
            // 
            price_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            price_btn.BackColor = Color.LightBlue;
            price_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            price_btn.ForeColor = Color.Black;
            price_btn.Location = new Point(853, 24);
            price_btn.Name = "price_btn";
            price_btn.Size = new Size(103, 31);
            price_btn.TabIndex = 37;
            price_btn.Text = "ОК";
            price_btn.UseVisualStyleBackColor = false;
            price_btn.Click += price_btn_Click;
            // 
            // price
            // 
            price.Location = new Point(670, 27);
            price.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            price.Name = "price";
            price.Size = new Size(163, 27);
            price.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(524, 30);
            label1.Name = "label1";
            label1.Size = new Size(130, 19);
            label1.TabIndex = 35;
            label1.Text = "Установить цену:";
            // 
            // LocationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 514);
            Controls.Add(price_btn);
            Controls.Add(price);
            Controls.Add(label1);
            Controls.Add(Close);
            Controls.Add(locations_btn);
            Controls.Add(act_id);
            Controls.Add(label8);
            Controls.Add(loc_table);
            Name = "LocationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Места";
            Load += HallForm_Load;
            ((System.ComponentModel.ISupportInitialize)loc_table).EndInit();
            ((System.ComponentModel.ISupportInitialize)act_id).EndInit();
            ((System.ComponentModel.ISupportInitialize)price).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView loc_table;
        private NumericUpDown act_id;
        private Label label8;
        private Button locations_btn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn spec;
        private DataGridViewTextBoxColumn box;
        private DataGridViewTextBoxColumn rate;
        private DataGridViewTextBoxColumn acts;
        private DataGridViewCheckBoxColumn change;
        private Button Close;
        private Button price_btn;
        private NumericUpDown price;
        private Label label1;
    }
}