using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorceProjektowe.Obserwator;

namespace WzorceProjektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            DanePogodowe danePogodowe = new DanePogodowe();
            WarunkiBiezaceWyswietlacz warunkiBiezaceWyswietlacz = new WarunkiBiezaceWyswietlacz(danePogodowe);

            danePogodowe.Ustaw(22.2f, 34f, 1000);
            danePogodowe.Ustaw(22.2f, 44f, 999);
            danePogodowe.Ustaw(22.2f, 14f, 1000);

            Console.ReadKey();
        }
    }
}