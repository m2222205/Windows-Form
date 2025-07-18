﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
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
        private readonly TransactionService _transactionService;
        private readonly CategoryService _categoryService;
        public Form2()
        {
            InitializeComponent();
            SetupDataGridView();
            service = new FinanceService();
            _transactionService = new TransactionService();
            _categoryService = new CategoryService();
            LoadFinanceData();
        }

        private void Form2_Load(object sender, EventArgs e)
        {   
            SetupDataGridView(); 
            LoadFinanceData();
            LoadTransactionTypesToComboBox();
            LoadCategoriesToComboBox();
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


        private void SetupDataGridView()
        {
            // Отключаем автоматическую генерацию колонок.
            // Это КЛЮЧЕВОЙ ШАГ, который позволит нам вручную управлять колонками.
            dataGridView1.AutoGenerateColumns = false;

            // Очищаем все существующие колонки, если они были добавлены через дизайнер или ранее в коде.
            dataGridView1.Columns.Clear();

            // Добавляем колонки вручную
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", HeaderText = "ID", DataPropertyName = "ID" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Amount", HeaderText = "Сумма", DataPropertyName = "Amount" });

            // *** ИЗМЕНЕНИЕ ЗДЕСЬ: ДЛЯ ТИПА ОПЕРАЦИИ ***
            DataGridViewComboBoxColumn transactionTypeColumn = new DataGridViewComboBoxColumn();
            transactionTypeColumn.Name = "colTransactionType"; // Имя для этой колонки в DataGridView
            transactionTypeColumn.HeaderText = "Тип Операции";
            transactionTypeColumn.DataPropertyName = "TypeId"; // <--- Свойство в классе Finance, которое хранит ID типа
            transactionTypeColumn.DisplayMember = "Name";     // <--- Свойство в классе TransactionType, которое отображается
            transactionTypeColumn.ValueMember = "Id";         // <--- Свойство в классе TransactionType, которое соответствует TypeId
                                                              // <--- DataSource колонки заполняется всеми доступными типами операций
            transactionTypeColumn.DataSource = _transactionService.GetAllTransactionTypes();
            transactionTypeColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing; // Чтобы не показывать стрелку, пока ячейка не активна
            dataGridView1.Columns.Add(transactionTypeColumn);



            // Для Categories.Name
            DataGridViewComboBoxColumn categoryColumn = new DataGridViewComboBoxColumn();
            categoryColumn.Name = "colCategory"; // Имя для этой колонки в DataGridView
            categoryColumn.HeaderText = "Категория";
            categoryColumn.DataPropertyName = "CategoryId"; // <--- Свойство в классе Finance, которое хранит ID категории
            categoryColumn.DisplayMember = "Name";         // <--- Свойство в классе Category, которое отображается
            categoryColumn.ValueMember = "Id";
            categoryColumn.DataSource = _categoryService.GetAllCategories();
            categoryColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing; // Чтобы не показывать стрелку, пока ячейка не активна
            dataGridView1.Columns.Add(categoryColumn);

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Date", HeaderText = "Дата", DataPropertyName = "Date" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "SalaryPercent", HeaderText = "Процент Зарплаты", DataPropertyName = "SalaryPercent" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "BalanceAfter", HeaderText = "Баланс После", DataPropertyName = "BalanceAfter" });

            // Для булевых полей лучше использовать DataGridViewCheckBoxColumn
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn { Name = "IsCredit", HeaderText = "Кредит?", DataPropertyName = "Кредит" });
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn { Name = "IsDebit", HeaderText = "Дебит?", DataPropertyName = "Дебит" });

        
        }

        private void LoadFinanceData()
        {
            try
            {
                // Вызовите SetupDataGridView один раз, например, в конструкторе формы или Form_Load
                // Если вы уже вызываете Columns.Clear() и DataSource = data, то AutoGenerateColumns = false
                // и ручное добавление колонок - это единственный путь.

                var data = service.GetAll();
                dataGridView1.DataSource = data;

                // Форматирование столбца даты
                if (dataGridView1.Columns.Contains("Date"))
                {
                    dataGridView1.Columns["Date"].DefaultCellStyle.Format = "dd.MM.yyyy";
                }

                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BalanceAfter_Click(object sender, EventArgs e)
        {

        }

        //private void AddButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // 1. Сбор данных из элементов управления формы
        //        // Валидация ввода очень важна!
        //        if (!decimal.TryParse(textBoxAmount.Text, out decimal amount))
        //        {
        //            MessageBox.Show("Пожалуйста, введите корректную сумму.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        if (!decimal.TryParse(textBoxSalaryPercent.Text, out decimal salaryPercent))
        //        {
        //            MessageBox.Show("Пожалуйста, введите корректный процент зарплаты.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        if (!decimal.TryParse(textBoxBalanceAfter.Text, out decimal balanceAfter))
        //        {
        //            MessageBox.Show("Пожалуйста, введите корректный баланс после операции.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // Получение ID выбранного элемента из ComboBox для TransactionType
        //        // Предполагается, что ваш ComboBox привязан к List<TransactionType> и DisplayMember="Name", ValueMember="Id"
        //        if (comboBoxTransactionType.SelectedValue == null)
        //        {
        //            MessageBox.Show("Пожалуйста, выберите тип операции.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }
        //        int typeId = Convert.ToInt32(comboBoxTransactionType.SelectedValue);

        //        // Получение ID выбранного элемента из ComboBox для Category
        //        if (ComboBoxCategory.SelectedValue == null)
        //        {
        //            MessageBox.Show("Пожалуйста, выберите категорию.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }
        //        int categoryId = Convert.ToInt32(ComboBoxCategory.SelectedValue);

        //        // Создание нового объекта Finance
        //        Finance newFinance = new Finance
        //        {
        //            Amount = amount,
        //            SalaryPercent = salaryPercent,
        //            BalanceAfter = balanceAfter,
        //            IsCredit = IsCredit.Checked, // Получаем состояние CheckBox
        //            IsDebit = IsDebit.Checked,   // Получаем состояние CheckBox
        //            TypeId = typeId,                     // ID типа операции
        //            CategoryId = categoryId              // ID категории
        //                                                 // Примечание: ID не устанавливается здесь, так как он генерируется БД
        //                                                 // TransactionType и Categories не нужны здесь, так как они ссылочные и не сохраняются напрямую
        //        };

        //        // 2. Вызов метода Add из сервиса/репозитория
        //        int newId = service.Add(newFinance); // Если ваш service.Add() возвращает int ID

        //        // 3. Обработка результата
        //        if (newId > 0)
        //        {
        //            MessageBox.Show($"Запись успешно добавлена с ID: {newId}.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            // Очистка полей ввода после добавления (опционально)
        //            //ClearInputFields();

        //            // Обновление DataGridView для отображения новой записи
        //            LoadFinanceData();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Не удалось добавить запись.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (FormatException fex) // Для ошибок преобразования типа (если TryParse не использовался или введен неверный формат)
        //    {
        //        MessageBox.Show($"Ошибка формата данных: {fex.Message}", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex) // Общий обработчик для других ошибок
        //    {
        //        MessageBox.Show($"Произошла ошибка при добавлении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal amount = numericUpDownAmount.Value;

                if (amount <= 0)
                {
                    MessageBox.Show($"Пожалуйста, введите корректную сумму", "Ошибка ввода");
                    return;
                }


                decimal salaryPercent = numericUpDownSalaryPercent.Value;
                if (salaryPercent <= 0)
                {
                    MessageBox.Show("Пожалуйста, введите корректный процент зарплаты.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal balanceAfter = numericUpDownBalanceAfter.Value;
                if (balanceAfter <= 0)
                {
                    MessageBox.Show("Пожалуйста, введите корректный баланс после операции.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                if (comboBoxTransactionType.SelectedValue == null)
                {
                    MessageBox.Show("Пожалуйста, выберите тип операции.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int typeId = Convert.ToInt32(comboBoxTransactionType.SelectedValue);

               
                if (ComboBoxCategory.SelectedValue == null)
                {
                    MessageBox.Show("Пожалуйста, выберите категорию.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int categoryId = Convert.ToInt32(ComboBoxCategory.SelectedValue);

               
                Finance newFinance = new Finance
                {
                    Amount = amount,
                    SalaryPercent = salaryPercent,
                    BalanceAfter = balanceAfter,
                    IsCredit = IsCredit.Checked, // Получаем состояние CheckBox
                    IsDebit = IsDebit.Checked,   // Получаем состояние CheckBox
                    TypeId = typeId,                     // ID типа операции
                    CategoryId = categoryId              // ID категории
                                                         // Примечание: ID не устанавливается здесь, так как он генерируется БД
                                                         // TransactionType и Categories не нужны здесь, так как они ссылочные и не сохраняются напрямую
                };

               
                int newId = service.Add(newFinance); 

              
                if (newId > 0)
                {
                    MessageBox.Show($"Запись успешно добавлена с ID: {newId}.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Очистка полей ввода после добавления (опционально)
                    //ClearInputFields();

                    // Обновление DataGridView для отображения новой записи
                    LoadFinanceData();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить запись.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException fex) // Для ошибок преобразования типа (если TryParse не использовался или введен неверный формат)
            {
                MessageBox.Show($"Ошибка формата данных: {fex.Message}", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Общий обработчик для других ошибок
            {
                MessageBox.Show($"Произошла ошибка при добавлении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        


        private void LoadTransactionTypesToComboBox()
        {
            // !!! Сюда должна идти логика получения данных из вашей БД через TransactionService
            // Например: List<TransactionType> types = _financeService.GetAllTransactionTypes();
            // Для примера со статическими данными:
            List<TransactionType> Types = new List<TransactionType>();
            Types.Add(new TransactionType() { Id = 1, Name = "Доход" });
            Types.Add(new TransactionType() { Id = 2, Name = "Расход" });

            if (Types.Any())
            {
                comboBoxTransactionType.DataSource = Types;
                comboBoxTransactionType.ValueMember = "Id";      // С кавычками
                comboBoxTransactionType.DisplayMember = "Name";  // С кавычками
            }
            else
            {
                // Обработка случая, когда данных нет
            }
        }


        private void LoadCategoriesToComboBox()
        {
            try
            {
                // Здесь должна быть ваша логика получения данных из БД через сервис
                // Например: List<Category> categories = _financeService.GetAllCategories();
                // Для примера со статическими данными:
                List<Category> categories = new List<Category>();
                categories.Add(new Category() { Id = 1, Name = "Еда" });
                categories.Add(new Category() { Id = 2, Name = "Развлечения" });
                categories.Add(new Category() { Id = 3, Name = "Спорт" });
                categories.Add(new Category() { Id = 4, Name = "Учеба" });
                categories.Add(new Category() { Id = 5, Name = "Комунальные" });
                categories.Add(new Category() { Id = 4, Name = "Одежда" });


                if (categories.Any())
                {
                    ComboBoxCategory.DataSource = categories;
                    ComboBoxCategory.DisplayMember = "Name"; // Убедитесь, что это имя свойства в вашем классе Category
                    ComboBoxCategory.ValueMember = "Id";     // Убедитесь, что это имя свойства в вашем классе Category
                    ComboBoxCategory.SelectedIndex = 0;      // Выбрать первый элемент по умолчанию (или "пустой" элемент)
                }
                else
                {
                    MessageBox.Show("Категории не найдены в базе данных.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ComboBoxCategory.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке категорий: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
