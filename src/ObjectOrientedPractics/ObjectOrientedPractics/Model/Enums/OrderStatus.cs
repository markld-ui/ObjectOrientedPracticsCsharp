using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Enums
{
    /// <summary>
    /// Перечисление, представляющее возможные статусы заказа.
    /// Используется для отслеживания текущего состояния заказа в процессе обработки.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Новый заказ, который только что был создан.
        /// </summary>
        New,

        /// <summary>
        /// Заказ в процессе обработки.
        /// </summary>
        Processing,

        /// <summary>
        /// Заказ собирается (например, товары подбираются для отправки).
        /// </summary>
        Assembly,

        /// <summary>
        /// Заказ отправлен клиенту.
        /// </summary>
        Sent,

        /// <summary>
        /// Заказ был доставлен клиенту.
        /// </summary>
        Delivered,

        /// <summary>
        /// Заказ был возвращен клиентом.
        /// </summary>
        Returned,

        /// <summary>
        /// Заказ был заброшен (например, клиент отменил его).
        /// </summary>
        Abandoned
    }
}
