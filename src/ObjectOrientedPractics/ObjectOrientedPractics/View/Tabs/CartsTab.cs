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
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {

        private List<Item> _items;

        private List<Customer> _customers;

        private List<Customer> _currentCustomer = new List<Customer>();

        public List<Customer> Customers { get; set; }
        public List<Item> Items { get; set; }

        public void RefreshData()
        {
            listBoxCartItems.DataSource = null;
            listBoxCartItems.DataSource = _items;
            comboBoxCustomerInCart.DataSource = null;
            comboBoxCustomerInCart.DataSource = _customers;
        }

        public CartsTab()
        {
            InitializeComponent();
        }

        private void buttonClearCartMouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
