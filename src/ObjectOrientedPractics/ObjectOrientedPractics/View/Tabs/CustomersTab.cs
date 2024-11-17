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
using ObjectOrientedPractices.Model.Discounts;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net;
using System.Reflection;

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Вкладка управления клиентами, содержит функционал для добавления, 
    /// удаления и отображения клиентов.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        public event EventHandler CustomersChanged;

        /// <summary>
        /// Список всех добавленных клиентов.
        /// </summary>
        private List<Customer> _customers = new();

        /// <summary>
        /// Новый объект скидки, который будет добавлен клиенту.
        /// </summary>
        public PercentDiscount newDiscount { get; set; }

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
        /// Событие срабатывает при изменении данных во вкладке покупателя.
        /// </summary>
        protected virtual void OnCustomersChanged() => CustomersChanged?.Invoke(this, EventArgs.Empty);

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

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Добавить". Выполняет проверку 
        /// введённых данных, создаёт нового клиента и добавляет его в список.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события клика мышью.</param>
        private void AddBtnCustomersMouseClick(object sender, MouseEventArgs e)
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

                if (checkBoxIsPriority.Checked == true)
                {
                    customer.IsPriority = true;
                }
                else
                {
                    customer.IsPriority = false;
                }

                _customers.Add(customer);
                listBoxCustomers.Items.Add($"{customer.FullName} - {customer.Address.Country}, {customer.Address.City}, {customer.Address.Street}");

                textBoxFullNameCustomers.BackColor = Color.White;

                textBoxFullNameCustomers.Clear();
                textBoxIdCustomers.Clear();
                addressControl.ClearAddressFields();
                addressControl.ExceptionSetRedColor(false);
                OnCustomersChanged();
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
        private void RemoveBtnCustomersMouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxCustomers.SelectedIndex != -1)
            {
                int index = listBoxCustomers.SelectedIndex;
                _customers.RemoveAt(index);
                listBoxCustomers.Items.RemoveAt(index);
                MessageBox.Show("Элемент успешно удален", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxFullNameCustomers.Clear();
                textBoxIdCustomers.Clear();
                OnCustomersChanged();
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
        private void ListBoxCustomersMouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxCustomers.SelectedIndex != -1)
            {
                int index = listBoxCustomers.SelectedIndex;
                Customer selectedCustomer = _customers[index];

                textBoxFullNameCustomers.Text = selectedCustomer.FullName;
                textBoxIdCustomers.Text = selectedCustomer.Id.ToString();
                addressControl.FillAddressFields(selectedCustomer.Address);
                checkBoxIsPriority.Checked = selectedCustomer.IsPriority;
                listBoxDiscounts.DataSource = null;
                listBoxDiscounts.DataSource = Customers[index].Discounts;
                listBoxDiscounts.DisplayMember = "Info";
            }
        }

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Add". Открывает вкладку
        /// для добавления новой скидки клиенту.
        /// </summary>
        private void ButtonAddDiscountClick(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedIndex != -1)
            {
                DiscountsTab discountTab = new DiscountsTab();
                discountTab.CustomersTabForm = this;
                int index = listBoxCustomers.SelectedIndex;

                if (!discountTab.Visible)
                {
                    discountTab.ShowDialog();
                }

                if (newDiscount != null)
                {
                    for (int i = 0; i < Customers[index].Discounts.Count; i++)
                    {
                        if (newDiscount.Info == Customers[index].Discounts[i].Info)
                        {
                            newDiscount = null;
                            continue;
                        }
                    }

                    if (newDiscount == null)
                    {
                        return;
                    }
                    else
                    {
                        Customers[index].Discounts.Add(newDiscount);
                        listBoxDiscounts.DataSource = null;
                        listBoxDiscounts.DataSource = Customers[index].Discounts;
                        listBoxDiscounts.DisplayMember = "Info";
                        newDiscount = null;
                    }
                }
                else
                {
                    return;
                }

                discountTab.Dispose();
            }
            else
            {
                MessageBox.Show("Выберите покупателя!");
            }
        }

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Remove". Удаляет выбранную
        /// скидку из списка скидок клиента.
        /// </summary>
        private void ButtonRemoveDiscountClick(object sender, EventArgs e)
        {
            int indexDiscount = listBoxDiscounts.SelectedIndex;
            int indexCustomer = listBoxCustomers.SelectedIndex;

            if (indexDiscount == 0)
            {
                MessageBox.Show("Накопительную скидку удалить нельзя!");
                return;
            }

            if (indexDiscount > 0)
            {
                Customers[indexCustomer].Discounts.RemoveAt(indexDiscount);
                listBoxDiscounts.DataSource = null;
                listBoxDiscounts.DataSource = Customers[indexCustomer].Discounts;
                listBoxDiscounts.DisplayMember = "Info";
            }
        }
    }
}
