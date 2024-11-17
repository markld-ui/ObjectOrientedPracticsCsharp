using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Делегат для фильтрации объектов типа <see cref="Item"/> по заданным критериям.
    /// </summary>
    /// <param name="item">Экземпляр объекта типа <see cref="Item"/>, который требуется проверить на соответствие критериям.</param>
    /// <returns>Возвращает <c>true</c>, если объект удовлетворяет критериям; в противном случае <c>false</c>.</returns>
    public delegate bool FilterItemByCriteria(Item item);

    /// <summary>
    /// Класс, предоставляющий набор вспомогательных методов для работы с данными.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Список возможных вариантов сортировки для элементов, отображаемый в <see cref="ComboBox"/>.
        /// </summary>
        public static List<string> ComboBoxSorted = new List<string>
        {
            "Name",
            "Cost (Ascending)",
            "Cost (Descending)"
        };

        // Фильтрация с 3го по 7й пункт

        /// <summary>
        /// Выполняет фильтрацию списка элементов на основе переданного критерия.
        /// </summary>
        /// <param name="items">Список объектов <see cref="Item"/>, которые необходимо фильтровать.</param>
        /// <param name="criteria">
        /// Критерий фильтрации, реализованный в виде делегата <see cref="FilterItemByCriteria"/>.
        /// </param>
        /// <returns>Список объектов <see cref="Item"/>, соответствующих заданному критерию.</returns>
        public static List<Item> FilterItems(List<Item> items, FilterItemByCriteria criteria)
        {
            List<Item> filteredItems = new List<Item>();
            foreach (var item in items)
            {
                if (criteria(item))
                {
                    filteredItems.Add(item);
                }
            }
            return filteredItems;
        }

        /// <summary>
        /// Проверяет, превышает ли стоимость элемента заданный порог.
        /// </summary>
        /// <param name="item">Экземпляр объекта типа <see cref="Item"/>, стоимость которого требуется проверить.</param>
        /// <param name="threshold">Пороговое значение стоимости.</param>
        /// <returns>
        /// Возвращает <c>true</c>, если стоимость элемента больше порога; в противном случае <c>false</c>.
        /// </returns>
        public static bool IsPriceAboveThreshold(Item item, int threshold)
        {
            return item.Cost > threshold;
        }

        /// <summary>
        /// Проверяет, принадлежит ли элемент заданной категории.
        /// </summary>
        /// <param name="item">Экземпляр объекта типа <see cref="Item"/>, категорию которого требуется проверить.</param>
        /// <param name="category">Категория, с которой требуется сравнить элемент.</param>
        /// <returns>
        /// Возвращает <c>true</c>, если элемент принадлежит заданной категории; в противном случае <c>false</c>.
        /// </returns>
        public static bool IsInCategory(Item item, Category category)
        {
            return item.Category == category;
        }
    }
}
