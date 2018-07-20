using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace GestiuneStocuri
{
    public partial class PreluareRaport : Form
    {
        private List<MateriiPrime> listaMateriiPrime = new List<MateriiPrime>();

        public PreluareRaport()
        {
            InitializeComponent();
            listView.AllowDrop = true;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            //BinaryFormatter bf = new BinaryFormatter();
            //ArrayList lista = new ArrayList();
            //foreach (string s in listaMateriiPrime.)       //textBox este un string pe mai ulte linii(multiline) 
            //    lista.Add(s);
            //bf.Serialize(fs, lista);
            //fs.Close();
            //listaMateriiPrime.Clear();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            //BinaryFormatter bf = new BinaryFormatter();
            //ArrayList lista = (ArrayList)bf.Deserialize(fs);          //deserialize returneaza object si fac cast
            //for (int i = 0; i < lista.Count; i++)                        //textBox este un string pe mai ulte linii(multiline) 
            //    tbListaProduse.Text += lista[i] + Environment.NewLine;
            //fs.Close();
        }

        private void InitializareDate(string fisier)
        {
            StreamReader sr = new StreamReader(fisier);
            string linie;
            try
            {
                while ((linie = sr.ReadLine()) != null)
                {
                    int cod = Convert.ToInt32(linie.Split(',')[0]);
                    string denumire = linie.Split(',')[1];
                    float pret = (float)Convert.ToDouble(linie.Split(',')[2]);
                    int stoc = Convert.ToInt32(linie.Split(',')[3]);

                    MateriiPrime materiiPrime = new MateriiPrime(cod, denumire, pret, stoc);
                    listaMateriiPrime.Add(materiiPrime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sr.Close();

        }

        private void InitializareListView()
        {
            foreach (MateriiPrime mp in listaMateriiPrime)
            {
                ListViewItem itm = new ListViewItem(mp.Cod.ToString());
                itm.SubItems.Add(mp.Denumire);
                itm.SubItems.Add(mp.Pret.ToString());
                itm.SubItems.Add(mp.Stoc.ToString());
                listView.Items.Add(itm);
            }
        }

        private void btn_parsare_Click(object sender, EventArgs e)
        {
            InitializareDate("PieseAuto.txt");
            InitializareListView();
        }

        //DRAG DROP

       
    }
}
