using System;
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
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;
        private Category _category;

        public event EventHandler<EventArgs> NameChanged;
        public event EventHandler<EventArgs> CostChanged;
        public event EventHandler<EventArgs> InfoChanged;

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
                    OnNameChanged();
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
                    OnInfoChanged();
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
                OnCostChanged();
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
        /// Событие срабатывает при изменении имени товара.
        /// </summary>
        protected virtual void OnNameChanged()
        {
            NameChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Событие срабатывает при изменении цены товара.
        /// </summary>
        protected virtual void OnCostChanged()
        {
            CostChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Событие срабатывает при изменении информации о товаре.
        /// </summary>
        protected virtual void OnInfoChanged()
        {
            InfoChanged?.Invoke(this, EventArgs.Empty);
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
        /// Создаёт глубокую копию текущего объекта <see cref="Item"/>.
        /// </summary>
        /// <returns>Копия текущего объекта <see cref="Item"/>.</returns>
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        /// <summary>
        /// Определяет равенство между текущим объектом и другим объектом <see cref="Item"/>.
        /// </summary>
        /// <param name="other">Другой объект <see cref="Item"/> для сравнения.</param>
        /// <returns>true, если объекты равны; в противном случае - false.</returns>
        public bool Equals(Item other)
        {
            if (other == null)
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            return (Name == other.Name);
        }

        /// <summary>
        /// Сравнивает текущий объект с другим объектом <see cref="Item"/> по имени и стоимости.
        /// </summary>
        /// <param name="other">Другой объект <see cref="Item"/> для сравнения.</param>
        /// <returns>0, если имена равны; 1, если текущее имя больше; -1, если меньше.</returns>
        public int CompareTo(Item other)
        {

            if (other == null) return 1;
            return Cost.CompareTo(other.Cost);
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
