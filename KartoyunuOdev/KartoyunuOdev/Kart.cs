using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartoyunuOdev
{
    class Kart
    {
        public string Turu;
        public string Sayisi;
        public string SpecialS;
        public string Specsayi;
        
        public string KartInfo()
        {
            if (SpecialS == "RD")
            {
                Console.WriteLine("{0}", SpecialS);
            }
            else
                Console.WriteLine("{0}{1}", Turu, Sayisi);
            return (" ");
        }
    }
}
