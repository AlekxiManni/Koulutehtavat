using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristinolla_1
{
    public partial class Form1 : Form
    {
        int[,] taulukko = new int[21, 21];
        bool vuoro;



        public Form1()
        {
           InitializeComponent();

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics Graf = e.Graphics;
            for(int i = 30; i < 660; i += 30)
            {
                Graf.DrawLine(Pens.Black,  + i,  + 30,  + i,  + 630);
                Graf.DrawLine(Pens.Black,  + 30, + i, + 630,  + i);
            }
            for(int j = 0; j < 20; j++)
            {
                for(int y = 0; y < 20; y++)
                {
                    if (taulukko[j, y] == 1)
                    {
                        Graf.FillEllipse(Brushes.Black, 30+j*30 , 30+y*30 , 30, 30);
                        Graf.DrawEllipse(Pens.Black, 30 + j * 30, 30 + y * 30, 30, 30);
                        
                    }
                    else if(taulukko[j, y] == 2)
                    {
                        Graf.FillEllipse(Brushes.White, 30 + j * 30, 30 + y * 30, 30, 30);
                        Graf.DrawEllipse(Pens.Black, 30 + j * 30, 30 + y * 30, 30, 30);
                    }


                }
            }

        }

        private void Form_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bool vuoro;
            try
            {
                do
                {
                    taulukko[e.Location.X / 30 - 1, e.Location.Y / 30 - 1] = 1;
                    vuoro = true;
                    Invalidate();
                    if (vuoro == true)
                    {
                        taulukko[e.Location.X / 30 - 1, e.Location.Y / 30 - 1] = 2;
                        vuoro = false;
                        Invalidate();
                    }
                } while (vuoro);

            }
            catch (IndexOutOfRangeException)
            {
            }
        }
        private void PeliTuomari()
        {
            

        }


        

    }


}

