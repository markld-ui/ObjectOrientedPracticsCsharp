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
