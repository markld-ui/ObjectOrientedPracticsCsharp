using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Класс Store представляет магазин, который управляет списками товаров и покупателей.
    /// Класс композирует объекты типа <see cref="Item"/> и <see cref="Customer"/>.
    /// </summary>
    public class Store
    {
        private List<Item> _items;
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает или задает список товаров магазина.
        /// Никогда не возвращает null; при попытке задать null создается пустой список.
        /// </summary>
        public List<Item> Items {
            get
            {  return _items;
            }
            set
            {
                _items = value ?? new List<Item>();
            }
        }

        /// <summary>
        /// Возвращает или задает список покупателей магазина.
        /// Никогда не возвращает null; при попытке задать null создается пустой список.
        /// </summary>
        public List<Customer> Customers {
            get
            {
                return _customers;
            }
            set
            { 
                _customers = value ?? new List<Customer>(); 
            }
        }

        /// <summary>
        /// Конструктор по умолчанию, инициализирует списки товаров и покупателей пустыми коллекциями.
        /// </summary>
        public Store() 
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }
    }
}
