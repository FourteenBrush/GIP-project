using Business;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormFactuur : Form
    {
        private List<Product> _bestellingen;
        private ProductDA _pda;
        private Klant _klant;

        public FormFactuur()
        {
            InitializeComponent();

            _pda = new ProductDA();
            _bestellingen = new List<Product>();

            listBoxProducten.DataSource = _pda.ReadTable();
        }

        private void buttonBestellingToevoegen_Click(object sender, EventArgs e)
        {
            Product product = (Product)listBoxProducten.SelectedItem;
            _bestellingen.Add(product);

            listBoxBestellingen.DataSource = null;
            listBoxBestellingen.DataSource = _bestellingen;
            UpdatePrijsLabel(product.Prijs);
        }

        private void buttonBestellingVerwijderen_Click(object sender, EventArgs e)
        {
            Product product = (Product)listBoxBestellingen.SelectedItem;
            if (product != null)
            {
                _bestellingen.Remove(product);

                listBoxBestellingen.DataSource = null;
                listBoxBestellingen.DataSource = _bestellingen;
                UpdatePrijsLabel(-product.Prijs);
            }
        }

        private void UpdatePrijsLabel(decimal prijs)
        {
            decimal huidigePrijs = Convert.ToDecimal(labelPrijs.Text.Substring(1).Replace('.', ','));
            labelPrijs.Text = (huidigePrijs + prijs).ToString("C");
        }

        private void buttonKiesKlant_Click(object sender, EventArgs e)
        {
            FormKlanten klantenform = new FormKlanten();
            klantenform.ShowDialog();
            _klant = klantenform.Klant;
            if (_klant != null)
            {
                labelKlant.Text = _klant.ToString();
            }
        }

        private void buttonBewerkProduct_Click(object sender, EventArgs e)
        {
            Product product = (Product)listBoxProducten.SelectedItem;
            new FormProductInfo(product).ShowDialog();

            // update datasource zonder een lijst bij te houden
            var s = listBoxProducten.DataSource;
            listBoxProducten.DataSource = null;
            listBoxProducten.DataSource = s;
        }
    }
}
