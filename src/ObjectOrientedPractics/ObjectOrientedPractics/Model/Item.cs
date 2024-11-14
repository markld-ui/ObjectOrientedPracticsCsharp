﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Exceptions;
using ObjectOrientedPractices.Services;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Класс для представления предмета, который можно добавить или удалить из базы данных.
    /// Взаимодействие с объектами осуществляется через свойства. Поле ID является уникальным
    /// и автоматически генерируется.
    /// </summary>    
    public class Item
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;
        private Category _category;

        /// <summary>
        /// Уникальный идентификатор предмета.
        /// </summary>
        public int Id 
        {
            get 
            {
                return _id;
            }
        }

        /// <summary>
        /// Название предмета.
        /// </summary>
        /// <exception cref="StringLengthException">
        /// Выбрасывается, если строка <paramref name="Name"/> пуста или превышает допустимую длину.
        /// </exception>
        public string Name 
        {
            get 
            { 
                return _name;
            }
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 200, 0, nameof(Name));
                    _name = value;
                }

                catch (StringLengthException)
                {
                    throw new StringLengthException(nameof(Name), 200, 0);
                }
            }
            
        }

        /// <summary>
        /// Описание предмета.
        /// </summary>
        /// <exception cref="StringLengthException">
        /// Выбрасывается, если строка <paramref name="Info"/> пуста или превышает допустимую длину.
        /// </exception>
        public string Info
        {
            get
            {
                return _info;
            }
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 1000, 0, nameof(Info));
                    _info = value;
                }
                catch (StringLengthException)
                {
                    throw new StringLengthException(nameof(Info), 1000, 0);
                }
            }

        }

        /// <summary>
        /// Стоимость предмета.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Выбрасывается, если значение стоимости выходит за пределы допустимых значений (от 0 до 100 000).
        /// </exception>
        public double Cost
        {
            get 
            { 
                return _cost;
            }
            private set
            {
                if (0.0 == value || value >= 100000.0) 
                    { 
                        throw new ArgumentOutOfRangeException("Цена превосходит или меньше допустимой величины");
                    }
                _cost = value; 
            }

        }

        /// <summary>
        /// Категория предмета
        /// </summary>
        public Category Category 
        { 
            get => _category; 
            set => _category = value; 
        }

        /// <summary>
        /// Переопределяет метод ToString для представления объекта в виде строки.
        /// Возвращает строку, содержащую имя и стоимость объекта.
        /// </summary>
        /// <returns>Строка в формате "Имя - Стоимость".</returns>
        public override string ToString()
        {
            return $"{Name} - {Cost}";
        }


        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item"/> с заданными параметрами.
        /// </summary>
        /// <param name="name">Название предмета. Передается в свойство <see cref="Name"/>.</param>
        /// <param name="info">Описание предмета. Передается в свойство <see cref="Info"/>.</param>
        /// <param name="cost">Стоимость предмета. Передается в свойство <see cref="Cost"/>.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }
    }
}
