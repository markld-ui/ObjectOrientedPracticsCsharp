using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Класс Store представляет магазин, который управляет списками товаров и покупателей.
    /// Класс композирует объекты типа <see cref="Item"/> и <see cref="Customer"/>.
    /// </summary>
    public class Store
    {
        private List<Item> _items = new List<Item>();
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Конструктор по умолчанию, инициализирует списки товаров и покупателей пустыми коллекциями.
        /// </summary>
        public Store()
        {
            _items.Add(new Item("Ковер", "Синтетика", 100, Category.Household));
            _items.Add(new Item("Шапка", "Шерсть", 300, Category.Household));
            _items.Add(new Item("Арбуз", "Свежий", 500, Category.Vegetables));
            _customers.Add(new Customer("Слиньков Роман Викторович", 1, "Россия", "Екатеринбург", "Ленина", "1", "194"));
            _customers.Add(new Customer("Слиньков Виктор Владимирович", 2, "Россия", "Екатеринбург", "Молодогвардейцев", "29", "1"));
            _customers[1].IsPriority = true;
        }

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
    }
}
