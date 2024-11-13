using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Определяет контракт для классов, реализующих систему скидок.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Получает информацию о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Вычисляет сумму скидки на основе предоставленного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров, на которые будет применяться скидка.</param>
        /// <returns>Сумма скидки для указанных товаров.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку к указанному списку товаров и возвращает сумму примененной скидки.
        /// </summary>
        /// <param name="items">Список товаров, к которым будет применяться скидка.</param>
        /// <returns>Сумма примененной скидки.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет информацию о скидке на основе указанного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров, стоимость которых влияет на информацию о скидке.</param>
        void Update(List<Item> items);
    }
}
