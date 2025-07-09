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
            numericUpDown4 = new NumericUpDown();
            BalanceAfter = new Label();
            numericUpDown3 = new NumericUpDown();
            Amount_Label = new Label();
            GetAll_Button = new Button();
            Edit_Button = new Button();
            Delete_Button = new Button();
            AddButton = new Button();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            Category = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new TableLayoutPanel();
            LoadIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            dataGridView1.Size = new Size(876, 375);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 17);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 2;
            label1.Text = "My Finance";
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDown4);
            panel1.Controls.Add(BalanceAfter);
            panel1.Controls.Add(numericUpDown3);
            panel1.Controls.Add(Amount_Label);
            panel1.Controls.Add(GetAll_Button);
            panel1.Controls.Add(Edit_Button);
            panel1.Controls.Add(Delete_Button);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Category);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 384);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 378);
            panel1.TabIndex = 3;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(251, 281);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 25);
            numericUpDown4.TabIndex = 19;
            // 
            // BalanceAfter
            // 
            BalanceAfter.BorderStyle = BorderStyle.FixedSingle;
            BalanceAfter.Location = new Point(33, 282);
            BalanceAfter.Name = "BalanceAfter";
            BalanceAfter.Size = new Size(121, 25);
            BalanceAfter.TabIndex = 18;
            BalanceAfter.Text = "Остаток";
            BalanceAfter.TextAlign = ContentAlignment.TopCenter;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(251, 241);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 25);
            numericUpDown3.TabIndex = 17;
            // 
            // Amount_Label
            // 
            Amount_Label.BorderStyle = BorderStyle.FixedSingle;
            Amount_Label.Location = new Point(33, 241);
            Amount_Label.Name = "Amount_Label";
            Amount_Label.Size = new Size(121, 25);
            Amount_Label.TabIndex = 16;
            Amount_Label.Text = "Количество";
            Amount_Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // GetAll_Button
            // 
            GetAll_Button.Location = new Point(465, 194);
            GetAll_Button.Name = "GetAll_Button";
            GetAll_Button.Size = new Size(75, 23);
            GetAll_Button.TabIndex = 15;
            GetAll_Button.Text = "GetAll";
            GetAll_Button.UseVisualStyleBackColor = true;
            // 
            // Edit_Button
            // 
            Edit_Button.Location = new Point(465, 149);
            Edit_Button.Name = "Edit_Button";
            Edit_Button.Size = new Size(75, 23);
            Edit_Button.TabIndex = 14;
            Edit_Button.Text = "Edit";
            Edit_Button.UseVisualStyleBackColor = true;
           
            // 
            // Delete_Button
            // 
            Delete_Button.Location = new Point(465, 108);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(75, 23);
            Delete_Button.TabIndex = 13;
            Delete_Button.Text = "Delete";
            Delete_Button.UseVisualStyleBackColor = true;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(465, 63);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 12;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
          
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(251, 196);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 25);
            numericUpDown2.TabIndex = 11;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(33, 196);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 10;
            label4.Text = "ПроцентОт Зарплаты";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(33, 151);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 9;
            label2.Text = "Кредит";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "    Доход", "    Расход" });
            comboBox1.Location = new Point(33, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(251, 64);
            numericUpDown1.Maximum = new decimal(new int[] { -1863462912, 46, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 25);
            numericUpDown1.TabIndex = 7;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(33, 110);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 6;
            label3.Text = "Дебит";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Category
            // 
            Category.AutoCompleteCustomSource.AddRange(new string[] { "Еда Одежда " });
            Category.DropDownStyle = ComboBoxStyle.DropDownList;
            Category.FormattingEnabled = true;
            Category.Items.AddRange(new object[] { " Еда", " Развлечение", " Комуналные", " Одежда", " Учеба", " Спорт" });
            Category.Location = new Point(251, 21);
            Category.Name = "Category";
            Category.Size = new Size(121, 25);
            Category.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(251, 151);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 25);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(251, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 25);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 25);
            textBox2.TabIndex = 1;
            textBox2.Text = "Категория";
            textBox2.TextAlign = HorizontalAlignment.Center;
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
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 811);
            Controls.Add(LoadIcon);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LoadIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private ComboBox Category;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AddButton;
        private Button GetAll_Button;
        private Button Edit_Button;
        private Button Delete_Button;
        private PictureBox LoadIcon;
        private Label Amount_Label;
        private NumericUpDown numericUpDown3;
        private Label BalanceAfter;
        private NumericUpDown numericUpDown4;
    }
}