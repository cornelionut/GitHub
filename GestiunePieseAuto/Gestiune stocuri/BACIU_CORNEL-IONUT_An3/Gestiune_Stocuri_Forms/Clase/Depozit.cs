using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestiune_stocuri;

namespace GestiuneStocuri
{
    class Depozit : MateriiPrime,ICloneable, IComparable,IValoare              //Catalog produse,cautare dupa cod/pret/denumire
    {
        private string denumire;
        private string adresa;
        private List<MateriiPrime> listaMateriiPrime;

        public Depozit(float pret, int cantitate,string denumire,string adresa,List<MateriiPrime> listaMateriiPrime)
        {
            this.denumire = denumire;
            this.adresa = adresa;
            this.listaMateriiPrime = new List<MateriiPrime>();

        }

        public Depozit()
        {
            denumire = "";
            adresa = "";
            listaMateriiPrime = new List<MateriiPrime>();
        }

        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { if (value != null) adresa = value; }
        }

        public List<MateriiPrime> ListaAnimale
        {
            get { return listaMateriiPrime; }
            set { listaMateriiPrime = value; }
        }

        public override string ToString()
        {
            string result = " ";
            result += "Depozit " + denumire + " cu adresa " + adresa + " are urmatoarele produse:";

            foreach (MateriiPrime m in listaMateriiPrime)
                result += m.ToString() + Environment.NewLine;
            return result;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public Depozit Clone()
        {
            Depozit result = (Depozit)((ICloneable)this).Clone();
            List<MateriiPrime> copie = new List<MateriiPrime>();
            foreach (MateriiPrime mp in listaMateriiPrime)
                copie.Add(mp.Clone());
            result.listaMateriiPrime = copie;
            return result;
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public double valoareProduse()
        {
            return Pret * Cantitate;
        }

        public static Depozit operator +(Depozit d, MateriiPrime mp)
        {
            d.listaMateriiPrime.Add(mp);
            return d;
        }

        public MateriiPrime this[int index]
        {
            get
            {
                if (index >= 0 && index < listaMateriiPrime.Count)
                    return listaMateriiPrime[index];
                else
                    return null;
            }
        }

        
    }
}
