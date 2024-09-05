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
    /// Благодаря данному классу, можно добавлять/удалять предмет для продажи из БД
    /// Взаимодействие происходит благодаря использованию свойств в конструкторе класса, 
    /// передав в него необходимые параметры.
    /// Поле ID является сквозным.
    /// </summary>    
    internal class Item
    {
        private readonly int _ID;
        private string? _name;
        private string? _info;
        private double _cost;
        public int ID 
        {
            get {return _ID;}
        }

        public  string? Name 
        {
            get { return _name;}
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                    _name = value;
                }
                
                catch (Exception)
                {

                    throw new Exception($"Неверные данные для {nameof(Name)}");
                }
            }
            
        }
        public  string? Info
        {
            get {return _info;}
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 1000, nameof(Name));
                    _info = value;
                }
                catch (Exception)
                {

                    throw new Exception($"Неверные данные для {nameof(Info)}");
                }
            }

        }
        public double Cost
        {
            get { return _cost;}
            private set
            {
                try
                {
                    if (0.0 <= value || value >= 100_000.0) 
                    { 
                        throw new ArgumentOutOfRangeException("Цена превосходит или меньше допустимой величины");
                    }
                    else 
                    {
                        _cost = value; 
                    }
                }
                catch (Exception)
                {

                    throw new Exception("Неверные данные или данные пусты");
                }
            }

        }

        /// <param name="name">Параметр "name" строкового типа, с которым можно взаимодейсвтовть при помощи свойства <see cref="Name"/> в параметризированном конструкторе класса<param/>
        /// <param name="info">Параметр "info" строкового типа, с которым можно взаимодейсвтовть при помощи свойства <see cref="Info"/> в параметризированном конструкторе класса<param/>
        /// <param name="cost">Параметр "cost" даблвского типа, с которым можно взаимодейсвтовть при помощи свойства <see cref="Cost"/> в параметризированном конструкторе класса<param/>
        public Item (string? name, string? info, double cost)
        {
            _ID = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
