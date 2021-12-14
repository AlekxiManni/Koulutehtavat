using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _05_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            int.TryParse(textBox1.Text, out numero);
            for (int i = 0; i <= numero; i++)
            {
                Thread.Sleep(100);
                label1.Text = Convert.ToString(i);
            }

        }




    }
}

        //KOKEILTU MOODLEN ESIMERKKIÄ :



//        private void button1_Click(object sender, EventArgs e)

//        {
//            Thread OmaSaie;

//            // Luodaan toissijainen säie ja käynnistetään se Start()-metodilla. 

//            OmaSaie = new Thread(new ThreadStart(this.SaieProceduuri));
//            OmaSaie.Start();
//        }

//        private void SaieProceduuri()
//        {
//            // Muutetaan tekstinä oleva numero kokonaisluvuksi. 
//            Int32 Kierrokset = Convert.ToInt32(textBox1.Text);

//            for (Int32 i = 0; i < Kierrokset; i++)
//            {
//                string uusiNumero = (i + 1).ToString();
//                this.AsetaTeksti(uusiNumero);

//                // Viive 

//                Thread.Sleep(10);
//            }

//        }

//        delegate void StringArgReturningVoidDelegate(string texti);

//        private void AsetaTeksti(string texti)
//        {
//            // InvokeRequired required compares the thread ID of the   
//            // calling thread to the thread ID of the creating thread.   
//            // If these threads are different, it returns true.   

//            if (this.label1.InvokeRequired)

//            {   //Herätetään alkuperäinen säie 

//                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(AsetaTeksti);

//                this.Invoke(d, new object[] { texti });

//            }

//            else

//            {   //Jos on alkupeäinen säie laitetaan se ´muuttamaan teksti 

//                this.label1.Text = texti;

//            }

//        }



//    }
//}
