using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.View.Tabs;

namespace ObjectOrientedPractices
{
    /// <summary>
    /// �������� ���� ����������, �������������� ������� ��������� ������������.
    /// ���� ����� ��������� ��������� ������ � ��������������� � ���������� ���������.
    /// </summary>
    public partial class MainWindow : Form
    {

        /// <summary>
        /// �������� ���� ����������, �������������� ������� ��������� ������������.
        /// ���� ����� ��������� ��������� ������ � ��������������� � ���������� ���������.
        /// </summary>
        private Store _store = new Store();

        /// <summary>
        /// ����������� ��� ������������� ����������� �������� ����.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
            cartsTab1.CurrentCustomer = _store.Customers;
            ordersTab1.Customers = _store.Customers;

            priorityOrdersTab1.Items = _store.Items;

            cartsTab1.InitializeItemsListBox();
            cartsTab1.InitializeCustomersComboBox();

            itemsTab1.ItemsChanged += DataChanged;
            cartsTab1.CartsChanged += DataChanged;
            customersTab1.CustomersChanged += DataChanged;
        }

        /// <summary>
        /// ���������� ������� ��������� ���������� ������� �������.
        /// ��������� ������ �� �������� ������� � �������.
        /// </summary>
        private void TabControl1SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var time in priorityOrdersTab1.Customers)
            {
                foreach (var customer in cartsTab1.CurrentCustomer)
                {
                    if (customer.IsPriority == true)
                    {
                        customer.Time = time.Time;
                    }
                }
            }

            RefreshData();
        }

        /// <summary>
        /// ��������� ������ ������������ ������� �� ������ ������� �������� � �������.
        /// ���� � ������� ���� ���������, �� ����������� � ������ ������������ �������.
        /// </summary>
        private void UpdatePrirityOrder()
        {
            if (priorityOrdersTab1.Customers.Count > 0)
            {
                return;
            }
            else
            {
                foreach (var priorityCustomer in cartsTab1.CurrentCustomer)
                {
                    if (priorityCustomer.IsPriority == true)
                    {
                        priorityOrdersTab1.Customers.Add(priorityCustomer);
                    }
                }
            }
        }

        /// <summary>
        /// ��������� ������ �� ���� �������� ����������.
        /// </summary>
        private void RefreshData()
        {
            cartsTab1.RefreshData();
            ordersTab1.RefreshData();
            ordersTab1.UpdateOrders();
            itemsTab1.StartedRefreshData();

            priorityOrdersTab1.RefreshDataPriority();
            UpdatePrirityOrder();
        }

        /// <summary>
        /// ���������� ������� ��������� ������.
        /// ���������� ��� ��������� ���������, �������� ��� ������.
        /// </summary>
        private void DataChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        /// <summary>
        /// ���������� ������� �������� ������ �� ������� ���������.
        /// ���������� ���������� ������ ��� �������.
        /// </summary>
        private void ItemsTab1Load(object sender, EventArgs e)
        {
            itemsTab1.StartedRefreshData();
        }
    }
}
