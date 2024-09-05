using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Exceptions
{
    /// <summary>
    /// Исключение, возникающее при некорректной длине строки.
    /// </summary>
    public class StringLengthException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="StringLengthException"/> с сообщением об ошибке.
        /// </summary>
        /// <param name="propertyName">Имя свойства, для которого возникло исключение.</param>
        /// <param name="maxLength">Максимально допустимая длина строки.</param>
        public StringLengthException(string propertyName, int maxLength)
            : base($"{propertyName} должен быть меньше {maxLength} символов.") { }
    }
}
