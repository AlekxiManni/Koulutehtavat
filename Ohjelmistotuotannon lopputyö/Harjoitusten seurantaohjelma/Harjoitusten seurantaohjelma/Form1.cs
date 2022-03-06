using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Harjoitusten_seurantaohjelma
{
    public partial class Form1 : Form
    {
        //Luokka mihin tallennetaan käyttäjän syöttämien attribuuttien sisältö
        Treenit treeniLuokkaan = new Treenit();

        //Lista on vain käyttäjälle tietoa mikä annetaan myöhemmin TextBoxin viestissä.
        List<string> treeniInfoLista = new List<string>();

        List<Treenit> treeniLuokkaanLista = new List<Treenit>();

        //Luokka mikä hallitsee yhteyttä Sql -tietokantaan
        DatabaseControl kontrolli = new DatabaseControl();

        public Form1()
        {
            InitializeComponent();
        }

        //Lisätään tiedot listaan
        private void lisaa_button_Click(object sender, EventArgs e)
        {
            DateTime aika;
            string liike;
            string sarjat;
            string toistot;
            string paino;

            dataGridView1.Rows.Add(
                dateTimePicker1.Value,
                liike_textBox.Text,
                sarjat_textBox.Text,
                toistot_textBox.Text,
                paino_textBox.Text);

            if (String.IsNullOrEmpty(paino_textBox.Text))
            {
                aika = dateTimePicker1.Value;
                liike = liike_textBox.Text;
                sarjat = sarjat_textBox.Text;
                toistot = toistot_textBox.Text;
                paino = "0";

                treeniInfoLista.Add("PVM : " + aika.ToString("yyyy-MM-dd") + " Harjoituksen nimi: " + liike + " Sarjamäärä: " + sarjat + " Toistomäärä: " + toistot + " Sarjapaino: " + paino);

                treeniLuokkaan.Pvm = dateTimePicker1.Value;
                treeniLuokkaan.Liike = liike_textBox.Text;
                treeniLuokkaan.Sarjat = sarjat_textBox.Text;
                treeniLuokkaan.Toistot = toistot_textBox.Text;
                treeniLuokkaan.Paino = "0";

                treeniLuokkaanLista.Add(new Treenit
                {
                    Pvm = aika,
                    Liike = liike,
                    Sarjat = sarjat,
                    Toistot = toistot,
                    Paino = "0"
                });
                
            }
            else
            {
                aika = dateTimePicker1.Value;
                liike = liike_textBox.Text;
                sarjat = sarjat_textBox.Text;
                toistot = toistot_textBox.Text;
                paino = paino_textBox.Text;

                treeniInfoLista.Add("PVM : " + aika.ToString("yyyy-MM-dd") + " Harjoituksen nimi: " + liike + " Sarjamäärä: " + sarjat + " Toistomäärä: " + toistot + " Sarjapaino: " + paino);

                treeniLuokkaan.Pvm = dateTimePicker1.Value;
                treeniLuokkaan.Liike = liike_textBox.Text;
                treeniLuokkaan.Sarjat = sarjat_textBox.Text;
                treeniLuokkaan.Toistot = toistot_textBox.Text;
                treeniLuokkaan.Paino = paino_textBox.Text;

                treeniLuokkaanLista.Add(new Treenit
                {
                    Pvm = aika,
                    Liike = liike,
                    Sarjat = sarjat,
                    Toistot = toistot,
                    Paino = paino
                });
            }
            

            liike_textBox.Clear();
            sarjat_textBox.Clear();
            toistot_textBox.Clear();
            paino_textBox.Clear();
            
        }

        private void poista_button_Click(object sender, EventArgs e)
        {
            //Voidaan poistaa valittu rivi dataGridView1 -datataulusta. Samalla se poistetaan kahdesta listasta
            //toinen lista on string -lista mikä ilmoittaa käyttäjälle tallennetut treenit ja toinen lista
            // on luokan Treenit -attribuutit.

            int i = dataGridView1.CurrentCell.RowIndex;
            if (i > -1)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(i);
                    treeniLuokkaanLista.RemoveAt(i);
                    treeniInfoLista.RemoveAt(i);
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
                catch(InvalidOperationException) //tyhjän rivin poistaminen aiheuttaa virheen.
                {
                    return;
                }
            }
        }

        //tallennetaan listat tietokantaan
        private void tallenna_button_Click(object sender, EventArgs e)
        {
            var viesti = string.Join(Environment.NewLine, treeniInfoLista);

            MessageBox.Show(viesti, "Tallennettu:");
            dataGridView1.Rows.Clear();

            kontrolli.connectDatabase();
            string query = "INSERT INTO dbo.gymtable (pvm, liike, sarjat, toistot, paino) VALUES (@pvm,@liike,@sarjat,@toistot,@paino)";

            foreach (Treenit tallennetutTreenit in treeniLuokkaanLista)
            {
                SqlCommand lisaaTietokantaan = new SqlCommand(query, kontrolli.yhteys);
                lisaaTietokantaan.Parameters.AddWithValue("@pvm", tallennetutTreenit.Pvm);
                lisaaTietokantaan.Parameters.AddWithValue("@liike", tallennetutTreenit.Liike);
                lisaaTietokantaan.Parameters.AddWithValue("@sarjat", tallennetutTreenit.Sarjat);
                lisaaTietokantaan.Parameters.AddWithValue("@toistot", tallennetutTreenit.Toistot);
                lisaaTietokantaan.Parameters.AddWithValue("@paino", tallennetutTreenit.Paino);
                lisaaTietokantaan.ExecuteNonQuery();
            }
            kontrolli.disconnectDatabase();
        }
        //Avataan toinen ikkuna mistä päästään tulosarkistoon
        private void button_tulosarkisto_Click(object sender, EventArgs e)
        {
            Form2 tulosarkisto = new Form2();
            tulosarkisto.ShowDialog();
        }
        //poistu ohjelmasta
        private void poistuOhjelmastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
