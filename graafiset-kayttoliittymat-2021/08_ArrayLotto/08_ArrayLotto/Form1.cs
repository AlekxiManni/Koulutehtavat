using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_ArrayLotto
{
    public partial class Form1 : Form
    {
        //Alustetaan lisänumerot, lottonumerot ja valinnat -taulukot


        Random arvonta = new Random();

        int[] lisanumerot = new int[2];
        int[] lottonumerot = new int[7];
        int[] valinnat = new int[7];

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int oikeatNumerot = 0;
            int oikeatLisaNumerot = 0;

            //Virheentarkistus
            try
            {
                valinnat[0] = Convert.ToInt32(textBox1.Text);
                valinnat[1] = Convert.ToInt32(textBox2.Text);
                valinnat[2] = Convert.ToInt32(textBox3.Text);
                valinnat[3] = Convert.ToInt32(textBox4.Text);
                valinnat[4] = Convert.ToInt32(textBox5.Text);
                valinnat[5] = Convert.ToInt32(textBox6.Text);
                valinnat[6] = Convert.ToInt32(textBox7.Text);

                Array.Sort(valinnat);
                
                string pelattuString =
                valinnat[0].ToString() + ", " +
                valinnat[1].ToString() + ", " +
                valinnat[2].ToString() + ", " +
                valinnat[3].ToString() + ", " +
                valinnat[4].ToString() + ", " +
                valinnat[5].ToString() + ", " +
                valinnat[6].ToString();

                pelattuLabel.Text = pelattuString;
            }
            catch (FormatException)
            {
                MessageBox.Show("Syötä vain numeroita!");
                return;
            }
            //Vertaillaan valintoja, ettei valinta ole 0 tai yli 40
            if (valinnat[0] < 1 || valinnat[0] > 40 ||
                valinnat[1] < 1 || valinnat[1] > 40 ||
                valinnat[2] < 1 || valinnat[2] > 40 ||
                valinnat[3] < 1 || valinnat[3] > 40 ||
                valinnat[4] < 1 || valinnat[4] > 40 ||
                valinnat[5] < 1 || valinnat[5] > 40 ||
                valinnat[6] < 1 || valinnat[6] > 40)
            {
                MessageBox.Show("Anna numero 1-40 väliltä");
            }
            //Käytetyt numerot
            bool[] kaytetytNumerot = new bool[40];
            //Loopilla valitaan pallot random.arvonta.Next -luokalla, ja merkataan bool[] kaytetytNumerot taulukkoon onko jokin
            //numero käytetty. Sama lisänumeroille.
            for(int i = 0; i < lottonumerot.Length; i++)
            {
                do
                {
                    lottonumerot[i] = arvonta.Next(1, 41);

                } while (kaytetytNumerot[lottonumerot[i] - 1]);
                kaytetytNumerot[lottonumerot[i] - 1] = true;
            }

            for(int i = 0; i < lisanumerot.Length; i++)
            {
                do
                {
                    lisanumerot[i] = arvonta.Next(1, 41);
                } while (kaytetytNumerot[lisanumerot[i] - 1]);
                kaytetytNumerot[lisanumerot[i] - 1] = true;
            }


            Array.Sort(lottonumerot);
            Array.Sort(lisanumerot);

            string lottorivi =
            lottonumerot[0].ToString() + ", " +
            lottonumerot[1].ToString() + ", " +
            lottonumerot[2].ToString() + ", " +
            lottonumerot[3].ToString() + ", " +
            lottonumerot[4].ToString() + ", " +
            lottonumerot[5].ToString() + ", " +
            lottonumerot[6].ToString();
            
            string lisanumeroString =
            " Lisänumerot: " +
            lisanumerot[0].ToString() + ", " +
            lisanumerot[1].ToString();
            LottoriviLabel.Text = lottorivi + lisanumeroString;


            //Tarkistetaan osumat ja lisätään ne oikeatNumerot muuttujaan loopilla. Sama lisänumeroille.

            for (int i = 0; i < lottonumerot.Length; i++)
            {

                for (int j = 0; j < valinnat.Length; j++)
                {
                    if (valinnat[i] == lottonumerot[j])
                    {
                        oikeatNumerot++;
                        break;
                    }
                }
            
            for (int i = 0; i < 7; i++)
            {

                for (int j = 0; j < lisanumerot.Length; j++)
                {
                    if (valinnat[i] == lisanumerot[j])
                    {
                        oikeatLisaNumerot++;
                        break;
                    }
                }
            }
            //Tulostetaan yhdelle label -elementille oikeiden osumien määrä sekä lisänumeroiden osumien määrä.
            oikeinYhteensaLabel.Text = oikeatNumerot.ToString() + "  +  " + oikeatLisaNumerot.ToString();
        }
    }
}
