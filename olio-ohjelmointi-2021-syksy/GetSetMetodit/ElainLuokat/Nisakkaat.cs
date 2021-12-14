using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Nisakkaat : Elain
    {
        private bool poikaset;

        public bool Poikaset { get => poikaset; set => poikaset = value; }

        public void NisakasOminaisuus(bool synnyttaaPoikaset)
        {
            Poikaset = synnyttaaPoikaset;
        }
        public bool NisakasOminaisuusPalautus()
        {
            return Poikaset;
        }
    }
}
