using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Exceptions;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Класс, представляющий адрес.
    /// Взаимодействие с объектами осуществляется через свойства.
    /// </summary>
    public class Address
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartament;

        /// <summary>
        /// Почтовый индекс адреса.
        /// </summary>
        public int Index 
        {
            get
            {
                return _index;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Постовый индекс не может быть равен нулю или быть отрицательным!");
                }
                _index = value;
            } 
        }

        /// <summary>
        /// Страна адреса.
        /// </summary>
        /// <exception cref="Exception">
        /// Выбрасывается, если строка <paramref name="Country"/> пуста или превышает допустимую длину.
        /// </exception>
        public string Country 
        {
            get 
            {
                return _country;
            } 
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 50, 0, nameof(Country));
                    _country = value;
                }
                catch (StringLengthException)
                {
                    throw new StringLengthException(nameof(Country), 50, 0);
                }
            }
        }

        /// <summary>
        /// Город адреса.
        /// </summary>
        /// <exception cref="Exception">
        /// Выбрасывается, если строка <paramref name="City"/> пуста или превышает допустимую длину.
        /// </exception>
        public string City 
        {
            get
            {
                return _city;
            }
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 50, 0, nameof(City));
                    _city = value;
                }
                catch (StringLengthException)
                {
                    throw new StringLengthException(nameof(City), 50, 0);
                }
            }
        }

        /// <summary>
        /// Улица адреса.
        /// </summary>
        /// <exception cref="Exception">
        /// Выбрасывается, если строка <paramref name="Street"/> пуста или превышает допустимую длину.
        /// </exception>
        public string Street 
        {
            get
            {
                return _street;
            }
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 100, 0, nameof(Street));
                    _street = value;
                }
                catch (StringLengthException)
                {
                    throw new StringLengthException(nameof(Street), 100, 0);
                }
            }
        }

        /// <summary>
        /// Здание адреса.
        /// </summary>
        /// <exception cref="Exception">
        /// Выбрасывается, если строка <paramref name="Building"/> пуста или превышает допустимую длину.
        /// </exception>
        public string Building 
        {
            get
            {
                return _building;
            }
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 10, 0, nameof(Building));
                    _building = value;
                }
                catch (StringLengthException)
                {
                    throw new StringLengthException(nameof(Building), 10, 0);
                }
            }
        }

        /// <summary>
        /// Квартира адреса.
        /// </summary>
        /// <exception cref="StringMaxLengthException">
        /// Выбрасывается, если строка <paramref name="Apartment"/> пуста или превышает допустимую длину.
        /// </exception>
        public string Apartament
        {
            get
            {
                return _apartament;
            }
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 10, 0, nameof(Apartament));
                    _apartament = value;
                }
                catch (StringLengthException)
                {
                    throw new StringLengthException(nameof(Apartament), 10, 0);
                }
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="index">Индекс адреса.</param>
        /// <param name="country">Страна адреса.</param>
        /// <param name="city">Город адреса.</param>
        /// <param name="street">Улица адреса.</param>
        /// <param name="building">Здание адреса.</param>
        /// <param name="apartament">Квартира адреса.</param>
        public Address(int index, string country, string city, string street, string building, string apartament) 
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartament = apartament;
        }
    }
}
