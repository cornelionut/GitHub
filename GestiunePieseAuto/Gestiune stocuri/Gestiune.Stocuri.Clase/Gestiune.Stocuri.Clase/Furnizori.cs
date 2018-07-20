using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneStocuri
{
    class Furnizori
    {
        private string denumire;
        private string adresa;

        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public Furnizori()
        {
            this.denumire = "";
            this.adresa = "";
        }

        public Furnizori(string denumire,string adresa)
        {
            this.denumire = denumire;
            this.adresa = adresa;
        }

        public string ToString()
        {
            return "Adresa " + adresa + " denumire " + denumire;
        }


    }
}
