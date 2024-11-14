using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model.Enums;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Discounts;

namespace ObjectOrientedPractices.View.Tabs
{
    public partial class DiscountsTab : Form
    {
        public CustomersTab CustomersTabForm { get; set; }
        public DiscountsTab()
        {
            InitializeComponent();
            comboBoxCategoryDiscount.DataSource = Enum.GetValues(typeof(Category));
            comboBoxCategoryDiscount.SelectedItem = null;
        }

        private void buttonOkClick(object sender, EventArgs e)
        {
            if (comboBoxCategoryDiscount.SelectedItem != null)
            {
                PercentDiscount newDiscount = new PercentDiscount((Category)comboBoxCategoryDiscount.SelectedItem);
                CustomersTabForm.newDiscount = newDiscount;
                Close();
            }
            else
            {
                MessageBox.Show("Выберите категорию товара для скидки!");
            }
        }

        private void buttonCancelClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
