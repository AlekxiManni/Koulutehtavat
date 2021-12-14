using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Array
{
    public partial class Form1 : Form
    {
        int taulukonKoko;
        int[] taulukko;
        int tallennettavaNumero;
        int indeksi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Luo_Taulukko_Click(object sender, EventArgs e)
        {
            try
            {
                taulukonKoko = Convert.ToInt32(Taulukon_koko_TextBox.Text);
                taulukko = new int[taulukonKoko+1];
                //Lisätty taulukkoon yksi muistipaikka lisää haun ja tallentamisen yksinkertaistamiseksi.
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Tarkista että kirjoitat vain numeroita etkä jätä laatikkoa tyhjäksi!");
            }
            
        }
        
        private void Talleta_Click(object sender, EventArgs e)
        {
            try
            {
                tallennettavaNumero = Convert.ToInt32(Tallennettava_Numero_TextBox.Text);
                indeksi = Convert.ToInt32(Tallennuspaikan_Indeksi_TextBox.Text);
                taulukko[indeksi] = tallennettavaNumero;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Tallennuspaikan indeksi on liian suuri taulukon kokoon nähden!");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Tarkista että kirjoitat vain numeroita etkä jätä laatikkoa tyhjäksi!");
            }
            
        }

        private void Hae_Click(object sender, EventArgs e)
        {
            try
            {
                int haku = Convert.ToInt32(Tallennuspaikan_Indeksi_HAKU_TextBox.Text);
                string tulostus = taulukko[haku].ToString();
                Tulostus.Text = tulostus;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Yrität etsiä taulukon ulkopuolelta!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Tarkista että kirjoitat vain numeroita etkä jätä laatikkoa tyhjäksi!");
            }
        }

    }
}
