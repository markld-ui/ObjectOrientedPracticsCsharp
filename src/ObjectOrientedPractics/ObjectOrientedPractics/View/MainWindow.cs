using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.View.Tabs;

namespace ObjectOrientedPractices
{
    /// <summary>
    /// ќсновное окно приложени€, представл€ющее главный интерфейс пользовател€.
    /// Ётот класс управл€ет загрузкой данных и взаимодействием с различными вкладками.
    /// </summary>
    public partial class MainWindow : Form
    {

        /// <summary>
        /// ќсновное окно приложени€, представл€ющее главный интерфейс пользовател€.
        /// Ётот класс управл€ет загрузкой данных и взаимодействием с различными вкладками.
        /// </summary>
        private Store _store = new Store();

        /// <summary>
        ///  онструктор дл€ инициализации компонентов главного окна.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Load += MainWindow_Load;
        }

        /// <summary>
        /// ќбработчик событи€ загрузки окна. 
        /// «десь инициализируютс€ данные дл€ различных вкладок.
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
        /// ќбработчик событи€ изменени€ выбранного индекса вкладки.
        /// ќбновл€ет данные на вкладках корзины и заказов.
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

        /// <summary>
        /// ќбновл€ет список приоритетных заказов на основе текущих клиентов в корзине.
        /// ≈сли у клиента есть приоритет, он добавл€етс€ в список приоритетных заказов.
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
    }
}
