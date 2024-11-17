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
using ObjectOrientedPractices.Model.Enums;
using System.Xml.Linq;

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Вкладка управления элементами, содержит логику для добавления, 
    /// удаления и отображения элементов.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        public event EventHandler ItemsChanged;

        /// <summary>
        /// Список всех добавленных элементов.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Список всех отображаемых элементов.
        /// </summary>
        private List<Item> _displayedItems = new();

        /// <summary>
        /// Конструктор по умолчанию, инициализирующий вкладку ItemsTab.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            comboBoxCategoryItems.DataSource = Enum.GetValues(typeof(Category));
            comboBoxCategoryItems.SelectedItem = null;
            comboBoxOrderBy.DataSource = DataTools.ComboBoxSorted;

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
            }
        }

        /// <summary>
        /// Событие срабатывает при изменении данных во вкладке товаров.
        /// </summary>
        protected virtual void OnItemsChanged() => ItemsChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Обновляет список элементов в ListBox с учётом фильтра и сортировки.
        /// </summary>
        private void UpdateDisplayedItems()
        {

            var filteredItems = DataTools.FilterItems(Items, item =>
                            item.Name.ToLower().Contains(textBoxFindItem.Text.ToLower()))
                            .OrderBy(item => item.Name, StringComparer.CurrentCulture)
                            .ToList();

            switch (comboBoxOrderBy.SelectedItem)
            {
                case "Name":
                    break;
                case "Cost (Ascending)":
                    filteredItems = filteredItems.OrderBy(item => item.Cost).ToList();
                    break;
                case "Cost (Descending)":
                    filteredItems = filteredItems.OrderByDescending(item => item.Cost).ToList();
                    break;
            }

            _displayedItems = filteredItems;
            listBoxItems.DataSource = null;
            listBoxItems.DataSource = _displayedItems;
            OnItemsChanged();
        }

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Добавить". Выполняет проверку 
        /// введённых данных, создаёт новый элемент и добавляет его в список.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события клика мышью.</param>
        private void AddBtnItemsMouseClick(object sender, MouseEventArgs e)
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
                _displayedItems.Add(item);
                OnItemsChanged();

                textBoxCostItems.BackColor = Color.White;
                textBoxDescrItems.BackColor = Color.White;
                textBoxNameItems.BackColor = Color.White;

                textBoxCostItems.Clear();
                textBoxDescrItems.Clear();
                textBoxIdItems.Clear();
                textBoxNameItems.Clear();
                comboBoxCategoryItems.SelectedItem = null;
                UpdateDisplayedItems();

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
        private void RemoveBtnItemsMouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxItems.SelectedIndex != -1)
            {
                int index = listBoxItems.SelectedIndex;

                if (textBoxFindItem.TextLength > 0)
                {
                    _displayedItems.RemoveAt(index);
                    int indexOfFind = Items.IndexOf((Item)listBoxItems.SelectedItem);
                    _items.RemoveAt(indexOfFind);
                }
                else 
                {
                    int indexOfFind = Items.IndexOf((Item)listBoxItems.SelectedItem);
                    _items.RemoveAt(indexOfFind);
                }

                UpdateDisplayedItems();
                OnItemsChanged();

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
        private void ListBoxItemsMouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxItems.SelectedIndex != -1)
            {
                int index = listBoxItems.SelectedIndex;
                if (textBoxFindItem.TextLength > 0)
                {
                    int indexOfFind = _items.IndexOf((Item)listBoxItems.SelectedItem);

                    Item selectedItem = _items[indexOfFind];

                    textBoxNameItems.Text = selectedItem.Name;
                    textBoxDescrItems.Text = selectedItem.Info;
                    textBoxCostItems.Text = selectedItem.Cost.ToString();
                    textBoxIdItems.Text = selectedItem.Id.ToString();
                    comboBoxCategoryItems.SelectedItem = selectedItem.Category;

                }
                else
                {
                    int indexOfFind = _items.IndexOf((Item)listBoxItems.SelectedItem);

                    Item selectedItem = _items[indexOfFind];

                    textBoxNameItems.Text = selectedItem.Name;
                    textBoxDescrItems.Text = selectedItem.Info;
                    textBoxCostItems.Text = selectedItem.Cost.ToString();
                    textBoxIdItems.Text = selectedItem.Id.ToString();
                    comboBoxCategoryItems.SelectedItem = selectedItem.Category;
                }
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
        /// Обрабатывает событие изменения текста в текстовом поле.
        /// Фильтрует и сортирует элементы в зависимости от введенного текста и выбранного параметра сортировки.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void TextBoxFindItemTextChanged(object sender, EventArgs e)
        {
            string name = textBoxFindItem.Text;

            if (textBoxFindItem.TextLength > 0 && comboBoxOrderBy.Text == DataTools.ComboBoxSorted[0])
            {
                List<Item> newItems = new List<Item>(Items);

                var filtredItems = DataTools.FilterItems(Items, item =>
                item.Name.ToLower().Contains(textBoxFindItem.Text.ToLower()))
                .OrderBy(item => item.Name, StringComparer.CurrentCulture)
                .ToList();

                _displayedItems.Clear();
                _displayedItems.AddRange(filtredItems);
                listBoxItems.DataSource = null;
                listBoxItems.DataSource = _displayedItems;

            }

            if (textBoxFindItem.TextLength > 0 && comboBoxOrderBy.Text == DataTools.ComboBoxSorted[1])
            {
                List<Item> newItems = new List<Item>(Items);

                var filtredItems = DataTools.FilterItems(newItems, item =>
                item.Name.ToLower().Contains(name));

                filtredItems = filtredItems.OrderBy(item => item.Cost).ToList();
                _displayedItems.Clear();
                _displayedItems.AddRange(filtredItems);
                listBoxItems.DataSource = null;
                listBoxItems.DataSource = _displayedItems;

            }

            if (textBoxFindItem.TextLength > 0 && comboBoxOrderBy.Text == DataTools.ComboBoxSorted[2])
            {
                List<Item> newItems = new List<Item>(Items);

                var filtredItems = DataTools.FilterItems(newItems, item =>
                item.Name.ToLower().Contains(name));
                filtredItems = filtredItems.OrderByDescending(item => item.Cost).ToList();

                _displayedItems.Clear();
                _displayedItems.AddRange(filtredItems);
                listBoxItems.DataSource = null;
                listBoxItems.DataSource = _displayedItems;

            }

            if (textBoxFindItem.TextLength == 0 && comboBoxOrderBy.Text == DataTools.ComboBoxSorted[0])
            {
                var filtredItems = DataTools.FilterItems(Items, item =>
                item.Name.ToLower().Contains(textBoxFindItem.Text.ToLower()))
                .OrderBy(item => item.Name, StringComparer.CurrentCulture)
                .ToList();

                _displayedItems.Clear();
                _displayedItems.AddRange(filtredItems);
                listBoxItems.DataSource = null;
                listBoxItems.DataSource = _displayedItems;
            }

            if (textBoxFindItem.TextLength == 0 && comboBoxOrderBy.Text == DataTools.ComboBoxSorted[1])
            {
                var filtredItems = DataTools.FilterItems(Items, item =>
                item.Name.ToLower().Contains(name));
                filtredItems = filtredItems.OrderBy(item => item.Cost).ToList();

                _displayedItems.Clear();
                _displayedItems.AddRange(filtredItems);
                listBoxItems.DataSource = null;
                listBoxItems.DataSource = _displayedItems;
            }

            if (textBoxFindItem.TextLength == 0 && comboBoxOrderBy.Text == DataTools.ComboBoxSorted[2])
            {
                var filtredItems = DataTools.FilterItems(Items, item =>
                item.Name.ToLower().Contains(name));
                filtredItems = filtredItems.OrderByDescending(item => item.Cost).ToList();

                _displayedItems.Clear();
                _displayedItems.AddRange(filtredItems);
                listBoxItems.DataSource = null;
                listBoxItems.DataSource = _displayedItems;
            }

            UpdateDisplayedItems();
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранного элемента в комбобоксе сортировки.
        /// Обновляет отображение элементов в зависимости от выбранного критерия сортировки.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ComboBoxOrderBySelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOrderBy.SelectedIndex != null)
            {
                _displayedItems.Clear();

                if (comboBoxOrderBy.Text == DataTools.ComboBoxSorted[0])
                {
                    if (textBoxFindItem.TextLength > 0)
                    {
                        List<Item> newItems = new List<Item>();
                        foreach (var item in listBoxItems.Items)
                        {
                            newItems.Add((Item)item);
                        }

                        _displayedItems = DataTools.FilterItems(newItems, item =>
                            item.Name.ToLower().Contains(textBoxFindItem.Text.ToLower()))
                            .OrderBy(item => item.Name, StringComparer.CurrentCulture)
                            .ToList();
                    }
                    else
                    {
                        _displayedItems = DataTools.FilterItems(Items, item =>
                            item.Name.ToLower().Contains(textBoxFindItem.Text.ToLower()))
                            .OrderBy(item => item.Name, StringComparer.CurrentCulture)
                            .ToList();
                    }

                    listBoxItems.DataSource = null;
                    listBoxItems.DataSource = _displayedItems;
                }

                if (comboBoxOrderBy.Text == DataTools.ComboBoxSorted[1])
                {
                    if (textBoxFindItem.TextLength > 0)
                    {
                        List<Item> newItems = new List<Item>();
                        foreach (var item in listBoxItems.Items)
                        {
                            newItems.Add((Item)item);
                        }

                        var filtredItems = DataTools.FilterItems(newItems, item =>
                            item.Name.ToLower().Contains(textBoxFindItem.Text));

                        filtredItems = filtredItems.OrderBy(item => item.Cost).ToList();

                        _displayedItems.AddRange(filtredItems);
                    }
                    else
                    {
                        var filtredItems = DataTools.FilterItems(Items, item =>
                            item.Name.ToLower().Contains(textBoxFindItem.Text));

                        filtredItems = filtredItems.OrderBy(item => item.Cost).ToList();

                        _displayedItems.AddRange(filtredItems);
                    }

                    listBoxItems.DataSource = null;
                    listBoxItems.DataSource = _displayedItems;
                }

                if (comboBoxOrderBy.Text == DataTools.ComboBoxSorted[2])
                {
                    if (textBoxFindItem.TextLength > 0)
                    {
                        List<Item> newItems = new List<Item>();
                        foreach (var item in listBoxItems.Items)
                        {
                            newItems.Add((Item)item);
                        }

                        var filtredItems = DataTools.FilterItems(newItems, item =>
                            item.Name.ToLower().Contains(textBoxFindItem.Text));
                        filtredItems = filtredItems.OrderByDescending(item => item.Cost).ToList();

                        _displayedItems.AddRange(filtredItems);
                    }
                    else
                    {
                        var filtredItems = DataTools.FilterItems(Items, item =>
                            item.Name.ToLower().Contains(textBoxFindItem.Text));
                        filtredItems = filtredItems.OrderByDescending(item => item.Cost).ToList();

                        _displayedItems.AddRange(filtredItems);
                    }

                    listBoxItems.DataSource = null;
                    listBoxItems.DataSource = _displayedItems;
                }
            }

            UpdateDisplayedItems();
        }

        /// <summary>
        /// Обновляет данные в списке элементов, применяя фильтрацию и сортировку 
        /// в начале работы программы.
        /// </summary>
        public void StartedRefreshData()
        {
            _displayedItems = DataTools.FilterItems(Items, item =>
                item.Name.ToLower().Contains(textBoxFindItem.Text.ToLower()))
                .OrderBy(item => item.Name, StringComparer.CurrentCulture)
                .ToList();
            listBoxItems.DataSource = null;
            listBoxItems.DataSource = _displayedItems;
        }
    }
}
