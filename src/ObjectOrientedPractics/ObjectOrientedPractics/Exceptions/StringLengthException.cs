using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Exceptions
{
    /// <summary>
    /// Исключение, возникающее при некорректной длине строки (она равна нулю или меньше).
    /// </summary>
    public class StringLengthException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="StringLengthException"/> с сообщением об ошибке.
        /// </summary>
        /// <param name="propertyName">Имя свойства, для которого возникло исключение.</param>
        /// <param name="minLength">Минимально допустимая длина строки.</param>
        public StringLengthException(string propertyName, int maxLength, int minLength)
            : base($"{propertyName} должен быть больше {minLength} или меньше {maxLength} символов или поле пусто.") { }
    }

    /// <summary>
    /// Исключение, возникающее при некорректных числовых данных в поле.
    /// </summary>
    public class NumericFieldException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="NumericFieldException"/> с сообщением об ошибке.
        /// </summary>
        /// <param name="propertyName">Имя свойства, для которого возникло исключение.</param>
        /// <param name="message">Сообщение об ошибке, объясняющее причину исключения.</param>
        public NumericFieldException(string propertyName, string message)
            : base($"{propertyName} {message}") { }
    }
}
