using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApplicationDB
{

    public delegate void handler();

    public partial class Form1 : Form
    {

        public List<Produse> listaPiese;


        public void doRefresh()
        {
            this.connectToolStripMenuItem_Click(null, null);
            if (eventRefresh != null)
                eventRefresh();
        }

        public Form1()
        {
            listaPiese = new List<Produse>();
            InitializeComponent();
            ClassDB db = ClassDB.DB;
            db.CONEXIUNE = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = piese.mdb";
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)    // conectare la baza de date si preluare date pise
        {

            OleDbConnection conexiune = new OleDbConnection();
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = piese.mdb";
            conexiune.ConnectionString = connectionString;

            try
            {
                conexiune.Open();
              OleDbCommand comanda =
                    new OleDbCommand(
                        "SELECT * FROM piese;", conexiune);

              OleDbDataReader reader =
                    comanda.ExecuteReader();
                if (reader.HasRows)
                {
                    this.listaPiese.Clear();
                    while (reader.Read())
                    {
                        int id = Int32.Parse(reader["Id"].ToString());
                        string denumire = reader["Denumire"].ToString();
                        string marca = reader["Marca"].ToString();
                        int anFabricatie = Int32.Parse(reader["AnFabricatie"].ToString());
                        string tip = reader["Tip"].ToString();
                        Produse stud = new Produse(id, denumire, marca, anFabricatie, tip);
                        this.listaPiese.Add(stud);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare " + ex.Message);
            }
            finally
            {
                if (conexiune.State == ConnectionState.Open)
                    conexiune.Close();
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           string[] tipPiese =
           new string[] { "Motor", "Caroserie", "Sasiu", "SistemFranare" };
            TreePiese fv =  new TreePiese(listaPiese, tipPiese);
            fv.MdiParent = this;
            Form1.eventRefresh += fv.refreshData;
            fv.Show();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserare fi = new FormInserare();
            fi.MdiParent = this;
            fi.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    





















        public static event handler eventRefresh;
    }
}
