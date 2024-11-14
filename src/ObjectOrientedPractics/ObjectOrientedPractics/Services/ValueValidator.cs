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
        /// <exception cref="StringLengthException">
        /// Выбрасывается, если длина строки не совпадает с допустимой или строка пуста.
        /// </exception>
        public static void AssertStringOnLength(string value, int maxLength, int minLenght, string propertyName)
        {
            if (string.IsNullOrEmpty(value) || value.Length > maxLength || value.Length <= minLenght)
            {
                throw new StringLengthException(propertyName, maxLength, minLenght);
            }
        }

        public static void AssertNumericFieldOnLetter(string value, string propertyName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(nameof(value), "Поле является пустым");
            }

            for (int i = 0; i < value.Length; i++)
            {
                if (((int)value[i] >= 65 && (int)value[i] <= 90) || ((int)value[i] >= 97 && (int)value[i] <= 122))
                {
                    throw new NumericFieldException(nameof(value), "Поле содержит некорректные данные (отличные от цифр)");
                }
            }
        }
    }
}
