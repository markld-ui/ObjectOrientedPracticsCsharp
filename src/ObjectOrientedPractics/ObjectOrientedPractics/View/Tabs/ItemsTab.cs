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
using ObjectOrientedPractices.Services;
using ObjectOrientedPractices.Exceptions;

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Вкладка управления элементами, содержит логику для добавления, 
    /// удаления и отображения элементов.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список всех добавленных элементов.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Конструктор по умолчанию, инициализирующий вкладку ItemsTab.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            comboBoxCategoryItems.DataSource = Enum.GetValues(typeof(Category));
            comboBoxCategoryItems.SelectedItem = null;

        }

        /// <summary>
        /// Возвращает или задает список элементов, отображаемых на вкладке Items.
        /// </summary>
        public List<Item> Items
        {
            get
            { 
                return _items; 
            }
            set
            {
                _items = value;
                UpdateItemsListBox();
            }
        }

        public void RefreshData()
        {
            listBoxItems.DataSource = null;
            listBoxItems.DataSource = _items;

        }

        /// <summary>
        /// Метод обновновления списка предметов
        /// </summary>
        private void UpdateItemsListBox()
        {
            listBoxItems.Items.Clear();
            foreach (var item in _items)
            {
                listBoxItems.Items.Add(item.Name);
            }
        }

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Добавить". Выполняет проверку 
        /// введённых данных, создаёт новый элемент и добавляет его в список.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события клика мышью.</param>
        private void addBtnItemsMouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                ValueValidator.AssertStringOnLength(textBoxNameItems.Text, 200, 0, "Name");
                ValueValidator.AssertStringOnLength(textBoxDescrItems.Text, 1000, 0, "Info");

                if (!double.TryParse(textBoxCostItems.Text, out double cost))
                {
                    MessageBox.Show("Неверный формат стоимости или поле пусто. Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCostItems.BackColor = ColorTranslator.FromHtml("#DC143C");
                    textBoxCostItems.Clear();
                    return;
                }
                if (cost <= 0)
                {
                    MessageBox.Show("Цена не может быть отрицательной или равна нулю. Введите корректную цену.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCostItems.BackColor = ColorTranslator.FromHtml("#DC143C");
                    textBoxCostItems.Clear();
                    return;
                }

                Category category = (Category)comboBoxCategoryItems.SelectedItem;

                Item item = new(textBoxNameItems.Text, textBoxDescrItems.Text, cost, category);

                _items.Add(item);
                listBoxItems.Items.Add($"{item.Name} - {item.Cost}");

                textBoxCostItems.BackColor = Color.White;
                textBoxDescrItems.BackColor = Color.White;
                textBoxNameItems.BackColor = Color.White;

                textBoxCostItems.Clear();
                textBoxDescrItems.Clear();
                textBoxIdItems.Clear();
                textBoxNameItems.Clear();
                comboBoxCategoryItems.SelectedItem = null;

            }
            catch (StringLengthException)
            {
                MessageBox.Show("Длина поля меньше или превышает допустимое значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCostItems.BackColor = ColorTranslator.FromHtml("#DC143C");
                textBoxDescrItems.BackColor = ColorTranslator.FromHtml("#DC143C");
                textBoxNameItems.BackColor = ColorTranslator.FromHtml("#DC143C");

                textBoxCostItems.Clear();
                textBoxDescrItems.Clear();
                textBoxIdItems.Clear();
                textBoxNameItems.Clear();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Цена слишком высока", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCostItems.BackColor = ColorTranslator.FromHtml("#DC143C");
                textBoxCostItems.Clear();
            }
        }
       
        /// <summary>
        /// Обрабатывает событие клика по кнопке "Удалить". Удаляет выбранный элемент
        /// из списка и обновляет интерфейс.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события клика мышью.</param>
        private void removeBtnItemsMouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxItems.SelectedIndex != -1)
            {
                int index = listBoxItems.SelectedIndex;
                _items.RemoveAt(index);
                listBoxItems.Items.RemoveAt(index);
                MessageBox.Show("Элемент успешно удален", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxCostItems.Clear();
                textBoxDescrItems.Clear();
                textBoxIdItems.Clear();
                textBoxNameItems.Clear();
                comboBoxCategoryItems.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обрабатывает событие клика по элементу списка. Заполняет поля данными 
        /// выбранного элемента.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события клика мышью.</param>
        private void listBoxItemsMouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxItems.SelectedIndex != -1)
            {
                int index = listBoxItems.SelectedIndex;
                Item selectedItem = _items[index];

                textBoxNameItems.Text = selectedItem.Name;
                textBoxDescrItems.Text = selectedItem.Info;
                textBoxCostItems.Text = selectedItem.Cost.ToString();
                textBoxIdItems.Text = selectedItem.Id.ToString();
                comboBoxCategoryItems.SelectedItem = selectedItem.Category;
            }
            else
            {
                ClearFields();
            }
        }

        /// <summary>
        /// Очищает все поля ввода.
        /// </summary>
        private void ClearFields()
        {
            textBoxNameItems.Clear();
            textBoxDescrItems.Clear();
            textBoxCostItems.Clear();
            textBoxIdItems.Clear();
            comboBoxCategoryItems.SelectedItem = null;
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранного элемента в комбобоксе.
        /// </summary>
        private void comboBoxCategoryItemsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex != -1)
            {
                int index = listBoxItems.SelectedIndex;
                Item selectedItem = _items[index];

                selectedItem.Category = (Category)comboBoxCategoryItems.SelectedItem;
            }
        }
    }
}
