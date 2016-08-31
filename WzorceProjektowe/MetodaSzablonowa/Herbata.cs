using System;

namespace WzorceProjektowe.MetodaSzablonowa
{
    public class Herbata : Napoj
    {
        protected override void Zaparzenie()
        {
            Console.WriteLine("Wsypywanie fusów...");
        }
    }
}