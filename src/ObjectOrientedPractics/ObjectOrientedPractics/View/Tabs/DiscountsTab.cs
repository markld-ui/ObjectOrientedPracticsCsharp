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
    /// <summary>
    /// Вкладка для управления скидками, позволяет добавлять новые скидки для клиентов.
    /// </summary>
    public partial class DiscountsTab : Form
    {
        /// <summary>
        /// Ссылка на форму управления клиентами, используется для передачи новой скидки.
        /// </summary>
        public CustomersTab CustomersTabForm { get; set; }

        /// <summary>
        /// Конструктор по умолчанию, инициализирующий вкладку DiscountsTab.
        /// </summary>
        public DiscountsTab()
        {
            InitializeComponent();
            comboBoxCategoryDiscount.DataSource = Enum.GetValues(typeof(Category));
            comboBoxCategoryDiscount.SelectedItem = null;
        }

        /// <summary>
        /// Обрабатывает событие клика по кнопке "ОК". Проверяет, выбрана ли категория скидки,
        /// и если да, создаёт новую скидку и передаёт её в форму управления клиентами.
        /// </summary>
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

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Отмена". Закрывает текущую форму без изменений.
        /// </summary>
        private void buttonCancelClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
