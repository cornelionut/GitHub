using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplicationDB
{
    public partial class TreePiese : Form
    {
        private List<Produse> listaPiese;
        private string[] piese1;

        public TreePiese(List<Produse> lista, string[] facultati)
        {
            listaPiese = lista;
            this.piese1 = facultati;
            InitializeComponent();

            refreshData();
        }
        public void refreshData()
        {
            this.treeView1.Nodes.Clear();
            foreach (string tip in piese1)
            {
                TreeNode nodPiese = new TreeNode(tip);
                foreach (Produse stud in listaPiese)
                {
                    if (stud.tip.Equals(tip))
                    {
                        TreeNode nodStud = new TreeNode(stud.denumire);
                        nodPiese.Nodes.Add(nodStud);
                    }
                }
                this.treeView1.Nodes.Add(nodPiese);
            }
            this.treeView1.ExpandAll();
        }
    }
}
