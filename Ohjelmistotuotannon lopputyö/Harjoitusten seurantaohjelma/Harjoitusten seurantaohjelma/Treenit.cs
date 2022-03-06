using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitusten_seurantaohjelma
{
    public class Treenit
    {
        private DateTime pvm;
        private string liike;
        private string sarjat;
        private string toistot;
        private string paino;

        public DateTime Pvm { get => pvm; set => pvm = value; }
        public string Liike { get => liike; set => liike = value; }
        public string Sarjat { get => sarjat; set => sarjat = value; }
        public string Toistot { get => toistot; set => toistot = value; }
        public string Paino { get => paino; set => paino = value; }
        
    }
}
