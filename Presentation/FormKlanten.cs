using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Business;

namespace Presentation
{
    public partial class FormKlanten : Form
    {
        private KlantDA _kda;
        private Klant _klant;

        public Klant Klant
        {
            get { return _klant; }
        }

        public FormKlanten()
        {
            InitializeComponent();
            _kda = new KlantDA();

            listBoxKlanten.DataSource = _kda.ReadTable();
        }

        private void buttonBewerkKlant_Click(object sender, EventArgs e)
        {
            Klant klant = (Klant)listBoxKlanten.SelectedItem;
            new FormKlantInfo(klant).ShowDialog();
        }

        private void buttonKiesKlant_Click(object sender, EventArgs e)
        {
           _klant = (Klant)listBoxKlanten.SelectedItem;
            Close();
        }


        /*
         private void buttonVerwijderklant_Click(object sender, EventArgs e)
        {
            Klant klant = (Klant)listBoxKlanten.SelectedItem;
            if (klant != null)
            {
                _kda.DeleteKlant(klant.KlantNummer);
                // update listbox
                var s = listBoxKlanten.DataSource;
                listBoxKlanten.DataSource = null;
                listBoxKlanten.DataSource = s;
            }
        }
         */
    }
}
