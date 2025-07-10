namespace Windows_Form
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            IsDebit = new CheckBox();
            IsCredit = new CheckBox();
            numericUpDown4 = new NumericUpDown();
            textBoxBalanceAfter = new Label();
            numericUpDownBalanceAfter = new NumericUpDown();
            textBoxAmount = new Label();
            numericUpDownSalaryPercent = new NumericUpDown();
            textBoxSalaryPercent = new Label();
            comboBoxTransactionType = new ComboBox();
            numericUpDownAmount = new NumericUpDown();
            ComboBoxCategory = new ComboBox();
            label_category = new TextBox();
            Edit_Button = new Button();
            Delete_Button = new Button();
            AddButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new TableLayoutPanel();
            LoadIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBalanceAfter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalaryPercent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoadIcon).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(876, 375);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 6);
            label1.Name = "label1";
            label1.Size = new Size(171, 40);
            label1.TabIndex = 2;
            label1.Text = "My Finance";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(IsDebit);
            panel1.Controls.Add(IsCredit);
            panel1.Controls.Add(numericUpDown4);
            panel1.Controls.Add(textBoxBalanceAfter);
            panel1.Controls.Add(numericUpDownBalanceAfter);
            panel1.Controls.Add(textBoxAmount);
            panel1.Controls.Add(numericUpDownSalaryPercent);
            panel1.Controls.Add(textBoxSalaryPercent);
            panel1.Controls.Add(comboBoxTransactionType);
            panel1.Controls.Add(numericUpDownAmount);
            panel1.Controls.Add(ComboBoxCategory);
            panel1.Controls.Add(label_category);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 384);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 378);
            panel1.TabIndex = 3;
            // 
            // IsDebit
            // 
            IsDebit.AutoSize = true;
            IsDebit.Location = new Point(508, 89);
            IsDebit.Name = "IsDebit";
            IsDebit.Size = new Size(94, 32);
            IsDebit.TabIndex = 21;
            IsDebit.Text = "Дебит";
            IsDebit.UseVisualStyleBackColor = true;
            // 
            // IsCredit
            // 
            IsCredit.AutoSize = true;
            IsCredit.Location = new Point(508, 25);
            IsCredit.Name = "IsCredit";
            IsCredit.Size = new Size(103, 32);
            IsCredit.TabIndex = 20;
            IsCredit.Text = "Кредит";
            IsCredit.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(251, 280);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 34);
            numericUpDown4.TabIndex = 19;
            // 
            // textBoxBalanceAfter
            // 
            textBoxBalanceAfter.BackColor = SystemColors.ButtonHighlight;
            textBoxBalanceAfter.BorderStyle = BorderStyle.FixedSingle;
            textBoxBalanceAfter.Location = new Point(33, 280);
            textBoxBalanceAfter.Name = "textBoxBalanceAfter";
            textBoxBalanceAfter.Size = new Size(121, 34);
            textBoxBalanceAfter.TabIndex = 18;
            textBoxBalanceAfter.Text = "Остаток";
            textBoxBalanceAfter.TextAlign = ContentAlignment.TopCenter;
            textBoxBalanceAfter.Click += BalanceAfter_Click;
            // 
            // numericUpDownBalanceAfter
            // 
            numericUpDownBalanceAfter.Location = new Point(251, 206);
            numericUpDownBalanceAfter.Name = "numericUpDownBalanceAfter";
            numericUpDownBalanceAfter.Size = new Size(120, 34);
            numericUpDownBalanceAfter.TabIndex = 17;
            // 
            // textBoxAmount
            // 
            textBoxAmount.BackColor = SystemColors.ButtonHighlight;
            textBoxAmount.BorderStyle = BorderStyle.FixedSingle;
            textBoxAmount.Location = new Point(33, 206);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(147, 37);
            textBoxAmount.TabIndex = 16;
            textBoxAmount.Text = "Количество";
            textBoxAmount.TextAlign = ContentAlignment.TopCenter;
            // 
            // numericUpDownSalaryPercent
            // 
            numericUpDownSalaryPercent.Location = new Point(270, 133);
            numericUpDownSalaryPercent.Name = "numericUpDownSalaryPercent";
            numericUpDownSalaryPercent.Size = new Size(120, 34);
            numericUpDownSalaryPercent.TabIndex = 11;
            // 
            // textBoxSalaryPercent
            // 
            textBoxSalaryPercent.BackColor = SystemColors.ButtonHighlight;
            textBoxSalaryPercent.BorderStyle = BorderStyle.FixedSingle;
            textBoxSalaryPercent.Location = new Point(20, 133);
            textBoxSalaryPercent.Name = "textBoxSalaryPercent";
            textBoxSalaryPercent.Size = new Size(212, 45);
            textBoxSalaryPercent.TabIndex = 10;
            textBoxSalaryPercent.Text = "ПроцентОт Зарплаты";
            textBoxSalaryPercent.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxTransactionType
            // 
            comboBoxTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransactionType.FormattingEnabled = true;
            comboBoxTransactionType.Items.AddRange(new object[] { "Доход", "Расход" });
            comboBoxTransactionType.Location = new Point(33, 74);
            comboBoxTransactionType.Name = "comboBoxTransactionType";
            comboBoxTransactionType.Size = new Size(121, 36);
            comboBoxTransactionType.TabIndex = 8;
          
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(270, 76);
            numericUpDownAmount.Maximum = new decimal(new int[] { -1863462912, 46, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(120, 34);
            numericUpDownAmount.TabIndex = 7;
            // 
            // ComboBoxCategory
            // 
            ComboBoxCategory.AutoCompleteCustomSource.AddRange(new string[] { "Еда Одежда " });
            ComboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxCategory.FormattingEnabled = true;
            ComboBoxCategory.Items.AddRange(new object[] { " Еда", " Развлечение", " Комуналные", " Одежда", " Учеба", " Спорт" });
            ComboBoxCategory.Location = new Point(251, 21);
            ComboBoxCategory.Name = "ComboBoxCategory";
            ComboBoxCategory.Size = new Size(121, 36);
            ComboBoxCategory.TabIndex = 4;
            // 
            // label_category
            // 
            label_category.Location = new Point(33, 21);
            label_category.Name = "label_category";
            label_category.Size = new Size(121, 34);
            label_category.TabIndex = 1;
            label_category.Text = "Категория";
            label_category.TextAlign = HorizontalAlignment.Center;
            // 
            // Edit_Button
            // 
            Edit_Button.Location = new Point(208, 10);
            Edit_Button.Name = "Edit_Button";
            Edit_Button.Size = new Size(85, 39);
            Edit_Button.TabIndex = 14;
            Edit_Button.Text = "Edit";
            Edit_Button.UseVisualStyleBackColor = true;
            // 
            // Delete_Button
            // 
            Delete_Button.Location = new Point(93, 7);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(99, 43);
            Delete_Button.TabIndex = 13;
            Delete_Button.Text = "Delete";
            Delete_Button.UseVisualStyleBackColor = true;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 7);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 43);
            AddButton.TabIndex = 12;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 52);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.80392F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.19608F));
            tableLayoutPanel1.Size = new Size(882, 765);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // LoadIcon
            // 
            LoadIcon.Image = Properties.Resources.rotate1;
            LoadIcon.Location = new Point(662, 17);
            LoadIcon.Name = "LoadIcon";
            LoadIcon.Size = new Size(30, 32);
            LoadIcon.SizeMode = PictureBoxSizeMode.Zoom;
            LoadIcon.TabIndex = 5;
            LoadIcon.TabStop = false;
            LoadIcon.Click += LoadIcon_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 811);
            Controls.Add(LoadIcon);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Controls.Add(Delete_Button);
            Controls.Add(Edit_Button);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBalanceAfter).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalaryPercent).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LoadIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private TextBox label_category;
        private ComboBox ComboBoxCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NumericUpDown numericUpDownAmount;
        private ComboBox comboBoxTransactionType;
        private NumericUpDown numericUpDownSalaryPercent;
        private Label textBoxSalaryPercent;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AddButton;
        private Button Edit_Button;
        private Button Delete_Button;
        private PictureBox LoadIcon;
        private Label textBoxAmount;
        private NumericUpDown numericUpDownBalanceAfter;
        private Label textBoxBalanceAfter;
        private NumericUpDown numericUpDown4;
        private CheckBox IsDebit;
        private CheckBox IsCredit;
    }
}