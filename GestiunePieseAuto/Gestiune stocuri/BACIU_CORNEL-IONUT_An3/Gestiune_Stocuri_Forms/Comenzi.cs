using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiune_Stocuri_Forms
{
    public partial class Comenzi : Form
    {
        public Comenzi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)  //TextBox
        {
            textBox1.SelectAll();
            listBox.DoDragDrop(textBox1.Text, DragDropEffects.All);
        }

        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            listBox.Items.Add(e.Data.GetData(DataFormats.Text));
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
