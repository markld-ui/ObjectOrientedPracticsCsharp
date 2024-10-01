using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Перечисление категории продукции
    /// </summary>
    enum Category
    {
        /// <summary>Неизвестная продукция</summary>
        Unknown,
        /// <summary>Хлебобулочная продукция</summary>
        Bakery,
        /// <summary> Молочная продукция</summary>
        Dairy,
        /// <summary>Мясо</summary>
        Meat,
        /// <summary>Бытовая химия</summary>
        Household,
        /// <summary>Напитки</summary>
        Drinks,
        /// <summary>Овощи</summary>
        Vegetables,
        /// <summary>Замороженная продукция</summary>
        Frozen,
    }
}
