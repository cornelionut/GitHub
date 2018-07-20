using GestiuneStocuri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Gestiune_Stocuri_Forms
{
    public partial class Logare : Form
    {
        string Provider = null;

        public Logare()
        {
            InitializeComponent();
            Provider = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = utilizator.mdb ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_Utilizator.Text = "";
            tb_Password.Clear();
            tb_Utilizator.Focus(); //cursor pe utilizator
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();

            //PaginaPrincipala p = new PaginaPrincipala();
            //    p.Show();

            //OleDbConnection conexiune = new OleDbConnection(Provider);
            //OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM Login WHERE Nume='" + tb_Utilizator.Text + "'Parola='" + tb_Password.Text + "'", conexiune);
            //DataTable dataTable = new DataTable();

            //try
            //{
            //    dataAdapter.Fill(dataTable);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conexiune.Close();
            //}



            //if (dataTable.Rows[0][0].ToString() == "1")
            //{
            //    this.Hide();

            //    PaginaPrincipala p = new PaginaPrincipala();
            //    p.Show();

            //}
            //else
            //{
            //    MessageBox.Show(" Datele parola sau utilizator nu sunt corecte!");

            //}

            OleDbConnection con = new OleDbConnection(Provider);

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            com.CommandText = "SELECT * FROM Login where Nume ='" + tb_Utilizator.Text + "' and Parola='" + tb_Password.Text + "'";

  
                OleDbDataReader r = com.ExecuteReader();
                int count = 0;
                while (r.Read())
                {
                    count = count + 1;
                }
            if (count == 1)
            {
                PaginaPrincipala p = new PaginaPrincipala();
                this.Hide();
                p.ShowDialog();
                this.Show();
            }
            else
            {
               MessageBox.Show(" Datele parola sau utilizator nu sunt corecte!");

            }

            con.Close();
                     
        }
    }
 }
