using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Доход";
            dataGridView1.Columns[2].Name = "Расход";
            dataGridView1.Columns[2].Name = "Дебит";
            dataGridView1.Columns[2].Name = "Кредит";


            string[] row1 = new string[] { "1", "15000", "5000", "3000", "2500" };
            string[] row2 = new string[] { "2", "5000", "3000", "2000", "2200" };
            string[] row3 = new string[] { "3", "50000", "10000", "5000", "15000" };

            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);

            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;

        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
