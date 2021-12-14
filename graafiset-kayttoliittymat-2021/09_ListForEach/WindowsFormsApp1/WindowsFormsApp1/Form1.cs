using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<String> Lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void LuoLista_Button_Click(object sender, EventArgs e)
        {
            Lista = new List<String>();
        }

        private void Lisaa_Button_Click(object sender, EventArgs e)
        {
            Lista.Add(Lisaa_TextBox.Text);
        }
        private void Haku_Button_Click(object sender, EventArgs e)
        {
            foreach(string hakuTulos in Lista)
            {
                comboBox1.Items.Add(hakuTulos);
            }
        }
    }
}
