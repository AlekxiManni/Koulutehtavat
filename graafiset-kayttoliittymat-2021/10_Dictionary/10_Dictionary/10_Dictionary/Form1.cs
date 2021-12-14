using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Dictionary
{
    public partial class Form1 : Form
    {

        Dictionary<string, string> Luettelo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Luo_Dictionary_button_Click(object sender, EventArgs e)
        {
            Luettelo = new Dictionary<string, string>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Luettelo.Add(Key_textBox.Text, Value_textBox.Text);
        }

        private void Hae_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string hakuKey = hakuKey_textBox.Text;
                ValueLabel.Text = Luettelo[hakuKey];
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                MessageBox.Show("Valittua avainta ei löydy luettelosta!");
                return;
            }

        }
    }
}
