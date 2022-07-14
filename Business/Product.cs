using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Product
    {
        private int _productID;
        private string _omschrijving;
        private decimal _prijs;

        public Product(int productID, string omschrijving, decimal prijs)
        {
            _productID = productID;
            _omschrijving = omschrijving;
            _prijs = prijs;
        }

        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }

        public decimal Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }

        public override string ToString()
        {
            return _omschrijving + "  " + _prijs.ToString("C");
        }
    }
}
