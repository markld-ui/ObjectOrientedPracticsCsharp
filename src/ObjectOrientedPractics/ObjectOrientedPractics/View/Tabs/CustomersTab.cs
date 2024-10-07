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
        /// Обрабатывает событие клика по кнопке "Добавить". Выполняет проверку 
        /// введённых данных, создаёт нового клиента и добавляет его в список.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события клика мышью.</param>
        private void addBtnCustomersMouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(textBox_fn_customers.Text, 200, 0, "Full Name");

                Address address = new Address(
                    Convert.ToInt32(addressControl.PostIndex),
                    addressControl.Country,
                    addressControl.City,
                    addressControl.Street,
                    addressControl.Building,
                    addressControl.Apartament
                );

                Customer customer = new(textBox_fn_customers.Text, address);
                _customers.Add(customer);
                listBox_customers.Items.Add($"{customer.FullName} - {customer.Address.Country}, {customer.Address.City}, {customer.Address.Street}");

                textBox_fn_customers.BackColor = Color.White;

                textBox_fn_customers.Clear();
                textBox_id_customers.Clear();
                addressControl.ClearAddressFields();
            }
            catch (StringMaxLengthException)
            {
                MessageBox.Show("Длина поля превышает допустимое значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_fn_customers.BackColor = ColorTranslator.FromHtml("#DC143C");

                textBox_fn_customers.Clear();
                textBox_id_customers.Clear();
            }
            catch (StringMinLengthException)
            {
                MessageBox.Show("Длина поля меньше допустимого значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_fn_customers.BackColor = ColorTranslator.FromHtml("#DC143C");

                textBox_fn_customers.Clear();
                textBox_id_customers.Clear();
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
            if (listBox_customers.SelectedIndex != -1)
            {
                int index = listBox_customers.SelectedIndex;
                _customers.RemoveAt(index);
                listBox_customers.Items.RemoveAt(index);
                MessageBox.Show("Элемент успешно удален", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);


                textBox_fn_customers.Clear();
                textBox_id_customers.Clear();
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
            if (listBox_customers.SelectedIndex != -1)
            {
                int index = listBox_customers.SelectedIndex;
                Customer selectedCustomer = _customers[index];

                textBox_fn_customers.Text = selectedCustomer.FullName;
                textBox_id_customers.Text = selectedCustomer.Id.ToString();
                addressControl.FillAddressFields(selectedCustomer.Address);
            }
        }
    }
}
