﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model;

namespace ObjectOrientedPractices.Model.Discounts
{
    /// <summary>
    /// Представляет систему накопительных баллов для скидок.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        private int _points;

        /// <summary>
        /// Получает количество накопленных баллов.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                _points = value;
            }
        }

        /// <summary>
        /// Информация о накопительных баллах.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов.";
            }
        }

        /// <summary>
        /// Вычисляет максимальную скидку на основе накопленных баллов и стоимости товаров.
        /// </summary>
        /// <param name="items">Список товаров, на которые будет применяться скидка.</param>
        /// <returns>Максимальная скидка, которую можно применить.</returns>
        public double Calculate(List<Item> items)
        {
            double totalCost = items.Sum(item => item.Cost);
            double maxDiscount = Math.Min(totalCost * 0.3, Points);
            return Math.Min(maxDiscount, totalCost);
        }

        /// <summary>
        /// Применяет скидку к списку товаров и обновляет количество накопленных баллов.
        /// </summary>
        /// <param name="items">Список товаров, на которые будет применяться скидка.</param>
        /// <returns>Сумма примененной скидки.</returns>
        public double Apply(List<Item> items)
        {
            double totalCost = items.Sum(item => item.Cost);
            double maxDiscount = Math.Min(totalCost * 0.3, Points);
            Points -= (int)maxDiscount;
            return Math.Min(maxDiscount, totalCost);
        }

        /// <summary>
        /// Обновляет количество накопленных баллов на основе стоимости товаров.
        /// </summary>
        /// <param name="items">Список товаров, стоимость которых влияет на количество баллов.</param>
        public void Update(List<Item> items)
        {
            double totalCost = items.Sum(item => item.Cost);
            Points += (int)Math.Ceiling(totalCost * 0.1);
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PointsDiscount"/> с нулевым количеством баллов.
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }
    }
}
