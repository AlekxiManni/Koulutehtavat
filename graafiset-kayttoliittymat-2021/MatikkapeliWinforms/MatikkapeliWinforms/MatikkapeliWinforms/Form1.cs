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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helppo_Click(object sender, EventArgs e)
        {
            Form helppo = new Form2();
            helppo.Show();
        }

        private void keskivaikea_Click(object sender, EventArgs e)
        {
            Form keskivaikea = new KeskivaikeaForm();
            keskivaikea.Show();
        }

        private void vaikea_Click(object sender, EventArgs e)
        {
            Form vaikea = new VaikeaForm();
            vaikea.Show();
        }
    }
    public class VaikeaForm : Form2
    {
        override public void ArvoNumerot()
        {
            Random random1 = new Random();
            Random random2 = new Random();
            a = random1.Next(1, 500);
            b = random2.Next(100, 400);
            c = random1.Next(500, 1001);
            d = random2.Next(1, 499);
        }
    }
    public class KeskivaikeaForm : Form2
    {
        override public void ArvoNumerot()
        {
            Random random1 = new Random();
            Random random2 = new Random();
            a = random1.Next(5, 50);
            b = random2.Next(10, 40);
            c = random1.Next(100, 201);
            d = random2.Next(50, 101);
        }
    }
}
