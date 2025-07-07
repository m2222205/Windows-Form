namespace Windows_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            LoginField = new TextBox();
            PassField = new TextBox();
            label1 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            closeButton = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(54, 209, 96);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(491, 318);
            button1.Name = "button1";
            button1.Size = new Size(198, 64);
            button1.TabIndex = 0;
            button1.Text = "Click me";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginField.Location = new Point(472, 123);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(282, 27);
            LoginField.TabIndex = 1;
            LoginField.TextChanged += LoginField_TextChanged;
            // 
            // PassField
            // 
            PassField.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassField.Location = new Point(472, 216);
            PassField.Name = "PassField";
            PassField.Size = new Size(282, 27);
            PassField.TabIndex = 2;
            PassField.TextChanged += PassField_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 62, 184);
            label1.Location = new Point(506, 34);
            label1.Name = "label1";
            label1.Size = new Size(226, 66);
            label1.TabIndex = 3;
            label1.Text = "Authentification";
            label1.Click += label1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.BackColor = Color.White;
            closeButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(1115, 10);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(18, 20);
            closeButton.TabIndex = 6;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(372, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._299105_lock_icon;
            pictureBox2.Location = new Point(372, 203);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 17, 68);
            ClientSize = new Size(1178, 505);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(closeButton);
            Controls.Add(label1);
            Controls.Add(PassField);
            Controls.Add(LoginField);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox LoginField;
        private TextBox PassField;
        private Label label1;
        private NotifyIcon notifyIcon1;
        private Label closeButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
