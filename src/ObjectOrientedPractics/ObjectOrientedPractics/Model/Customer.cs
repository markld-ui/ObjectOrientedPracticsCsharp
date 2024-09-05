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
    /// Благодаря данному классу, можно добавлять/удалять предмет для продажи из БД
    /// Взаимодействие происходит благодаря использованию свойств в конструкторе класса, 
    /// передав в него необходимые параметры.
    /// Поле ID является сквозным.
    /// </summary> 
    internal class Customer
    {
        private readonly int _ID;
        private string? _fullname;
        private string? _address;

        public int ID
        {
            get
            {
                return _ID;
            }
        }

        public string? FullName
        { 
            get {return _fullname;}
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                    _fullname = value;
                }
                catch (Exception)
                {

                    throw new Exception($"Неверные данные для {nameof(FullName)}");
                }
            }
        }

        public string? Address
        {
            get {return _address;}
            private set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 1000, nameof(Address));
                    _address = value;
                }
                catch (Exception)
                {

                    throw new Exception($"Неверные данные для {nameof(Address)}");
                }
            }
        }

        /// <param name="fullname">Параметр "fullname" строкового типа, с которым можно взаимодейсвтовть при помощи свойства <see cref="FullName"/> в параметризированном конструкторе класса<param/>
        /// <param name="address">Параметр "address" строкового типа, с которым можно взаимодейсвтовть при помощи свойства <see cref="Address"/> в параметризированном конструкторе класса<param/>
        public Customer(string? fullname, string? address)
        {
            _ID = IdGenerator.GetNextId();
            FullName = fullname;
            Address = address;

        }
    }
}
