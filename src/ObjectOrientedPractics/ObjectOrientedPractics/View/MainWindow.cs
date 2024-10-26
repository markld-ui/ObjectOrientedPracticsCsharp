using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.View.Tabs;

namespace ObjectOrientedPractices
{
    public partial class MainWindow : Form
    {
        private Store _store = new Store();
        public MainWindow()
        {
            InitializeComponent();

            this.Load += MainWindow_Load;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;

            cartsTab1.InitializeItemsListBox();
            cartsTab1.InitializeCustomersComboBox();
        }
    }
}
