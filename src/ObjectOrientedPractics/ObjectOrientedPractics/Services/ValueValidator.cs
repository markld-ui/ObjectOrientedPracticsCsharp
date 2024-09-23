using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Exceptions;

namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Статический класс, предоставляющий методы для валидации данных.
    /// </summary>
    public static class ValueValidator
    {

        /// <summary>
        /// Проверяет строку на соответствие установленной максимальной длине.
        /// </summary>
        /// <param name="value">Строка, подлежащая проверке.</param>
        /// <param name="maxLength">Максимально допустимая длина строки.</param>
        /// <param name="propertyName">Имя свойства, используемое в сообщении об ошибке.</param>
        /// <exception cref="StringMaxLengthException">
        /// Выбрасывается, если длина строки превышает допустимую или строка пуста.
        /// </exception>
        /// <exception cref="StringMinLengthException">
        /// Выбрасывается, если длина строки меньше допустимой или строка пуста.
        /// </exception>
        public static void AssertStringOnLength(string? value, int maxLength, int minLenght, string propertyName)
        {
            if (string.IsNullOrEmpty(value) || value.Length > maxLength)
            {
                throw new StringMaxLengthException(propertyName, maxLength);
            }
            if (string.IsNullOrEmpty(value) || value.Length <= minLenght)
            {
                throw new StringMinLengthException(propertyName, minLenght);
            }
        }
    }
}
