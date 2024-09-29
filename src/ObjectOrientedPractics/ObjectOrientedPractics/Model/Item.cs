using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс для представления предмета, который можно добавить или удалить из базы данных.
    /// Взаимодействие с объектами осуществляется через свойства. Поле ID является уникальным
    /// и автоматически генерируется.
    /// </summary>    
    internal class Item
    {
        private readonly int _id;
        private string? _name;
        private string? _info;
        private double _cost;

        /// <summary>
        /// Уникальный идентификатор предмета.
        /// </summary>
        public int ID 
        {
            get {return _id;}
        }

        /// <summary>
        /// Название предмета.
        /// </summary>
        /// <exception cref="Exception">
        /// Выбрасывается, если строка <paramref name="Name"/> пуста или превышает допустимую длину.
        /// </exception>
        public string? Name 
        {
            get { return _name;}
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 200, 0, nameof(Name));
                    _name = value;
                }
                
                catch (Exception)
                {

                    throw new Exception($"Неверные данные для {nameof(Name)}");
                }
            }
            
        }

        /// <summary>
        /// Описание предмета.
        /// </summary>
        /// <exception cref="Exception">
        /// Выбрасывается, если строка <paramref name="Info"/> пуста или превышает допустимую длину.
        /// </exception>
        public string? Info
        {
            get {return _info;}
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 1000, 0, nameof(Name));
                    _info = value;
                }
                catch (Exception)
                {

                    throw new Exception($"Неверные данные для {nameof(Info)}");
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
            get { return _cost;}
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
        public Category Category { get; set; }


        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item"/> с заданными параметрами.
        /// </summary>
        /// <param name="name">Название предмета. Передается в свойство <see cref="Name"/>.</param>
        /// <param name="info">Описание предмета. Передается в свойство <see cref="Info"/>.</param>
        /// <param name="cost">Стоимость предмета. Передается в свойство <see cref="Cost"/>.</param>
        /// <param name="category">Категория товара.</param>
        public Item (string? name, string? info, double cost, Category category)
        {
            _id = IdGenerator.GetNextId();
            Category = category;
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
