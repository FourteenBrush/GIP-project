using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Klant
    {
        private int _klantnummer;
        private string _naam;
        private string _voornaam;
        private string _adres;
        private string _email;
        private string _telefoonnummer;

        public Klant(int klantnummer, string naam, string voornaam, string adres, string email, string telefoonnummer)
        {
            _klantnummer = klantnummer;
            _naam = naam;
            _voornaam = voornaam;
            _adres = adres;
            _email = email;
            _telefoonnummer = telefoonnummer;
        }

        public int KlantNummer
        {
            get { return _klantnummer; }
            set { _klantnummer = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Telefoonnummer
        {
            get { return _telefoonnummer; }
            set { _telefoonnummer = value; }
        }

        public override string ToString()
        {
            return _voornaam + " " + _naam;
        }
    }
}
