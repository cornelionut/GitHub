using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneStocuri
{
    class Comanda :IComparable,ICloneable
    {
        static int idComanda;
        DateTime dataComanda;
        int cantitate;
        DateTime dataLivrarii;

        public int Cantitate
        {
            get { return cantitate; }
            set { cantitate = value; }
        }
        
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
