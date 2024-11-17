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
using ObjectOrientedPractices.Model.Enums;
using ObjectOrientedPractices.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет пользовательский интерфейс для управления приоритетными заказами.
    /// Этот класс наследует от UserControl и содержит логику для работы с приоритетными заказами.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Экземпляр приоритетного заказа.
        /// </summary>
        private PriorityOrder _priorityOrder = new PriorityOrder();

        /// <summary>
        /// Список клиентов.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Генератор случайных чисел для выбора товаров.
        /// </summary>
        private Random rnd = new Random();

        /// <summary>
        /// Свойство, представляющее список клиентов.
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
            }
        }

        /// <summary>
        /// Свойство, представляющее список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Свойство, представляющее приоритетный заказ.
        /// </summary>
        public PriorityOrder PriorityOrder
        {
            get
            {
                return _priorityOrder;
            }
            set
            {
                _priorityOrder = value;
            }
        }

        /// <summary>
        /// Конструктор для инициализации компонентов пользовательского интерфейса.
        /// Устанавливает источники данных для комбобоксов.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();
            comboBoxTimePriority.DataSource = PriorityOrder.PriorityTimeData;
            comboBoxTimePriority.Text = null;
            comboBoxStatusPriority.DataSource = Enum.GetValues(typeof(OrderStatus));
            comboBoxStatusPriority.Text = null;
        }

        /// <summary>
        /// Очищает все элементы управления на вкладке приоритетных заказов.
        /// </summary>
        public void OrderClear()
        {
            textBoxIdPriority.Text = null;
            textBoxCreatedPriority.Text = null;
            comboBoxStatusPriority.Text = null;
            comboBoxTimePriority.Text = null;
            addressControlInPriority.PostIndex = null;
            addressControlInPriority.Country = null;
            addressControlInPriority.City = null;
            addressControlInPriority.Street = null;
            addressControlInPriority.Building = null;
            addressControlInPriority.Apartament = null;
            textBoxAmountPriority.Text = null;
            listBoxItemsInPriority.DataSource = null;
            comboBoxTimePriority.DataSource = null;
        }

        /// <summary>
        /// Обновляет данные приоритетных заказов на вкладке.
        /// Заполняет элементы управления данными о клиентах и их заказах.
        /// </summary>
        public void RefreshDataPriority()
        {
            if (_customers.Count != 0)
            {
                foreach (var customer in _customers)
                {
                    if (customer.Orders.Count > 0)
                    {
                        foreach (var order in customer.Orders)
                        {
                            var address = customer.Address;

                            textBoxIdPriority.Text = customer.Id.ToString();
                            textBoxCreatedPriority.Text = order.Date.ToString();

                            comboBoxStatusPriority.Text = order.Status.ToString();

                            addressControlInPriority.PostIndex = address.Index.ToString();
                            addressControlInPriority.Country = address.Country.ToString();
                            addressControlInPriority.City = address.City.ToString();
                            addressControlInPriority.Street = address.Street.ToString();
                            addressControlInPriority.Building = address.Building.ToString();
                            addressControlInPriority.Apartament = address.Apartament.ToString();

                            textBoxAmountPriority.Text = order.Amount.ToString();

                            listBoxItemsInPriority.DataSource = null;
                            listBoxItemsInPriority.DataSource = order.Items;

                            comboBoxTimePriority.Text = customer.Time;
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного времени приоритетного заказа.
        /// Обновляет время у всех клиентов и обновляет данные на вкладке.
        /// </summary>
        private void ComboBoxTimePrioritySelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTimePriority.SelectedItem != null)
            {
                foreach (var time in Customers)
                {
                    time.Time = comboBoxTimePriority.SelectedItem.ToString();
                }
            }

            RefreshDataPriority();
        }

        /// <summary>
        /// Обработчик изменения выбранного статуса заказа.
        /// Обновляет статус у всех заказов и обновляет данные на вкладке.
        /// </summary>
        private void ComboBoxStatusPrioritySelectedIndexChanged(object sender, EventArgs e)
        {
            if (Customers.Count > 0 && comboBoxStatusPriority.SelectedItem != null)
            {
                for (int i = 0; i < Customers.Count; i++)
                {
                    if (Customers[i].Orders.Count == 1)
                    {
                        Customers[i].Orders[0].Status = (OrderStatus)comboBoxStatusPriority.SelectedItem;
                        RefreshDataPriority();
                    }
                }
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки добавления товара в приоритетный заказ.
        /// Добавляет случайный товар из списка товаров в заказы клиентов.
        /// </summary>
        private void ButtonAddItemPriorityClick(object sender, EventArgs e)
        {
            if (Items.Count != 0)
            {
                int indexItem = rnd.Next(Items.Count);
                foreach (var customer in Customers)
                {
                    foreach (var order in customer.Orders)
                    {
                        order.Items.Add(Items[indexItem]);
                        customer.Cart.Items.Add(Items[indexItem]);
                        textBoxAmountPriority.Text = customer.Cart.Amount.ToString();
                    }
                }

                RefreshDataPriority();
            }
            else
            {
                MessageBox.Show("В списках нет приоритетного пользователя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки удаления товара из приоритетного заказа.
        /// Удаляет выбранный товар из заказов клиентов.
        /// </summary>
        private void ButtonRemoveItemPriorityClick(object sender, EventArgs e)
        {
            int indexItem = listBoxItemsInPriority.SelectedIndex;
            if (indexItem != -1)
            {
                foreach (var customer in Customers)
                {
                    foreach (var order in customer.Orders)
                    {
                        order.Items.RemoveAt(indexItem);
                    }
                }

                RefreshDataPriority();
            }
            else
            {
                MessageBox.Show("Выберите товар для удаления!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки очистки заказов.
        /// Очищает все заказы и элементы управления на вкладке.
        /// </summary>
        private void ButtonClearOrderPriorityClick(object sender, EventArgs e)
        {
            if (Customers.Count != 0)
            {
                Customers.Clear();
                RefreshDataPriority();
            }

            OrderClear();
        }
    }
}
