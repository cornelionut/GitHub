using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestiuneStocuri;
using GraficaSeminar7;
using Gestiune_Stocuri_Forms;
using WindowsFormsApplicationDB;

namespace GestiuneStocuri
{
    public partial class PaginaPrincipala : Form
    {
        public PaginaPrincipala()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            INTRARI bf = new INTRARI();
            bf.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_preluareRaport_Click_1(object sender, EventArgs e)
        {
            PreluareRaport pr = new PreluareRaport();
            pr.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect realizat de Baciu Cornel-Ionut An III");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            RaportPieChart rp = new RaportPieChart();
            rp.Show();
        }

        private void rateUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ati acordat o nota aplicatiei!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Comenzi comenzi = new Comenzi();
            comenzi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
