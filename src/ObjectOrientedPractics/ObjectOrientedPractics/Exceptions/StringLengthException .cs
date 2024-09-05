using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Exceptions
{
    /// <summary>
    /// Собственный класс-исключения для оповещения о некорректной длине строки 
    /// </summary>
    public class StringLengthException : Exception
    {
        /// <param name="propertyName">Имя свойства<param/>
        /// <param name="maxLength">Максимально допустимая длина строки<param/>
        public StringLengthException(string propertyName, int maxLength)
            : base($"{propertyName} должен быть меньше {maxLength} символов.") { }
    }
}
