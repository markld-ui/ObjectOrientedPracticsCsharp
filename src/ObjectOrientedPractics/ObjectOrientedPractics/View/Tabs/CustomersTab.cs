using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Services;
using ObjectOrientedPractices.Exceptions;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net;

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Вкладка управления клиентами, содержит функционал для добавления, 
    /// удаления и отображения клиентов.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список всех добавленных клиентов.
        /// </summary>
        private List<Customer> _customers = new();

        /// <summary>
        /// Конструктор по умолчанию, инициализирующий вкладку CustomersTab.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает или задает список элементов, отображаемых на вкладке Customers.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                UpdateCustomersListBox();
            }
        }

        /// <summary>
        /// Метод обновновления списка пользователей
        /// </summary>
        private void UpdateCustomersListBox()
        {
            listBoxCustomers.Items.Clear();
            foreach (var customer in _customers)
            {
                listBoxCustomers.Items.Add($"{customer.FullName} - {customer.Address.Country}, {customer.Address.City}, {customer.Address.Street}");
            }
        }

        public void RefreshData()
        {
            listBoxCustomers.DataSource = null;
            listBoxCustomers.DataSource = _customers;
        }

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Добавить". Выполняет проверку 
        /// введённых данных, создаёт нового клиента и добавляет его в список.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события клика мышью.</param>
        private void addBtnCustomersMouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(textBoxFullNameCustomers.Text, 200, 0, "Full Name");
                ValueValidator.AssertNumericFieldOnLetter(addressControl.PostIndex, nameof(addressControl.PostIndex));
                ValueValidator.AssertStringOnLength(addressControl.Country, 50, 0, nameof(addressControl.Country));
                ValueValidator.AssertStringOnLength(addressControl.City, 50, 0, nameof(addressControl.City));
                ValueValidator.AssertStringOnLength(addressControl.Street, 100, 0, nameof(addressControl.Street));
                ValueValidator.AssertStringOnLength(addressControl.Building, 10, 0, nameof(addressControl.Building));
                ValueValidator.AssertStringOnLength(addressControl.Apartament, 10, 0, nameof(addressControl.Apartament));

                Customer customer = new(
                    textBoxFullNameCustomers.Text,
                    Convert.ToInt32(addressControl.PostIndex),
                    addressControl.Country,
                    addressControl.City,
                    addressControl.Street,
                    addressControl.Building,
                    addressControl.Apartament
                    );
                _customers.Add(customer);
                listBoxCustomers.Items.Add($"{customer.FullName} - {customer.Address.Country}, {customer.Address.City}, {customer.Address.Street}");

                textBoxFullNameCustomers.BackColor = Color.White;

                textBoxFullNameCustomers.Clear();
                textBoxIdCustomers.Clear();
                addressControl.ClearAddressFields();
                addressControl.ExceptionSetRedColor(false);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Поле является пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFullNameCustomers.BackColor = ColorTranslator.FromHtml("#DC143C");
                addressControl.ExceptionSetRedColor(true);

                textBoxFullNameCustomers.Clear();
                textBoxIdCustomers.Clear();
                addressControl.ClearAddressFields();
            }
            catch (NumericFieldException)
            {
                MessageBox.Show("Поле содержит некорректные данные (отличные от цифр)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFullNameCustomers.BackColor = ColorTranslator.FromHtml("#DC143C");
                addressControl.ExceptionSetRedColor(true);

                textBoxFullNameCustomers.Clear();
                textBoxIdCustomers.Clear();
                addressControl.ClearAddressFields();
            }
            catch (StringLengthException)
            {
                MessageBox.Show("Длина поля меньше или превышает допустимое значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFullNameCustomers.BackColor = ColorTranslator.FromHtml("#DC143C");
                addressControl.ExceptionSetRedColor(true);

                textBoxFullNameCustomers.Clear();
                textBoxIdCustomers.Clear();
                addressControl.ClearAddressFields();
            }
        }

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Удалить". Удаляет выбранного клиента
        /// из списка и обновляет интерфейс.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события клика мышью.</param>
        private void removeBtnCustomersMouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxCustomers.SelectedIndex != -1)
            {
                int index = listBoxCustomers.SelectedIndex;
                _customers.RemoveAt(index);
                listBoxCustomers.Items.RemoveAt(index);
                MessageBox.Show("Элемент успешно удален", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);


                textBoxFullNameCustomers.Clear();
                textBoxIdCustomers.Clear();
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обрабатывает событие клика по элементу списка. Заполняет поля данными
        /// выбранного клиента.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события клика мышью.</param>
        private void listBoxCustomersMouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxCustomers.SelectedIndex != -1)
            {
                int index = listBoxCustomers.SelectedIndex;
                Customer selectedCustomer = _customers[index];

                textBoxFullNameCustomers.Text = selectedCustomer.FullName;
                textBoxIdCustomers.Text = selectedCustomer.Id.ToString();
                addressControl.FillAddressFields(selectedCustomer.Address);
            }
        }
    }
}
