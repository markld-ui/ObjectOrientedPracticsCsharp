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

        private List<Customer> _currentCustomer = new List<Customer>();
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

            UpdateListBoxCartItems();
        }

        private void UpdateListBoxCartItems()
        {
            listBoxCartItems.Items.Clear(); // Очищаем текущий список
            foreach (var item in Items)
            {
                listBoxCartItems.Items.Add(item); // Добавляем товары в ListBox
            }
        }

        public CartsTab()
        {
            InitializeComponent();
        }

        private void buttonClearCartMouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void buttonAddToCartClick(object sender, EventArgs e)
        {
        }
    }
}
