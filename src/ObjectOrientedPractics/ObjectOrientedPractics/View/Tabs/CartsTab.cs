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
using ObjectOrientedPractices.View.Tabs;
using ObjectOrientedPractices.Model.Orders;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка управления корзиной, содержит логику для отображения, 
    /// добавления и удаления товаров из корзины для выбранного покупателя.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список текущих покупателей, для которых отображаются корзины.
        /// </summary>
        public List<Customer> CurrentCustomer = new List<Customer>();

        /// <summary>
        /// Список всех доступных покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Список всех доступных товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Обновляет данные в элементах управления, связанных с корзиной.
        /// </summary>
        public void RefreshData()
        {
            listBoxCartItems.DataSource = null;
            listBoxCartItems.DataSource = Items;
            listBoxCartItems.DisplayMember = "Name";

            comboBoxCustomerInCart.DataSource = null;
            comboBoxCustomerInCart.DataSource = Customers;
            comboBoxCustomerInCart.DisplayMember = "FullName";
        }

        /// <summary>
        /// Инициализирует список товаров в ListBox.
        /// </summary>
        public void InitializeItemsListBox()
        {
            listBoxCartItems.Items.Clear();
            foreach (var item in Items)
            {
                listBoxCartItems.Items.Add($"{item.Name} - {item.Cost}");
            }
        }

        /// <summary>
        /// Инициализирует список покупателей в ComboBox.
        /// </summary>
        public void InitializeCustomersComboBox()
        {
            comboBoxCustomerInCart.Items.Clear();
            foreach (var customer in Customers)
            {
                comboBoxCustomerInCart.Items.Add($"{customer.FullName} - {customer.Address.City}");
            }
        }

        /// <summary>
        /// Конструктор по умолчанию, инициализирующий вкладку CartsTab.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Очистить корзину". 
        /// Очищает корзину выбранного покупателя.
        /// </summary>
        private void buttonClearCartMouseClick(object sender, MouseEventArgs e)
        {
            if (comboBoxCustomerInCart.SelectedIndex != -1)
            {
                int comboIndex = comboBoxCustomerInCart.SelectedIndex;

                listBoxCartOrder.Items.Clear();
                CurrentCustomer[comboIndex].Cart.Items.Clear();
                textBoxAmount.Text = CurrentCustomer[comboIndex].Cart.Amount.ToString();
                MessageBox.Show("Корзина очищена");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите покупателя!");
            }

            if (listBoxCartOrder.Items.Count == 0)
            {
                MessageBox.Show("Корзина покупателя уже пуста!");
            }
        }

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Добавить в корзину". 
        /// Добавляет выбранный товар в корзину выбранного покупателя.
        /// </summary>
        private void buttonAddToCartClick(object sender, EventArgs e)
        {
            int comboIndex = comboBoxCustomerInCart.SelectedIndex;
            int choiceItem = listBoxCartItems.SelectedIndex;
            if (comboIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите покупателя.");
                return;
            }

            if (listBoxCartItems.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите товар.");
                return;
            }

            CurrentCustomer[comboIndex].Cart.Items.Add((Item)listBoxCartItems.SelectedItem);
            listBoxCartOrder.Items.Add($"{((Item)listBoxCartItems.SelectedItem).Name} - {((Item)listBoxCartItems.SelectedItem).Cost}");
            textBoxAmount.Text = $"{CurrentCustomer[comboIndex].Cart.Amount.ToString()}.0";
        }

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Удалить товар". 
        /// Удаляет выбранный товар из корзины выбранного покупателя.
        /// </summary>
        private void buttonRemoveItemClick(object sender, EventArgs e)
        {
            if (CurrentCustomer == null)
            {
                MessageBox.Show("Пожалуйста, выберите покупателя.");
                return;
            }

            if (listBoxCartOrder.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите товар для удаления.");
                return;
            }

            int comboIndex = comboBoxCustomerInCart.SelectedIndex;
            int choiceItem = listBoxCartOrder.SelectedIndex;
            CurrentCustomer[comboIndex].Cart.Items.RemoveAt(choiceItem);
            listBoxCartOrder.Items.RemoveAt(choiceItem);
            textBoxAmount.Text = $"{CurrentCustomer[comboIndex].Cart.Amount.ToString()}.0";
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранного покупателя в ComboBox. 
        /// Обновляет сумму корзины выбранного покупателя.
        /// </summary>
        private void comboBoxCustomerInCartSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCustomerInCart.SelectedItem != null)
            {
                int comboIndex = comboBoxCustomerInCart.SelectedIndex;
                textBoxAmount.Text = CurrentCustomer[comboIndex].Cart.Amount.ToString();
            }
        }

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Создать заказ". 
        /// Создает новый заказ на основе товаров в корзине выбранного покупателя.
        /// </summary>
        private void buttonCreateOrderClick(object sender, EventArgs e)
        {
            if (listBoxCartOrder.Items.Count > 0)
            {
                int comboIndex = comboBoxCustomerInCart.SelectedIndex;
                List<Item> orderlist = new List<Item>();
                if (CurrentCustomer[comboIndex].IsPriority == true)
                {
                    PriorityOrder priorityOrder = new PriorityOrder(CurrentCustomer[comboIndex].Address, orderlist, Convert.ToDouble(CurrentCustomer[comboIndex].Cart.Amount));
                    orderlist.AddRange(CurrentCustomer[comboIndex].Cart.Items);
                    CurrentCustomer[comboIndex].Orders.Add(priorityOrder);

                    listBoxCartOrder.Items.Clear();
                    CurrentCustomer[comboIndex].Cart.Items.Clear();
                    textBoxAmount.Text = "0";
                    MessageBox.Show("Заказ был создан!");
                }
                else
                {
                    Order order = new Order(CurrentCustomer[comboIndex].Address, orderlist, Convert.ToDouble(CurrentCustomer[comboIndex].Cart.Amount));
                    orderlist.AddRange(CurrentCustomer[comboIndex].Cart.Items);
                    CurrentCustomer[comboIndex].Orders.Add(order);

                    listBoxCartOrder.Items.Clear();
                    CurrentCustomer[comboIndex].Cart.Items.Clear();
                    textBoxAmount.Text = "0";
                    MessageBox.Show("Заказ был создан!");
                }

            }
            else
            {
                MessageBox.Show("Корзина пользователя пуста! Заказ нечем наполнить!");
            }
        }
    }
}
