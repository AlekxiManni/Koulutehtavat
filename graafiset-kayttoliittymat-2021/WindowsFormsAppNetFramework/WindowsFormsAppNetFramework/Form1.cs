using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNetFramework
{
    public partial class Form1 : Form

    {

        


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBoxNimi.Text = "[Elokuvan nimi]";
            textBoxJulkaisuvuosi.Text = DateTime.Today.ToString("yyyy");
            textBoxMin.Text = "0";
            textBoxArvio.Text = "[Kirjoita arvio tähän]";
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Tämän sovelluksen on tehnyt Alekxi Manni!";
            MessageBox.Show(message);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if(textBoxNimi.Text != textBoxNimi.Text)
            //{
            //    textBoxNimi.Modified = true;
                
            //}
            //else
            //{
            //    textBoxNimi.Modified = false;
            //}
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTallenna_Click(object sender, EventArgs e)
        {
            string virheViesti = String.Empty;

            if(!textBoxNimi.Modified || String.IsNullOrWhiteSpace(textBoxNimi.Text))
            {
                virheViesti += "Et ole syöttänyt mitään nimi -kenttään!" + Environment.NewLine;
            }
            if (String.IsNullOrWhiteSpace(textBoxJulkaisuvuosi.Text))
            {
                virheViesti += "Et ole syöttänyt mitään Julkaisuvuosi -kenttään!" + Environment.NewLine;
            }
            if (String.IsNullOrWhiteSpace(textBoxMin.Text))
            {
                virheViesti += "Et ole syöttänyt mitään Kesto -kenttään!" + Environment.NewLine;
            }
            if(!int.TryParse(textBoxJulkaisuvuosi.Text,out _))
            {
                virheViesti += "Julkaisuvuosi ei ole vain numeroita!" + Environment.NewLine;
            }
            if (!int.TryParse(textBoxMin.Text, out _))
            {
                virheViesti += "Kesto ei ole vain numeroita!" + Environment.NewLine;
            }


            if (virheViesti.Length != 0)
            {
                MessageBox.Show(virheViesti);
            }
            else
            {
                MessageBox.Show("Elokuvan tiedot tallennettu!");
            }

        }

        private void buttonPoista_Click(object sender, EventArgs e)
        {

        }

        private void tietojaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string message = "Tämän sovelluksen on tehnyt Alekxi Manni!";
            MessageBox.Show(message);
        }

        private void TextBoxJulkaisuvuosi(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            this.Text = d.ToString("YYYY");
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxNimi_Click(object sender, EventArgs e)
        {
            textBoxNimi.Text = string.Empty;
        }

        private void textBoxJulkaisuvuosi_Click(object sender, EventArgs e)
        {
            textBoxJulkaisuvuosi.Text = string.Empty;
        }

        private void textBoxMin_Click(object sender, EventArgs e)
        {
            textBoxMin.Text = string.Empty;
        }

        private void textBoxNimi_Leave(object sender, EventArgs e)
        {
            if (!textBoxNimi.Modified)
            {
                textBoxNimi.Text = "[Elokuvan nimi]";
            }
        }

        private void textBoxJulkaisuvuosi_Leave(object sender, EventArgs e)
        {
            if (!textBoxJulkaisuvuosi.Modified)
            {
                textBoxJulkaisuvuosi.Text = textBoxJulkaisuvuosi.Text = DateTime.Today.ToString("yyyy");
            }
        }

        private void textBoxMin_Leave(object sender, EventArgs e)
        {
            if (!textBoxMin.Modified)
            {
                textBoxMin.Text = "0";
            }
        }

        private void textBoxArvio_Click(object sender, EventArgs e)
        {
            textBoxArvio.Text = string.Empty;
        }

        private void textBoxArvio_Leave(object sender, EventArgs e)
        {
            if (!textBoxArvio.Modified)
            {
                textBoxArvio.Text = "[Kirjoita arvio tähän]";
            }
        }
    }
}
