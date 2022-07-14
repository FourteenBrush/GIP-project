using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormProductInfo : Form
    {
        private Product _product;

        public FormProductInfo(Product product)
        {
            InitializeComponent();

            _product = product;

            textBoxOmschrijving.Text = _product.Omschrijving;
            textBoxPrijs.Text = _product.Prijs.ToString();
        }

        private void buttonOpslaan_Click(object sender, EventArgs e)
        {
            _product.Omschrijving = textBoxOmschrijving.Text;
            _product.Prijs = Convert.ToDecimal(textBoxPrijs.Text.Replace('.', ','));

            Close();
        }
    }
}
