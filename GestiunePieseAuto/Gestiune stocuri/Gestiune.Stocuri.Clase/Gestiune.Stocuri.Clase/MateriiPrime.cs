using System;
using Gestiune_stocuri;

namespace GestiuneStocuri
{
    abstract class Discount
    {
        abstract public double discountProdus();
    }

    class MateriiPrime : Discount, ICloneable, IComparable, IValoare
    {
        private string denumire;
        private float pret;
        private int cantitate;

        public MateriiPrime()
        {
            denumire = "Anonim";
            pret = 0.0f;
            cantitate = 0;
        }

        public MateriiPrime(string denumire, float pret, int cantitate)
        {
            this.denumire = denumire;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }

        public float Pret
        {
            get { return pret; }
            set { pret = value; }
        }

        public int Cantitate
        {
            get { return cantitate; }
            set { cantitate = value; }
        }

        public override string ToString()
        {
            return "Denumire " + denumire + " pret " + pret + " cantitate " + cantitate;
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public MateriiPrime Clone()
        {
            return (MateriiPrime)((ICloneable)this).Clone();
        }

        public int CompareTo(object obj)
        {
            MateriiPrime p = (MateriiPrime)obj;
            if (this.pret < p.pret)
                return -1;
            else
                if (this.pret > p.pret)
                return 1;
            else
                return string.Compare(this.denumire, p.denumire);

        }

        public override double discountProdus()
        {
            double rezultat;
            rezultat = pret * 0.2;
            return rezultat;
        }

        public double valoareProduse()
        {
            return cantitate * pret;
        }
    }
}

