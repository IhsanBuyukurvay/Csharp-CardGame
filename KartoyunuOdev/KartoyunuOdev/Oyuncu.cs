using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartoyunuOdev
{
    class Oyuncu
    {
        Deste destemizz = new Deste();
        public void Baslat1()
        {
            destemizz.Olustur();
            destemizz.karistir();
        }
        public void Oyna1()
        {
            Kart o1k1 = destemizz.KartVer();
           
            Kart o1k2 = destemizz.KartVer();
           
            Kart o1k3 = destemizz.KartVer();
            
            Kart o1k4 = destemizz.KartVer();
          
            Kart o1k5 = destemizz.KartVer();
         
            Kart o1k6 = destemizz.KartVer();
           
            Kart o2k1 = destemizz.KartVer();
            
            Kart o2k2 = destemizz.KartVer();
          
            Kart o2k3 = destemizz.KartVer();
        ;
            Kart o2k4 = destemizz.KartVer();
            
            Kart o2k5 = destemizz.KartVer();
            
            Kart o2k6 = destemizz.KartVer();
            
            Kart o3k1 = destemizz.KartVer();
            
            Kart o3k2 = destemizz.KartVer();
            
            Kart o3k3 = destemizz.KartVer();
            
            Kart o3k4 = destemizz.KartVer();
            
            Kart o3k5 = destemizz.KartVer();
            
            Kart o3k6 = destemizz.KartVer();
            
            string[] oyuncuu1 = new string[6] { o1k1.KartInfo(), o1k2.KartInfo(), o1k3.KartInfo(), o1k4.KartInfo(), o1k5.KartInfo(), o1k6.KartInfo() };            
            Console.WriteLine($"{"oyuncu1"}");
            for (int counter = 0; counter < oyuncuu1.Length; ++counter)
            {
                Console.WriteLine($"{oyuncuu1[counter]}");
            }

                

           

        }
    }
}
