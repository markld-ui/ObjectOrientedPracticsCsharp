using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Exceptions;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Статический класс валидаций
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Статический метод обрабатывающий длину вводимых данных.
        /// </summary>
        /// <param name="value">Передаваемые данные строкового типа</param>
        /// <param name="maxLength">Максимальная длина данных, установленная для определенного оля ввода</param>
        /// <param name="propertyName">Название свойства, передачи в выброс исключения, при его необходимости</param>
        /// <exception cref="StringLengthException"></exception>
        public static void AssertStringOnLength(string? value, int maxLength, string propertyName)
        {
            if (string.IsNullOrEmpty(value) || value.Length > maxLength)
            {
                throw new StringLengthException(propertyName, maxLength);
            }
        }
    }
}
