using GestiuneStocuri;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiune_Stocuri_Forms
{
    public partial class AfisareProduse : Form
    {

        ArrayList lista2;

        public AfisareProduse(ArrayList lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (MateriiPrime mp in lista2)
                tbAP.Text += mp.ToString() + Environment.NewLine;
        }

    }
}
