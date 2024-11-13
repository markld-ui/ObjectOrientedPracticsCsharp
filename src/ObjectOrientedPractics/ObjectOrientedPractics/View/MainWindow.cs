using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.View.Tabs;

namespace ObjectOrientedPractices
{
    public partial class MainWindow : Form
    {

        /// <summary>
        /// Основное окно приложения, представляющее главный интерфейс пользователя.
        /// Этот класс управляет загрузкой данных и взаимодействием с различными вкладками.
        /// </summary>
        private Store _store = new Store();

        /// <summary>
        /// Конструктор для инициализации компонентов главного окна.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            this.Load += MainWindow_Load;
        }

        /// <summary>
        /// Обработчик события загрузки окна. 
        /// Здесь инициализируются данные для различных вкладок.
        /// </summary>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
            cartsTab1.CurrentCustomer = _store.Customers;
            ordersTab1.Customers = _store.Customers;

            priorityOrdersTab1.Items = _store.Items;

            cartsTab1.InitializeItemsListBox();
            cartsTab1.InitializeCustomersComboBox();
        }

        /// <summary>
        /// Обработчик события изменения выбранного индекса вкладки.
        /// Обновляет данные на вкладках корзины и заказов.
        /// </summary>
        private void tabControl1SelectedIndexChanged(object sender, EventArgs e)
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

            cartsTab1.RefreshData();
            ordersTab1.RefreshData();
            ordersTab1.UpdateOrders();

            priorityOrdersTab1.RefreshDataPriority();
            UpdatePrirityOrder();
        }

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
    }
}
