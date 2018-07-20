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
    public partial class FormInserare : Form
    {
        public FormInserare()
        {
            InitializeComponent();
            loadComboMarca(comboBoxMarca);
            loadComboTipPiesa(comboBoxTipPiesa);
            loadComboAnFabricatie(comboBoxAn);
        }

        void loadComboMarca(ComboBox cb)
        {
            cb.Items.Clear();
            ClassDB db = ClassDB.DB;
            OleDbConnection con = db.getConexiune();
            try
            {
                con.Open();
                OleDbCommand cm = new OleDbCommand(
                                 "SELECT * FROM Marca;", con);
                OleDbDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    cb.Items.Add(reader["Marca"].ToString());
                }
                cb.SelectedIndex = 0;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void loadComboTipPiesa(ComboBox cb)
        {
            cb.Items.Clear();
            ClassDB db = ClassDB.DB;
            OleDbConnection con = db.getConexiune();
            try
            {
                con.Open();
                OleDbCommand cm = new OleDbCommand(
                              "SELECT * FROM TipPiesa;", con);
                OleDbDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    cb.Items.Add(reader["TipPiesa"].ToString());
                }
                cb.SelectedIndex = 0;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void loadComboAnFabricatie(ComboBox cb)
        {
            cb.Items.Clear();
            ClassDB db = ClassDB.DB;
            OleDbConnection con = db.getConexiune();
            try
            {
                con.Open();
                OleDbCommand cm =
                    new OleDbCommand(
                        "SELECT * FROM AnFabricatie;", con);
                OleDbDataReader reader =
                      cm.ExecuteReader();

                while (reader.Read())
                {
                    cb.Items.Add(reader["An"].ToString());
                }

                cb.SelectedIndex = 0;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string denumire = tb_Piesa.Text;
            string marca = comboBoxMarca.Text;
            int anFabricatie = Int32.Parse(comboBoxAn.Text);
            string tipPiesa = comboBoxTipPiesa.Text;



            OleDbConnection con = ClassDB.DB.getConexiune();
            try
            {
                con.Open();
                OleDbCommand com = new OleDbCommand(
                            "INSERT INTO piese(Denumire,Marca,AnFabricatie,Tip) " +
                            "VALUES (@Denumire, @Marca, @AnFabricatie,@Tip);", con);

                com.Parameters.Add("Denumire", OleDbType.VarChar).Value =
                    denumire;
                com.Parameters.Add("Marca", OleDbType.VarChar).Value =
                   marca;
                com.Parameters.Add("AnFabricatie", OleDbType.SmallInt).Value =
                    anFabricatie;
                com.Parameters.Add("Tip", OleDbType.VarChar).Value =
                    tipPiesa;

                int nrInregistrari = com.ExecuteNonQuery();
                if (nrInregistrari == 1)
                    MessageBox.Show("Piesa inserata!");
                else
                    throw new Exception("Eroare inserare!");
                Form1 parinte = (Form1)this.MdiParent;
                parinte.doRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
