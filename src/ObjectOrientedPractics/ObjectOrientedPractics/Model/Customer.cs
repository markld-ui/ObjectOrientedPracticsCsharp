using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectOrientedPractices.Exceptions;
using ObjectOrientedPractices.Services;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Класс для представления клиента, который может добавляться в базу данных.
    /// Взаимодействие с объектом осуществляется через свойства. Поле ID является уникальным и автоматически генерируется.
    /// </summary> 
    public class Customer
    {
        private readonly int _id;
        private string _fullname;
        private Address _address;
        private Cart _cart;

        /// <summary>
        /// Уникальный идентификатор клиента.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Полное имя клиента.
        /// </summary>
        /// <exception cref="StringLengthException">
        /// Выбрасывается, если строка <paramref name="FullName"/> пуста или превышает допустимую длину.
        /// </exception>
        public string FullName
        { 
            get {return _fullname;}
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 200, 0, nameof(FullName));
                    _fullname = value;
                }
                catch (StringLengthException)
                {
                    throw new StringLengthException(nameof(FullName), 200, 0);
                }
            }
        }

        /// <summary>
        /// Адрес клиента.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// Выбрасывается, если строка <paramref name="Address"/> пуста или превышает допустимую длину.
        /// </exception>
        public Address Address
        {
            get { return _address; }
            private set
            {
                _address = value ?? throw new ArgumentNullException(nameof(Address), "Адресс не может быть null");
            }
        }

        /// <summary>
        /// Корзина клиента.
        /// </summary>
        /// <exception cref="NullReferenceException">
        /// Выбрасывается, если корзина <paramref name="Cart"/> не существует.
        /// </exception>
        public Cart Cart
        {
            get => _cart;
            set
            {
                _cart = value ?? throw new NullReferenceException(nameof(Cart));
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/> с заданными параметрами.
        /// </summary>
        /// <param name="fullname">Полное имя клиента. Передается в свойство <see cref="FullName"/>.</param>
        /// <param name="index">Индекс адреса.</param>
        /// <param name="country">Страна адреса.</param>
        /// <param name="city">Город адреса.</param>
        /// <param name="street">Улица адреса.</param>
        /// <param name="building">Здание адреса.</param>
        /// <param name="apartament">Квартира адреса.</param>
        public Customer(string fullname, int index, string country, string city, string street, string building, string apartament)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullname;
            Cart = new Cart();
            Address = new Address(
                index,
                country, 
                city, 
                street, 
                building, 
                apartament
                );
        }
    }
}
