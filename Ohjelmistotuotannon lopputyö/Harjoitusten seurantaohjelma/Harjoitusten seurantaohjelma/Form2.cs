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
    public partial class Form2 : Form
    {
        DatabaseControl kontrolli;

        List<Treenit> listasta = new List<Treenit>();

        DateTime aikahaku;

        SqlCommand komento = new SqlCommand();

        public Form2()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //tulostetaan listBoxiin hauetun päivämäärän treenit
            getTreenitFromDatabase();
            label2.Text = "Tulokset: ";
            foreach (Treenit treenitToList in listasta)
            {
                listBox1.Items.Add("Liike: " + treenitToList.Liike);
                listBox1.Items.Add("Sarjat: " +treenitToList.Sarjat);
                listBox1.Items.Add("Toistot: " + treenitToList.Toistot);
                listBox1.Items.Add("Paino: " + treenitToList.Paino);
                listBox1.Items.Add("------------------------------------------------------------------------------");
            }
            listasta.Clear();
        }

        public List<Treenit> getTreenitFromDatabase()
        {
            kontrolli = new DatabaseControl();
            kontrolli.connectDatabase();

            aikahaku = dateTimePickerHaku.Value;
            string aikahakuQuery = aikahaku.ToString("yyyy-MM-dd");
            komento = new SqlCommand("SELECT * FROM dbo.gymtable WHERE pvm = '" + aikahakuQuery + "'", kontrolli.yhteys);
            var reader = komento.ExecuteReader();
            while (reader.Read())
            {
                Treenit treeniListasta = new Treenit();
                treeniListasta.Liike = reader.GetString(2);
                treeniListasta.Sarjat = reader.GetString(3);
                treeniListasta.Toistot = reader.GetString(4);
                treeniListasta.Paino = reader.GetString(5);
                listasta.Add(treeniListasta);
            }
            kontrolli.disconnectDatabase();
            return listasta;

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void poistuOhjelmastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }


}
