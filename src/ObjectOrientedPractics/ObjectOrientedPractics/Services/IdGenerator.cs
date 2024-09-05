using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Статический класс, предназначенный для генерации уникальных ID.
    /// </summary>
    public static class IdGenerator
    {
        private static int _currentId = 0;

        /// <summary>
        /// Генерирует новый уникальный идентификатор, инкрементируя текущее значение.
        /// </summary>
        /// <returns>Возвращает новый уникальный идентификатор.</returns>
        public static int GetNextId()
        {
            return ++_currentId;
        }
    }
}
