using ObjectOrientedPractices.Model.Enums;
using ObjectOrientedPractices.Model.Orders;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractices.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class InterfaceEx : UserControl
    {
        public InterfaceEx()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var item1 = new Item("Item1", "Description1", 100, Category.Bakery);
            var item2 = new Item("Item2", "Description2", 200, Category.Bakery);
            var address = new Address(12345, "Country", "City", "Street", "Building", "Apartment");
            var order = new Order(address, new List<Item> { item1, item2 }, item1.Cost + item2.Cost);
            var cart = new Cart();
            cart.Items.Add(item1);

            var pointsDiscount1 = new PointsDiscount();
            var pointsDiscount2 = new PointsDiscount();
            var percentDiscount1 = new PercentDiscount(Category.Bakery, 10);
            var percentDiscount2 = new PercentDiscount(Category.Bakery, 15);

            var clonedItem = (Item)item1.Clone();
            var clonedAddress = (Address)address.Clone();
            var clonedCart = (Cart)cart.Clone();
            var clonedPointsDiscount1 = (PointsDiscount)pointsDiscount1.Clone();
            var clonedPercentDiscount1 = (PercentDiscount)percentDiscount1.Clone();

            bool areItemsEqual = item1.Equals(clonedItem);
            bool areAddressesEqual = address.Equals(clonedAddress);
            bool arePointsDiscountsEqual = pointsDiscount1.Equals(clonedPointsDiscount1);
            bool arePercentDiscountsEqual = percentDiscount1.Equals(clonedPercentDiscount1);

            int comparisonResultItems = item1.CompareTo(item2);
            int comparisonResultPointsDiscount = pointsDiscount1.CompareTo(pointsDiscount2);
            int comparisonResultPercentDiscount = percentDiscount1.CompareTo(percentDiscount2);

            StringBuilder resultMessage = new StringBuilder();
            resultMessage.AppendLine("Результаты тестирования:");
            resultMessage.AppendLine($"1. Клонирование:");
            resultMessage.AppendLine($"   - Исходный Item: {item1.Name} (Цена: {item1.Cost})");
            resultMessage.AppendLine($"   - Клонированный Item: {clonedItem.Name} (Цена: {clonedItem.Cost})");
            resultMessage.AppendLine($"   - Клонированный Item {(areItemsEqual ? "успешно" : "не")} равен исходному Item.");

            resultMessage.AppendLine($"   - Исходный Address: {address.City}, {address.Street}, {address.Building}");
            resultMessage.AppendLine($"   - Клонированный Address: {clonedAddress.City}, {clonedAddress.Street}, {clonedAddress.Building}");
            resultMessage.AppendLine($"   - Клонированный Address {(areAddressesEqual ? "успешно" : "не")} равен исходному Address.");

            resultMessage.AppendLine($"   - Исходный Cart содержит {cart.Items.Count} предмет(ов).");
            resultMessage.AppendLine($"   - Клонированный Cart содержит {clonedCart.Items.Count} предмет(ов).");

            resultMessage.AppendLine($"2. Сравнение:");
            resultMessage.AppendLine($"   - Сравниваем Item1: {item1.Name} (Цена: {item1.Cost}) с Item2: {item2.Name} (Цена: {item2.Cost})");
            resultMessage.AppendLine($"   - Результат сравнения Items: {comparisonResultItems}");

            resultMessage.AppendLine($"   - Сравниваем PointsDiscount1: {pointsDiscount1.Points} с PointsDiscount2: {pointsDiscount2.Points}");
            resultMessage.AppendLine($"   - Результат сравнения PointsDiscount: {comparisonResultPointsDiscount}");

            resultMessage.AppendLine($"   - Сравниваем PercentDiscount1: {percentDiscount1.CurrentDiscount} с PercentDiscount2: {percentDiscount2.CurrentDiscount}");
            resultMessage.AppendLine($"   - Результат сравнения PercentDiscount: {comparisonResultPercentDiscount}");

            MessageBox.Show(resultMessage.ToString());
        }
    }
}