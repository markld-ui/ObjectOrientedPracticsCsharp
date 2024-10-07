using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Класс для представления клиента, который может добавляться в базу данных.
    /// Взаимодействие с объектом осуществляется через свойства. Поле ID является уникальным и автоматически генерируется.
    /// </summary> 
    public class Customer
    {
        private readonly int _id;
        private string? _fullname;
        private Address? _address;

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
        /// <exception cref="Exception">
        /// Выбрасывается, если строка <paramref name="FullName"/> пуста или превышает допустимую длину.
        /// </exception>
        public string? FullName
        { 
            get {return _fullname;}
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 200, 0, nameof(FullName));
                    _fullname = value;
                }
                catch (Exception)
                {

                    throw new Exception($"Неверные данные для {nameof(FullName)}");
                }
            }
        }

        /// <summary>
        /// Адрес клиента.
        /// </summary>
        /// <exception cref="Exception">
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
        /// Инициализирует новый экземпляр класса <see cref="Customer"/> с заданными параметрами.
        /// </summary>
        /// <param name="fullname">Полное имя клиента. Передается в свойство <see cref="FullName"/>.</param>
        /// <param name="address">Адрес клиента. Передается в свойство <see cref="Address"/>.</param>
        public Customer(string? fullname, Address address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullname;
            Address = address;

        }
    }
}
