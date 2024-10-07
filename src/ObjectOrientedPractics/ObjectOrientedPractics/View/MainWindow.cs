using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.View.Tabs;

namespace ObjectOrientedPractices
{
    public partial class MainWindow : Form
    {
        private Store _store;
        public MainWindow()
        {
            InitializeComponent();
            _store = new Store();

            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
        }
    }
}
