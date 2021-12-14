using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatikkapeliWinforms
{
    public partial class Form2 : Form
    {
        public int pisteet = 0;
        public int a, b, c, d;
        

        public Form2()
        {
            InitializeComponent();
            MuutaStringiksi();
        }
        
        

        private void MuutaStringiksi()
        {
            ArvoNumerot();
            label5.Text = Convert.ToString(a) + " + " + Convert.ToString(b);
            label6.Text = Convert.ToString(a) + " - " + Convert.ToString(b);
            label7.Text = Convert.ToString(a) + " * " + Convert.ToString(b);
            label8.Text = Convert.ToString(c) + " / " + Convert.ToString(d);

        }
        public virtual void ArvoNumerot()
        {
            Random random1 = new Random();
            Random random2 = new Random();
            a = random1.Next(6, 10);
            b = random2.Next(1, 5);
            c = 10;
            d = 5;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(textBox1.Text) == a + b)
            {
                pisteet++;
            }
            if (Convert.ToInt32(textBox2.Text) == a - b)
            {
                pisteet++;
            }
            if (Convert.ToInt32(textBox3.Text) == a * b)
            {
                pisteet++;
            }
            if (Math.Abs(Convert.ToInt32(textBox4.Text) - c/d) <= 1)
            {
                pisteet++;
            }

            MessageBox.Show("Sait yhteensä " + Convert.ToString(pisteet) + " pistettä!");

            
        }
    }
}
