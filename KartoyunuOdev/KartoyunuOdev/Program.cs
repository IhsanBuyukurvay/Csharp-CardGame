using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartoyunuOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyunumuz = new Oyuncu();
            oyunumuz.Baslat1();
            oyunumuz.Oyna1();
            Console.ReadKey();
           

        }
    }
}
