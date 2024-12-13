﻿using System;
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
    public class Address : ICloneable, IEquatable<Address>
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartament;

        public event EventHandler<EventArgs> AddressChanged;

        /// <summary>
        /// Почтовый индекс адреса.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Выбрасывается, если почтовый индекс <paramref name="Index"/> равен нулю или меньше его.
        /// </exception>
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
                    throw new ArgumentOutOfRangeException("Почтовый индекс не может быть равен нулю или быть отрицательным!");
                }

                _index = value;
                OnAddressChanged();
            } 
        }

        /// <summary>
        /// Страна адреса.
        /// </summary>
        /// <exception cref="StringLengthException">
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
                    OnAddressChanged();
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
        /// <exception cref="StringLengthException">
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
                    OnAddressChanged();
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
        /// <exception cref="StringLengthException">
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
                    OnAddressChanged();
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
        /// <exception cref="StringLengthException">
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
                    OnAddressChanged();
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
        /// <exception cref="StringLengthException">
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
                    OnAddressChanged();
                }
                catch (StringLengthException)
                {
                    throw new StringLengthException(nameof(Apartament), 10, 0);
                }
            }
        }

        /// <summary>
        /// Метод для вызова события при изменении адреса.
        /// </summary>
        protected virtual void OnAddressChanged()
        {
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Создает глубокую копию текущего объекта <see cref="Address"/>.
        /// </summary>
        /// <returns>Копия текущего объекта <see cref="Address"/>.</returns>
        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartament);
        }

        /// <summary>
        /// Определяет равенство между текущим объектом и другим объектом <see cref="Address"/>.
        /// </summary>
        /// <param name="other">Другой объект <see cref="Address"/> для сравнения.</param>
        /// <returns>true, если объекты равны; в противном случае - false.</returns>
        public bool Equals(Address other)
        {
            if (other == null) return false;
            return Index == other.Index;
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
