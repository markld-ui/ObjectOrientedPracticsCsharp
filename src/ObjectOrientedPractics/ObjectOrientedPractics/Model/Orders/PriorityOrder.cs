using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model;

namespace ObjectOrientedPractices.Model.Orders
{

    /// <summary>
    /// Класс, представляющий приоритетный заказ, наследующий от класса Order.
    /// Приоритетные заказы имеют дополнительную информацию о дате и времени выполнения.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Дата приоритетного заказа.
        /// </summary>
        protected DateTime _priorityOrderDate;

        /// <summary>
        /// Время приоритетного заказа.
        /// </summary>
        protected string _priorityOrderTime;

        /// <summary>
        /// Список доступных временных интервалов для приоритетных заказов.
        /// </summary>
        private List<string> _priorityTimeData = new List<string>()
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        /// <summary>
        /// Свойство, представляющее дату приоритетного заказа.
        /// </summary>
        public DateTime PriorityOrderDate
        {
            get { return _priorityOrderDate; }
            set { _priorityOrderDate = value; }
        }

        /// <summary>
        /// Свойство, представляющее время приоритетного заказа.
        /// </summary>
        public string PriorityOrderTime
        {
            get { return _priorityOrderTime; }
            set { _priorityOrderTime = value; }
        }

        /// <summary>
        /// Получает список строк, содержащий данные о времени приоритетной доставки.
        /// </summary>
        public List<string> PriorityTimeData
        {
            get
            {
                return _priorityTimeData;
            }
        }

        /// <summary>
        /// Конструктор для создания приоритетного заказа с заданным адресом, списком товаров и суммой.
        /// Инициализирует дату приоритетного заказа текущей датой.
        /// </summary>
        /// <param name="address">Адрес для доставки заказа.</param>
        /// <param name="items">Список товаров в заказе.</param>
        /// <param name="x">Сумма заказа.</param>
        public PriorityOrder(Address address, List<Item> items, double x) : base(address, items, x)
        {
            PriorityOrderDate = DateTime.Today;
            PriorityOrderTime = null;
        }

        /// <summary>
        /// Конструктор по умолчанию для создания экземпляра класса PriorityOrder.
        /// </summary>
        public PriorityOrder()
        {

        }
    }
}
