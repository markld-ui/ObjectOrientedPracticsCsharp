using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.Services
{
    public delegate bool FilterItemByCriteria(Item item);

    public static class DataTools
    {
        public static List<string> ComboBoxSorted = new List<string>
        {
            "Name",
            "Cost (Ascending)",
            "Cost (Descending)"
        };

        // Фильтрация с 3го по 7й пункт
        public static List<Item> FilterItems(List<Item> items, FilterItemByCriteria criteria)
        {
            List<Item> filteredItems = new List<Item>();
            foreach (var item in items)
            {
                if (criteria(item))
                {
                    filteredItems.Add(item);
                }
            }
            return filteredItems;
        }

        public static bool IsPriceAboveThreshold(Item item, int threshold)
        {
            return item.Cost > threshold;
        }

        public static bool IsInCategory(Item item, Category category)
        {
            return item.Category == category;
        }
    }
}
