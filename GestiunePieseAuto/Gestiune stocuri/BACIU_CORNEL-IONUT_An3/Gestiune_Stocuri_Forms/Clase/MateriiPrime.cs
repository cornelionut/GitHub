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
        private int cod;
        private string denumire;
        private float pret;
        private int stoc;
        private int cantitate;

        public MateriiPrime()
        {
            cod = 0;
            denumire = "Anonim";
            pret = 0.0f;
            stoc = 0;
        }

        public MateriiPrime( string denumire, float pret,int cantitate)
        {
            this.cantitate = cantitate;
            this.denumire = denumire;
            this.pret = pret;
        }

        public MateriiPrime(int cod,string denumire, float pret, int stoc)
        {
            this.cod=cod;
            this.denumire = denumire;
            this.pret = pret;
            this.stoc = stoc;
        }

        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }

        public int Cantitate
        {
            get { return cantitate; }
            set { cantitate = value; }
        }

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public float Pret
        {
            get { return pret; }
            set { pret = value; }
        }

        public int Stoc
        {
            get { return stoc; }
            set { stoc = value; }
        }

    

        public override string ToString()
        {
            return "Denumire:" + denumire + "   Pret:" + pret + "   Cantitate:" + stoc;
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
            rezultat = (pret * cantitate) - (pret* cantitate * 0.1);
            return rezultat;
        }

        public double valoareProduse()
        {
            return stoc * pret;
        }
    }
}

