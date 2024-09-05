using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Exceptions;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Статический класс, предоставляющий методы для валидации данных.
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Проверяет строку на соответствие установленной максимальной длине.
        /// </summary>
        /// <param name="value">Строка, подлежащая проверке.</param>
        /// <param name="maxLength">Максимально допустимая длина строки.</param>
        /// <param name="propertyName">Имя свойства, используемое в сообщении об ошибке.</param>
        /// <exception cref="StringLengthException">
        /// Выбрасывается, если длина строки превышает допустимую или строка пуста.
        /// </exception>
        public static void AssertStringOnLength(string? value, int maxLength, string propertyName)
        {
            if (string.IsNullOrEmpty(value) || value.Length > maxLength)
            {
                throw new StringLengthException(propertyName, maxLength);
            }
        }
    }
}
