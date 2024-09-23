using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Exceptions
{
    /// <summary>
    /// Исключение, возникающее при некорректной длине строки.
    /// </summary>
    public class StringMaxLengthException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="StringMaxLengthException"/> с сообщением об ошибке.
        /// </summary>
        /// <param name="propertyName">Имя свойства, для которого возникло исключение.</param>
        /// <param name="maxLength">Максимально допустимая длина строки.</param>
        public StringMaxLengthException(string propertyName, int maxLength)
            : base($"{propertyName} должен быть меньше {maxLength} символов или поле пусто.") { }
    }
}
