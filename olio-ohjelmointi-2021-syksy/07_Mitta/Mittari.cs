using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Mitta
{
    class Mittari
    {
        private int _mitta;

        public Mittari()
        {
            _mitta = 0;
        }

        public void Lisaa()
        {
            if(_mitta == 5)
            {
                return;
            }
            _mitta++;
        }
        public void Vahenna()
        {
            
            if (_mitta == 0)
            {
                Console.WriteLine("Mitta tyhjä!");
            }
            _mitta--;
        }
        public int Mitta()
        {
            return _mitta;
        }
        public bool Taynna()
        {
            if(_mitta == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
