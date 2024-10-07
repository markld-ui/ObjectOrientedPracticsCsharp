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
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }

        public string PostIndex
        {
            get { return textBoxPostIndex.Text; }
            set { textBoxPostIndex.Text = value; }
        }

        public string Country
        {
            get { return textBoxCountry.Text; }
            set { textBoxCountry.Text = value; }
        }

        public string City
        {
            get { return textBoxCity.Text; }
            set { textBoxCity.Text = value; }
        }

        public string Street
        {
            get { return textBoxStreet.Text; }
            set { textBoxStreet.Text = value; }
        }

        public string Building
        {
            get { return textBoxBuilding.Text; }
            set { textBoxBuilding.Text = value; }
        }

        public string Apartament
        {
            get { return textBoxApartament.Text; }
            set { textBoxApartament.Text = value; }
        }

        public void ClearAddressFields()
        {
            PostIndex = string.Empty;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartament = string.Empty;
        }

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
