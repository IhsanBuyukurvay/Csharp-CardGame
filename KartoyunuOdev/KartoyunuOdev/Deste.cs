using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartoyunuOdev
{
    class Deste
    {
        Kart[] kartlar = new Kart[18];
        int DagitilanKS = 0; //dagitilan kart sayisi
        public void Olustur()
        {
            string[] Turler = new string[3] { "K", "S", "M" };
            string[] Sayilar = new string[5] { "1", "2", "3", "4", "5"};
            string[] special = new string[1] { "RD" };
            string[] spesayi = new string[3] { "1", "2", "3" };
            int k = 0;
            for(int i=0; i<3; i++)
                for(int j=0; j<5; j++)
                    
                    {
                        kartlar[k] = new Kart();
                        kartlar[k].Turu = Turler[i];
                        kartlar[k].Sayisi = Sayilar[j];                       
                        k++;
                    }
            for(int s=0;s<1;s++)
                for(int z = 0; z < 3; z++)
                {
                    kartlar[k] = new Kart();
                    kartlar[k].SpecialS = special[s];
                    kartlar[k].Specsayi = spesayi[z];
                    k++;
                }
        }
       
        public void karistir()
        {
            Random sayiGen = new Random();
            for (int k = 0; k < 18; k++)
            {
                int rIndis = sayiGen.Next(0, 18);
                Kart gecici = kartlar[k];
                kartlar[k] = kartlar[rIndis];
                kartlar[rIndis] = gecici;
            }
        }
        public Kart KartVer()
        {
            
                return kartlar[DagitilanKS++];
            
        }
        
    }
}
