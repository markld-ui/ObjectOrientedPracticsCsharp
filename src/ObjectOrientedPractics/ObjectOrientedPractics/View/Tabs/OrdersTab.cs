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
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет вкладку для управления заказами клиентов.
    /// Этот класс отвечает за отображение, обновление и редактирование информации о заказах.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список клиентов, чьи заказы будут отображаться.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Экземпляр приоритетного заказа.
        /// </summary>
        private PriorityOrder _priorityOrder = new PriorityOrder();

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
        /// Конструктор для инициализации компонентов вкладки заказов.
        /// Устанавливает источник данных для комбобокса статуса заказа и скрывает панель данных заказа по умолчанию.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            comboBoxStatusOrder.DataSource = Enum.GetValues(typeof(OrderStatus));
            comboBoxStatusOrder.Text = null;
            dataPanelOrder.Visible = false;

            comboBoxTimeOrder.DataSource = PriorityOrder.PriorityTimeData;
            comboBoxTimeOrder.Text = null;
        }

        /// <summary>
        /// Обновляет данные заказов в таблице.
        /// Заполняет таблицу данными о заказах для каждого клиента.
        /// </summary>
        public void UpdateOrders()
        {
            comboBoxTimeOrder.DataSource = PriorityOrder.PriorityTimeData;
            dataGridViewOrder.Rows.Clear();
            for (int i = 0; i < _customers.Count; i++)
            {
                if (_customers[i].Orders.Count > 0)
                {
                    var address = _customers[i].Address;
                    for (int j = 0; j < _customers[i].Orders.Count; j++)
                    {
                        dataGridViewOrder.Rows.Add(_customers[i].Id, _customers[i].Orders[j].Date,
                            _customers[i].Orders[j].Status, _customers[i].FullName,
                            $"{address.Index}, {address.Country}, {address.City}, {address.Street}, {address.Building}, {address.Apartament}",
                            _customers[i].Orders[j].Amount, _customers[i].Orders[j].Total);

                        comboBoxTimeOrder.Text = _customers[i].Time;
                    }
                }
            }
        }

        /// <summary>
        /// Очищает и обновляет элементы управления на вкладке заказов.
        /// </summary>
        public void RefreshData()
        {
            addressControlInOrder.PostIndex = null;
            addressControlInOrder.Country = null;
            addressControlInOrder.City = null;
            addressControlInOrder.Street = null;
            addressControlInOrder.Building = null;
            addressControlInOrder.Apartament = null;

            textBoxIdOrder.Text = null;
            textBoxCreatedOrder.Text = null;
            comboBoxStatusOrder.Text = null;
            textBoxAmountInOrder.Text = null;

            listBoxItemsInOrder.DataSource = null;
            comboBoxTimeOrder.DataSource = null;
        }

        /// <summary>
        /// Обработчик события клика по ячейке в таблице заказов.
        /// Заполняет элементы управления данными выбранного заказа.
        /// </summary>
        private void dataGridViewOrderCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewOrder.Rows[e.RowIndex];

                textBoxIdOrder.Text = row.Cells["Id"].Value.ToString();
                textBoxCreatedOrder.Text = row.Cells["Created"].Value.ToString();
                textBoxAmountInOrder.Text = row.Cells["Price"].Value.ToString();
                comboBoxStatusOrder.Text = row.Cells["OrderStatus"].Value.ToString();
                textBoxTotalOrder.Text = row.Cells[6].Value.ToString();

                string address = row.Cells[4].Value.ToString();
                var individualStrings = address.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                addressControlInOrder.PostIndex = individualStrings[0];
                addressControlInOrder.Country = individualStrings[1];
                addressControlInOrder.City = individualStrings[2];
                addressControlInOrder.Street = individualStrings[3];
                addressControlInOrder.Building = individualStrings[4];
                addressControlInOrder.Apartament = individualStrings[5];


                DateTime date = (DateTime)row.Cells[1].Value;
                int id = Convert.ToInt32(row.Cells[0].Value);

                for (int j = 0; j < _customers.Count; j++)
                {
                    if (_customers[j].Id == id)
                    {
                        if (_customers[j].IsPriority == true)
                        {
                            dataPanelOrder.Visible = true;
                            comboBoxTimeOrder.Text = _customers[j].Time;
                        }
                        else
                        {
                            dataPanelOrder.Visible = false;
                        }

                        if (_customers[j].Orders.Count > 1)
                        {
                            for (int k = 0; k < _customers[j].Orders.Count; k++)
                            {
                                if (_customers[j].Orders[k].Date == date)
                                {
                                    listBoxItemsInOrder.DataSource = null;
                                    listBoxItemsInOrder.DataSource = _customers[j].Orders[k].Items;
                                    break;
                                }
                            }

                            break;
                        }

                        if (_customers[j].Orders.Count == 1)
                        {
                            listBoxItemsInOrder.DataSource = null;
                            listBoxItemsInOrder.DataSource = _customers[j].Orders[0].Items;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного статуса заказа.
        /// Обновляет статус заказа в модели и обновляет таблицу заказов.
        /// </summary>
        private void comboBoxStatusOrderSelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrder.RowCount > 0 && comboBoxStatusOrder.SelectedItem != null)
            {
                DateTime comboDate = (DateTime)dataGridViewOrder.SelectedCells[1].Value;

                for (int i = 0; i < _customers.Count; i++)
                {
                    if (_customers[i].Orders.Count >= 1)
                    {
                        for (int j = 0; j < _customers[i].Orders.Count; j++)
                        {
                            if (_customers[i].Orders[j].Date == comboDate)
                            {
                                _customers[i].Orders[j].Status = (OrderStatus)comboBoxStatusOrder.SelectedItem;
                                UpdateOrders();
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Обрабатывает изменение выбранного элемента в комбобоксе времени заказа.
        /// </summary>
        private void comboBoxTimeOrderSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTimeOrder.SelectedItem != null)
            {
                foreach (var time in Customers)
                {
                    time.Time = comboBoxTimeOrder.SelectedItem.ToString();
                }
            }

            UpdateOrders();
        }
    }
}
