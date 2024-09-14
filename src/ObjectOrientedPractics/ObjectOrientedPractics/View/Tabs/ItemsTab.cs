using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Exceptions;

namespace ObjectOrientedPractics.View.Tabs
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
        }

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Добавить". Выполняет проверку 
        /// введённых данных, создаёт новый элемент и добавляет его в список.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события клика мышью.</param>
        private void add_btn_items_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                ValueValidator.AssertStringOnLength(textBox_name_items.Text, 200, 0, "Name");
                ValueValidator.AssertStringOnLength(textBox_descr_items.Text, 1000, 0, "Info");

                if (!double.TryParse(textBox_cost_items.Text, out double cost))
                {
                    MessageBox.Show("Неверный формат стоимости. Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_cost_items.Clear();
                    return;
                }
                if (cost < 0)
                {
                    MessageBox.Show("Неверный формат стоимости. Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_cost_items.Clear();
                    return;
                }

                string name = textBox_name_items.Text;
                string info = textBox_descr_items.Text;

                Item item = new(name, info, cost);

                _items.Add(item);
                listBox_items.Items.Add($"{item.Name} - {item.Cost}");

                textBox_cost_items.Clear();
                textBox_descr_items.Clear();
                textBox_id_items.Clear();
                textBox_name_items.Clear();

            }
            catch (StringMaxLengthException)
            {
                MessageBox.Show("Длина поля превышает допустимое значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_cost_items.Clear();
                textBox_descr_items.Clear();
                textBox_id_items.Clear();
                textBox_name_items.Clear();
            }
            catch (StringMinLengthException)
            {
                MessageBox.Show("Длина поля меньше допустимого значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_cost_items.Clear();
                textBox_descr_items.Clear();
                textBox_id_items.Clear();
                textBox_name_items.Clear();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Цена слишком высока", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_cost_items.Clear();
            }
        }

        /// <summary>
        /// Обрабатывает событие клика по кнопке "Удалить". Удаляет выбранный элемент
        /// из списка и обновляет интерфейс.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события клика мышью.</param>
        private void remove_btn_items_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox_items.SelectedIndex != -1)
            {
                int index = listBox_items.SelectedIndex;
                _items.RemoveAt(index);
                listBox_items.Items.RemoveAt(index);
                MessageBox.Show("Элемент успешно удален", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_cost_items.Clear();
                textBox_descr_items.Clear();
                textBox_id_items.Clear();
                textBox_name_items.Clear();
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
        private void listBox_items_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox_items.SelectedIndex != -1)
            {
                int index = listBox_items.SelectedIndex;
                Item selectedItem = _items[index];

                textBox_name_items.Text = selectedItem.Name;
                textBox_descr_items.Text = selectedItem.Info;
                textBox_cost_items.Text = selectedItem.Cost.ToString();
                textBox_id_items.Text = selectedItem.ID.ToString();
            }
        }
    }
}
