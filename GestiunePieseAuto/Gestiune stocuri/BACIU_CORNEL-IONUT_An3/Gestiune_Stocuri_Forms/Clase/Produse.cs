using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplicationDB
{
   public class Produse
    {
        public readonly int id;
        public string denumire;
        public int anFabricatie;
        public string tip;
        public string marca;

        public Produse(int id, string denumire, string marca, int anFabricatie, string tip)
        {
            this.id = id;
            this.denumire = denumire;
            this.marca = marca;
            this.anFabricatie = anFabricatie;
            this.tip = tip;

        }
    }
}
