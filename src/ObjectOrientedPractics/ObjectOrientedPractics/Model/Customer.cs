using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
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

        public Customer(string? fullname, string? address)
        {
            _ID = IdGenerator.GetNextId();
            FullName = fullname;
            Address = address;

        }
    }
}
