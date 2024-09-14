using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Exceptions
{
    /// <summary>
    /// Исключение, возникающее при некорректной длине строки (она равна нулю или меньше).
    /// </summary>
    internal class StringMinLengthException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="StringMinLengthException"/> с сообщением об ошибке.
        /// </summary>
        /// <param name="propertyName">Имя свойства, для которого возникло исключение.</param>
        /// <param name="minLength">Минимально допустимая длина строки.</param>
        public StringMinLengthException(string propertyName, int minLength)
            : base($"{propertyName} должен быть больше {minLength} символов или поле пусто.") { }
    }
}
