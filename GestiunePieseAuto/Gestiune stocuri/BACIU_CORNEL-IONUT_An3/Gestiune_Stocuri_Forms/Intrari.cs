using Gestiune_Stocuri_Forms;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using GestiuneStocuri;

namespace GestiuneStocuri
{
    public partial class INTRARI : Form
    {
        ArrayList listaTextBoxes = new ArrayList();
        ArrayList listaProd = new ArrayList();

        public INTRARI()
        {
            InitializeComponent();
            listaTextBoxes.Add(tb_Produs);   //denumire
            listaTextBoxes.Add(tb_Cantitate);
            listaTextBoxes.Add(tb_Pret);
            listaTextBoxes.Add(tb_Valoare);
        }

        private void btn_Adauga_Click(object sender, EventArgs e)
        {
            int x = ((TextBox)listaTextBoxes[0]).Location.X;
            int y = ((TextBox)listaTextBoxes[listaTextBoxes.Count - 1]).Location.Y;
            int dist = ((TextBox)listaTextBoxes[1]).Location.X - ((TextBox)listaTextBoxes[0]).Location.X;

            for (int i = 0; i < 4; i++)
            {
                TextBox tbNou = new TextBox();
                tbNou.Location = new Point(x, y + 30);
                x += dist;
                if (i == 4)
                    tbNou.ReadOnly = true;
                listaTextBoxes.Add(tbNou);
                Controls.Add(tbNou);
            }
            for (int i = 0; i < listaTextBoxes.Count; i += 4)
            {
                ((TextBox)listaTextBoxes[i + 1]).KeyPress += new KeyPressEventHandler(tb_Pret_KeyPress);
                ((TextBox)listaTextBoxes[i + 2]).KeyPress += new KeyPressEventHandler(tb_Pret_KeyPress);
            }
        }

        private void btn_Calculeaza_Click(object sender, EventArgs e)
        {
            float total = 0;
            for (int i = 0; i < listaTextBoxes.Count; i += 4)
            {
                if (((TextBox)listaTextBoxes[i]).Text == "")
                    errorProvider1.SetError((TextBox)listaTextBoxes[i], "Introduceti denumire");
                else if (((TextBox)listaTextBoxes[i + 1]).Text == "")
                    errorProvider1.SetError((TextBox)listaTextBoxes[i + 1], "Introduceti cantitatea");
                else if (((TextBox)listaTextBoxes[i + 2]).Text == "")
                    errorProvider1.SetError((TextBox)listaTextBoxes[i + 2], "Introduceti pret");
                else
                {
                    errorProvider1.Clear();
                    float valoare = 0;
                    for (int j = 0; j < listaTextBoxes.Count; j += 4)
                    {
                        string denumire = ((TextBox)listaTextBoxes[i]).Text;
                        float cantitate = (float)Convert.ToDouble(((TextBox)listaTextBoxes[i + 1]).Text);
                        float pret = (float)Convert.ToDouble(((TextBox)listaTextBoxes[i + 2]).Text);

                        if (radio_da.Checked == true)
                            valoare = (float)Convert.ToDouble((pret * cantitate) - pret * cantitate * (0.24 / 100));
                        else
                            valoare = pret * cantitate;
                        ((TextBox)listaTextBoxes[i + 3]).Text = valoare.ToString();
                    }
                    total += valoare;
                }
                tb_Total.Text = total.ToString();
            }
        }

        private void tb_Pret_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaPrincipala f1 = new PaginaPrincipala();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listaTextBoxes.Count; i += 3)
                {
                    string denumire = ((TextBox)listaTextBoxes[i]).Text;
                    int cantitate = Convert.ToInt32(((TextBox)listaTextBoxes[i + 1]).Text);
                    float pret = (float)Convert.ToDouble(((TextBox)listaTextBoxes[i + 2]).Text);

                    MateriiPrime mp = new MateriiPrime(denumire, pret, cantitate);
                    listaProd.Add(mp);
                    AfisareProduse lpf = new AfisareProduse(listaProd);
                    lpf.Show();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Introduceti cel putin un produs!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            float total = 0;
            total = (float)Convert.ToDouble(tb_Total.Text);
            float discount = (float)Convert.ToDouble(total * 0.1);

            total = total - discount;
                    tb_discount.Text = total.ToString();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < listaTextBoxes.Count; j++)
            {
                listaTextBoxes[j] = " ";
                tb_discount.Clear();
                tb_Pret.Clear();
                tb_Produs.Clear();
                tb_Total.Clear();
                tb_Valoare.Clear();
            }
        }


    }
}
