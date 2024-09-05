using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
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
                    if (value?.Length <= 1000) { _info = value; }
                    else { throw new ArgumentOutOfRangeException("Длина данных превосходит 1000 символов"); }
                }
                catch (Exception)
                {

                    throw new Exception("Неверные данные или данные пусты");
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

        public Item (string? name, string? info, double cost)
        {
            _ID = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
