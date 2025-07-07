using System.Data;
using System.Data.SqlClient;

namespace Windows_Form
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();

        public Form1()
        {
            InitializeComponent();

            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Width, 37);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var LoginUser = LoginField.Text;
            var Password = PassField.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();
            string queryString = "SELECT Id, login_user, password FROM Authorizations WHERE login_user = @loginUser AND password = @password";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            // Добавляем параметры
            command.Parameters.AddWithValue("@loginUser", LoginUser);
            command.Parameters.AddWithValue("@password", Password);
            adapter.SelectCommand = command;
             adapter.Fill(Table); 

            if (Table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно зашли");
                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("There is no such User");
            }

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        Point point;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {
            LoginField.MaxLength = 50;
        }

        private void PassField_TextChanged(object sender, EventArgs e)
        {
            PassField.PasswordChar = '•';
            PassField.MaxLength = 50;
        }
    }
}
