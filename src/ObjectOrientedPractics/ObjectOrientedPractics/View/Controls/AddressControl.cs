using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Контрол для работы с данными адреса. Позволяет задавать и получать
    /// информацию об индексе, стране, городе, улице, доме и квартире.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает или задает почтовый индекс.
        /// </summary>
        public string PostIndex
        {
            get 
            { 
                return textBoxPostIndex.Text; 
            }
            set 
            { 
                textBoxPostIndex.Text = value; 
            }
        }

        /// <summary>
        /// Возвращает или задает страну.
        /// </summary>
        public string Country
        {
            get 
            { 
                return textBoxCountry.Text; 
            }
            set
            { 
                textBoxCountry.Text = value;
            }
        }

        /// <summary>
        /// Возвращает или задает город.
        /// </summary>
        public string City
        {
            get 
            { 
                return textBoxCity.Text;
            }
            set 
            { 
                textBoxCity.Text = value;
            }
        }

        /// <summary>
        /// Возвращает или задает улицу.
        /// </summary>
        public string Street
        {
            get 
            { 
                return textBoxStreet.Text; 
            }
            set 
            { 
                textBoxStreet.Text = value; 
            }
        }

        /// <summary>
        /// Возвращает или задает номер дома.
        /// </summary>
        public string Building
        {
            get 
            {
                return textBoxBuilding.Text; 
            }
            set 
            { 
                textBoxBuilding.Text = value; 
            }
        }

        /// <summary>
        /// Возвращает или задает номер квартиры.
        /// </summary>
        public string Apartament
        {
            get 
            { 
                return textBoxApartament.Text; 
            }
            set 
            { 
                textBoxApartament.Text = value; 
            }
        }

        /// <summary>
        /// Очищает все поля адреса.
        /// </summary>
        public void ClearAddressFields()
        {
            PostIndex = string.Empty;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartament = string.Empty;
        }

        /// <summary>
        /// Устанавливает цвет фона для текстовых полей адреса в зависимости 
        /// от значения параметра <paramref name="FlagWhite"/>.
        /// Если <paramref name="FlagWhite"/> равно true, устанавливается красный 
        /// цвет фона, чтобы визуально выделить поля с ошибками ввода. 
        /// В противном случае устанавливается белый цвет фона, 
        /// что указывает на отсутствие ошибок.
        /// </summary>
        /// <param name="FlagWhite">Флаг, определяющий цвет фона: 
        /// true - красный, false - белый.</param>
        public void ExceptionSetRedColor(bool FlagWhite)
        {
            if (FlagWhite)
            {
                textBoxPostIndex.BackColor = ColorTranslator.FromHtml("#DC143C");
                textBoxCountry.BackColor = ColorTranslator.FromHtml("#DC143C");
                textBoxCity.BackColor = ColorTranslator.FromHtml("#DC143C");
                textBoxStreet.BackColor = ColorTranslator.FromHtml("#DC143C");
                textBoxBuilding.BackColor = ColorTranslator.FromHtml("#DC143C");
                textBoxApartament.BackColor = ColorTranslator.FromHtml("#DC143C");
            }
            else 
            {
                textBoxPostIndex.BackColor = Color.White;
                textBoxCountry.BackColor = Color.White;
                textBoxCity.BackColor = Color.White;
                textBoxStreet.BackColor = Color.White;
                textBoxBuilding.BackColor = Color.White;
                textBoxApartament.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Заполняет поля адреса на основании переданного объекта <see cref="Address"/>.
        /// </summary>
        /// <param name="address">Объект адреса для заполнения полей.</param>
        public void FillAddressFields(Address address)
        {
            PostIndex = address.Index.ToString();
            Country = address.Country;
            City = address.City;
            Street = address.Street;
            Building = address.Building;
            Apartament = address.Apartament;
        }
    }
}
