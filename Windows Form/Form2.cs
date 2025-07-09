using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Form.Models;
using Windows_Form.Service;

namespace Windows_Form
{
    public partial class Form2 : Form
    {
        private readonly FinanceService service;
        public Form2()
        {
            InitializeComponent();
            service = new FinanceService();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           LoadFinanceData();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
                service.Delete(id);
                LoadFinanceData();
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления");
            }
        }

        private void LoadIcon_Click(object sender, EventArgs e)
        {
            LoadFinanceData();
        }


        private void LoadFinanceData()
        {
           
            try
            {
                // 1. Очищаем предыдущие столбцы перед новой привязкой данных
                // Это важно, чтобы DataGridView мог корректно перестроить столбцы
                // на основе нового DataSource.
                dataGridView1.Columns.Clear();

                // 2. Получаем список финансовых записей из базы данных
                var data = service.GetAll();

                // 3. Привязываем данные к DataGridView.
                // DataGridView автоматически создаст столбцы для всех публичных свойств в классе Finance.
                dataGridView1.DataSource = data;

                // 4. Опциональная настройка столбцов (после того, как они автоматически создались):

                // Переименование заголовков на русский язык
                // Проверяем существование столбца перед его изменением, чтобы избежать ошибок.
                if (dataGridView1.Columns.Contains("ID")) dataGridView1.Columns["ID"].HeaderText = "ID";
                if (dataGridView1.Columns.Contains("Amount")) dataGridView1.Columns["Amount"].HeaderText = "Сумма";
                if (dataGridView1.Columns.Contains("TypeId")) dataGridView1.Columns["TypeId"].HeaderText = "Тип"; // Или "Тип Операции"
                if (dataGridView1.Columns.Contains("CategoryId")) dataGridView1.Columns["CategoryId"].HeaderText = "Категория";
                if (dataGridView1.Columns.Contains("Date")) dataGridView1.Columns["Date"].HeaderText = "Дата"; // <<--- Вот ваш столбец с датой
                if (dataGridView1.Columns.Contains("SalaryPercent")) dataGridView1.Columns["SalaryPercent"].HeaderText = "Процент Зарплаты";
                if (dataGridView1.Columns.Contains("BalanceAfter")) dataGridView1.Columns["BalanceAfter"].HeaderText = "Баланс После";
                if (dataGridView1.Columns.Contains("IsCredit")) dataGridView1.Columns["IsCredit"].HeaderText = "Кредит?"; // Или "Кредит"
                if (dataGridView1.Columns.Contains("IsDebit")) dataGridView1.Columns["IsDebit"].HeaderText = "Дебит?";   // Или "Дебит"
                if (dataGridView1.Columns.Contains("Income")) dataGridView1.Columns["Income"].HeaderText = "Доход";
                if (dataGridView1.Columns.Contains("Expense")) dataGridView1.Columns["Expense"].HeaderText = "Расход";


                // 5. Опционально: Форматирование столбца даты (если нужно специфичное отображение)
                if (dataGridView1.Columns.Contains("Date"))
                {
                    // Устанавливаем формат для столбца "Date"
                    // Например, "dd.MM.yyyy" для 09.07.2025
                    // Или "yyyy-MM-dd HH:mm:ss" для 2025-07-09 12:20:38
                    dataGridView1.Columns["Date"].DefaultCellStyle.Format = "dd.MM.yyyy";
                }

                // 6. Опционально: Скрытие некоторых столбцов, если они не нужны пользователю
                // Например, TypeId и CategoryId могут быть представлены через другие поля (Категория, Тип)
                if (dataGridView1.Columns.Contains("TypeId")) dataGridView1.Columns["TypeId"].Visible = false;
                if (dataGridView1.Columns.Contains("CategoryId")) dataGridView1.Columns["CategoryId"].Visible = false;
                // Можно также скрыть IsCredit и IsDebit, если вы используете Income и Expense
                if (dataGridView1.Columns.Contains("IsCredit")) dataGridView1.Columns["IsCredit"].Visible = false;
                if (dataGridView1.Columns.Contains("IsDebit")) dataGridView1.Columns["IsDebit"].Visible = false;


                // 7. Настройка разрешений для пользователя
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        //private void Edit_Button_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(txtId.Text);

        //    Finance finance = new Finance
        //    {
        //        ID = id,
        //        Amount = decimal.Parse(txtAmount.Text),
        //        TypeId = (int)cmbType.SelectedValue,
        //        CategoryId = (int)cmbCategory.SelectedValue,
        //        Date = dtpDate.Value,
        //        SalaryPercent = decimal.Parse(txtPercent.Text),
        //        BalanceAfter = decimal.Parse(txtBalance.Text),
        //        IsCredit = chkCredit.Checked,
        //        IsDebit = chkDebit.Checked
        //    };

        //    service.Update(finance);
        //    LoadFinanceData();
        //}

        //private void AddButton_Click(object sender, EventArgs e)
        //{
        //    Finance finance = new Finance
        //    {
        //        Amount = decimal.Parse(txtAmount.Text),
        //        TypeId = (int)cmbType.SelectedValue,
        //        CategoryId = (int)cmbCategory.SelectedValue,
        //        Date = dtpDate.Value,
        //        Description = txtDescription.Text,
        //        SalaryPercent = decimal.Parse(txtPercent.Text),
        //        BalanceAfter = decimal.Parse(txtBalance.Text),
        //        IsCredit = chkCredit.Checked,
        //        IsDebit = chkDebit.Checked
        //    };

        //    _service.Add(finance);
        //    LoadData(); // обновим таблицу
        //}


        //private void LoadComboBoxes()
        //{
        //    cmbType.DataSource = repository.GetTypes();  // 👈 из сервиса или репозитория
        //    cmbType.DisplayMember = "Name";
        //    cmbType.ValueMember = "Id";

        //    cmbCategory.DataSource = repository.GetCategories();
        //    cmbCategory.DisplayMember = "Name";
        //    cmbCategory.ValueMember = "Id";
        //}


    }

}
