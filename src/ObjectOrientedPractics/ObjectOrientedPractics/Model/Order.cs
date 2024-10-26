using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model
{
    public class Order
    {
        private readonly int _id;
        private readonly DateTime _date;
        private Address _address;
        private List<Item> _items;
        private OrderStatus _status;
        private double _amount;

        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
        }

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            private set { _items = value ?? new List<Item>(); } // Если null, создаем новый список
        }

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            private set { _address = value; }
        }

        /// <summary>
        /// Общая стоимость заказа.
        /// </summary>
        public double TotalPrice
        {
            get
            {
                double sum = 0.0;
                if (_items == null || _items.Count == 0)
                {
                    return 0.0;
                }
                foreach (Item item in _items)
                {
                    sum += item.Cost;
                }
                return sum;
            }
        }

        /// <summary>
        /// Статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Конструктор класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        public Order(Address address, List<Item> items, double amount)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Address = address;
            Items = items; 
            Status = OrderStatus.New;
            _amount = amount;
        }
    }
}
