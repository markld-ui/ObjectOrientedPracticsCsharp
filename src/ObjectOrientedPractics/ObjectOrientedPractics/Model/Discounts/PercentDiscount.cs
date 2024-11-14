using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.Model.Discounts
{
    /// <summary>
    /// Представляет систему процентной скидки для определенной категории товаров.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        private Category _category;
        private double _currentDiscount;
        private double _totalSpentInCategory;

        /// <summary>
        /// Категория, к которой применяется скидка.
        /// </summary>
        public Category Category
        {
            get
            {
                return _category;
            }
        }

        /// <summary>
        /// Текущий процент скидки.
        /// </summary>
        public double CurrentDiscount
        {
            get
            {
                return _currentDiscount;
            }
        }

        /// <summary>
        /// Информация о процентной скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная «{Category}» - {CurrentDiscount}%";
            }
        }

        /// <summary>
        /// Обновляет текущую скидку на основе общей суммы, потраченной в категории.
        /// </summary>
        private void UpdateDiscount()
        {
            if (_totalSpentInCategory >= 1000)
            {
                _currentDiscount = Math.Min(_currentDiscount + 1, 10);
                _totalSpentInCategory = 0;
            }
        }

        /// <summary>
        /// Вычисляет сумму скидки на основе стоимости товаров в категории.
        /// </summary>
        /// <param name="items">Список товаров, на которые будет применяться скидка.</param>
        /// <returns>Сумма скидки для товаров в категории.</returns>
        public double Calculate(List<Item> items)
        {
            double totalCategoryCost = items.Where(item => item.Category == _category).Sum(item => item.Cost);
            return totalCategoryCost * _currentDiscount / 100;
        }

        /// <summary>
        /// Применяет скидку к списку товаров и обновляет общую сумму, потраченную в категории.
        /// </summary>
        /// <param name="items">Список товаров, на которые будет применяться скидка.</param>
        /// <returns>Сумма примененной скидки.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            _totalSpentInCategory += items.Where(item => item.Category == _category).Sum(item => item.Cost);
            UpdateDiscount();
            return discount;
        }

        /// <summary>
        /// Обновляет общую сумму, потраченную в категории, без применения скидки.
        /// </summary>
        /// <param name="items">Список товаров, стоимость которых влияет на сумму.</param>
        public void Update(List<Item> items)
        {
            _totalSpentInCategory += items.Where(item => item.Category == _category).Sum(item => item.Cost);
            _totalSpentInCategory = 0;
        }

        /// <summary>
        /// Сравнивает текущий объект <see cref="PercentDiscount"/> с другим объектом <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="other">Другой объект <see cref="PercentDiscount"/> для сравнения.</param>
        /// <returns>Целое число, указывающее, является ли текущий объект меньше, равным или больше другого объекта.</returns>
        public int CompareTo(PercentDiscount other)
        {
            if (other == null) 
            { 
                return 1; 
            }

            return CurrentDiscount.CompareTo(other.CurrentDiscount);
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PercentDiscount"/> с заданной категорией и начальной скидкой.
        /// </summary>
        /// <param name="category">Категория, к которой применяется скидка.</param>
        /// <param name="initDiscount">Начальная процентная скидка (по умолчанию 1%).</param>
        public PercentDiscount(Category category, double initDiscount = 1)
        {
            _category = category;
            _currentDiscount = initDiscount;
            _totalSpentInCategory = 0;
        }
    }
}
