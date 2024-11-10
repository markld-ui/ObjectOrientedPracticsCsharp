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
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {

        public List<Customer> CurrentCustomer = new List<Customer>();

        public List<Customer> Customers { get; set; }
        public List<Item> Items { get; set; }

        public void RefreshData()
        {
            listBoxCartItems.DataSource = null;
            listBoxCartItems.DataSource = Items;
            listBoxCartItems.DisplayMember = "Name";

            comboBoxCustomerInCart.DataSource = null;
            comboBoxCustomerInCart.DataSource = Customers;
            comboBoxCustomerInCart.DisplayMember = "FullName";
        }

        public void InitializeItemsListBox()
        {
            listBoxCartItems.Items.Clear();
            foreach (var item in Items)
            {
                listBoxCartItems.Items.Add($"{item.Name} - {item.Cost}");
            }
        }

        public void InitializeCustomersComboBox()
        {
            comboBoxCustomerInCart.Items.Clear();
            foreach (var customer in Customers)
            {
                comboBoxCustomerInCart.Items.Add($"{customer.FullName} - {customer.Address.City}");
            }
        }

        private void UpdateCartItemsListBox()
        {
            int comboIndex = comboBoxCustomerInCart.SelectedIndex;
            listBoxCartOrder.Items.Clear();

            if (CurrentCustomer != null && CurrentCustomer[comboIndex].Cart != null)
            {
                foreach (var item in CurrentCustomer[comboIndex].Cart.Items)
                {
                    listBoxCartOrder.Items.Add(item);
                }
            }
        }

        public CartsTab()
        {
            InitializeComponent();

        }

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

        private void comboBoxCustomerInCartSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCustomerInCart.SelectedItem != null)
            {
                int comboIndex = comboBoxCustomerInCart.SelectedIndex;
                textBoxAmount.Text = CurrentCustomer[comboIndex].Cart.Amount.ToString();
            }
        }

        private void buttonCreateOrderClick(object sender, EventArgs e)
        {
            if (listBoxCartOrder.Items.Count > 0)
            {
                int comboIndex = comboBoxCustomerInCart.SelectedIndex;
                List<Item> orderlist = new List<Item>();
                Order order = new Order(CurrentCustomer[comboIndex].Address, orderlist, Convert.ToDouble(CurrentCustomer[comboIndex].Cart.Amount));
                orderlist.AddRange(CurrentCustomer[comboIndex].Cart.Items);
                CurrentCustomer[comboIndex].Orders.Add(order);

                listBoxCartOrder.Items.Clear();
                CurrentCustomer[comboIndex].Cart.Items.Clear();
                textBoxAmount.Text = "0";
                MessageBox.Show("Order has been created!");

            }
            else
            {
                MessageBox.Show("Корзина пользователя пуста! Заказ нечем наполнить!");
            }
        }
    }
}
