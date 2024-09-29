using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс для представления клиента, который может добавляться в базу данных.
    /// Взаимодействие с объектом осуществляется через свойства. Поле ID является уникальным и автоматически генерируется.
    /// </summary> 
    internal class Customer
    {
        private readonly int _id
        private string? _fullname;
        private string? _address;

        /// <summary>
        /// Уникальный идентификатор клиента.
        /// </summary>
        public int ID
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
        public string? Address
        {
            get {return _address;}
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 1000, 0, nameof(Address));
                    _address = value;
                }
                catch (Exception)
                {

                    throw new Exception($"Неверные данные для {nameof(Address)}");
                }
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/> с заданными параметрами.
        /// </summary>
        /// <param name="fullname">Полное имя клиента. Передается в свойство <see cref="FullName"/>.</param>
        /// <param name="address">Адрес клиента. Передается в свойство <see cref="Address"/>.</param>
        public Customer(string? fullname, string? address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullname;
            Address = address;

        }
    }
}
