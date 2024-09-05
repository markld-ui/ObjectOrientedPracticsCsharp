using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Статический класс генерации уникального-сквозного ID
    /// </summary>
    public static class IdGenerator
    {
        private static int _currentId = 0;

        /// <summary>
        /// Статический метод генерации ID, работающий со статическим полем.
        /// </summary>
        /// <returns>Возвращает ID элемента</returns>
        public static int GetNextId()
        {
            return ++_currentId;
        }
    }
}
