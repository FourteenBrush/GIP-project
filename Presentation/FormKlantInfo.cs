using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Presentation
{
    public partial class FormKlantInfo : Form
    {
        private Klant _klant;

        public FormKlantInfo(Klant klant)
        {
            InitializeComponent();

            _klant = klant;
            textBoxKlantnaam.Text = _klant.ToString();
            textBoxAdres.Text = _klant.Adres;
            textBoxEmail.Text = _klant.Email;
            textBoxTelefoonnummer.Text = _klant.Telefoonnummer;
        }
    }
}
